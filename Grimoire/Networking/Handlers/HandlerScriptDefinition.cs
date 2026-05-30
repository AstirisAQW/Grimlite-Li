using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Grimoire.Networking.Handlers
{
    public enum HandlerTriggerType
    {
        ZoneEvent,
        AnimationMessage
    }

    public enum HandlerScriptConditionType
    {
        None,
        HasAura,
        NotHasAura,
        MapEquals,
        CellEquals
    }

    public enum HandlerScriptActionType
    {
        Walk,
        UseSkill,
        ForceUseSkill,
        Delay
    }

    public class HandlerScriptCondition
    {
        public HandlerScriptConditionType Type { get; set; } = HandlerScriptConditionType.None;
        public string AuraName { get; set; }
        public bool FriendlyAuras { get; set; } = true;
        public string Value { get; set; }
    }

    public class HandlerScriptAction
    {
        public HandlerScriptActionType Type { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string SkillIndex { get; set; }
        public int DelayMs { get; set; }
    }

    public class HandlerScriptRule
    {
        public string ZoneSet { get; set; }
        public string MessageContains { get; set; }
        public List<HandlerScriptCondition> Conditions { get; set; } = new List<HandlerScriptCondition>();
        public List<HandlerScriptAction> Actions { get; set; } = new List<HandlerScriptAction>();

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(ZoneSet))
                return string.Format("Zone {0} ({1} action(s))", ZoneSet, Actions?.Count ?? 0);
            if (!string.IsNullOrWhiteSpace(MessageContains))
                return string.Format("Message contains \"{0}\" ({1} action(s))", MessageContains, Actions?.Count ?? 0);
            return string.Format("Rule ({0} action(s))", Actions?.Count ?? 0);
        }
    }

    public class HandlerScriptDefinition
    {
        public const string FileExtension = ".ghandler";

        public string DisplayName { get; set; }
        public string PacketCommand { get; set; } = "event";
        public HandlerTriggerType TriggerType { get; set; } = HandlerTriggerType.ZoneEvent;
        public int DelayMs { get; set; }
        public List<HandlerScriptRule> Rules { get; set; } = new List<HandlerScriptRule>();
        public List<HandlerScriptAction> DefaultActions { get; set; } = new List<HandlerScriptAction>();
    }

    public static class CustomHandlerRegistry
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        };

        private static readonly Dictionary<string, HandlerScriptDefinition> _definitions =
            new Dictionary<string, HandlerScriptDefinition>(StringComparer.OrdinalIgnoreCase);

        private static readonly Dictionary<string, string> _paths =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        public static string HandlersDirectory =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Handlers");

        public static IReadOnlyCollection<string> CustomDisplayNames =>
            _definitions.Keys.OrderBy(k => k).ToList();

        public static bool TryGetDefinition(string displayName, out HandlerScriptDefinition definition) =>
            _definitions.TryGetValue(displayName, out definition);

        public static bool TryCreateHandler(string displayName, out IJsonMessageHandler handler)
        {
            handler = null;
            if (!_definitions.TryGetValue(displayName, out HandlerScriptDefinition definition))
                return false;

            handler = new HandlerConfigurable(definition);
            return true;
        }

        public static void ReloadFromDisk()
        {
            _definitions.Clear();
            _paths.Clear();

            string dir = HandlersDirectory;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            foreach (string path in Directory.EnumerateFiles(dir, "*" + HandlerScriptDefinition.FileExtension, SearchOption.TopDirectoryOnly))
            {
                try
                {
                    HandlerScriptDefinition definition =
                        JsonConvert.DeserializeObject<HandlerScriptDefinition>(File.ReadAllText(path), SerializerSettings);
                    if (definition == null || string.IsNullOrWhiteSpace(definition.DisplayName))
                        continue;

                    _definitions[definition.DisplayName.Trim()] = definition;
                    _paths[definition.DisplayName.Trim()] = path;
                }
                catch
                {
                }
            }
        }

        public static void Save(HandlerScriptDefinition definition, string path = null)
        {
            if (definition == null || string.IsNullOrWhiteSpace(definition.DisplayName))
                throw new ArgumentException("Handler must have a display name.");

            string dir = HandlersDirectory;
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            string fileName = SanitizeFileName(definition.DisplayName) + HandlerScriptDefinition.FileExtension;
            string target = path ?? Path.Combine(dir, fileName);
            File.WriteAllText(target, JsonConvert.SerializeObject(definition, SerializerSettings));

            _definitions[definition.DisplayName.Trim()] = definition;
            _paths[definition.DisplayName.Trim()] = target;
        }

        public static string GetPath(string displayName)
        {
            return _paths.TryGetValue(displayName, out string path) ? path : null;
        }

        private static string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            return name.Trim();
        }
    }
}
