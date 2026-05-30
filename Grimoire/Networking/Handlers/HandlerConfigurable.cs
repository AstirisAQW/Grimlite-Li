using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grimoire.Botting;
using Grimoire.Game;
using Newtonsoft.Json.Linq;

namespace Grimoire.Networking.Handlers
{
    /// <summary>
    /// Runs a saved .ghandler definition at runtime (no per-zone .cs file required).
    /// </summary>
    public class HandlerConfigurable : IJsonMessageHandler
    {
        private readonly HandlerScriptDefinition _definition;

        public string[] HandledCommands { get; }

        public HandlerConfigurable(HandlerScriptDefinition definition)
        {
            _definition = definition ?? throw new ArgumentNullException(nameof(definition));
            HandledCommands = new[]
            {
                string.IsNullOrWhiteSpace(_definition.PacketCommand) ? "event" : _definition.PacketCommand
            };
        }

        public async void Handle(JsonMessage message)
        {
            if (_definition.DelayMs > 0)
                await Task.Delay(_definition.DelayMs);

            try
            {
                if (!Player.IsLoggedIn)
                    return;

                switch (_definition.TriggerType)
                {
                    case HandlerTriggerType.ZoneEvent:
                        await HandleZoneEventAsync(message);
                        break;
                    case HandlerTriggerType.AnimationMessage:
                        await HandleAnimationMessage(message);
                        break;
                }
            }
            catch
            {
            }
        }

        private async Task HandleZoneEventAsync(JsonMessage message)
        {
            JObject args = message?.DataObject?["args"] as JObject;
            string zoneSet = args?["zoneSet"]?.ToString() ?? string.Empty;

            HandlerScriptRule rule = _definition.Rules?
                .FirstOrDefault(r => ZoneMatches(r, zoneSet) && ConditionsPass(r.Conditions));

            if (rule != null)
                await ExecuteActionsAsync(rule.Actions);
            else
                await ExecuteActionsAsync(_definition.DefaultActions);
        }

        private async Task HandleAnimationMessage(JsonMessage message)
        {
            var animsToken = message?.DataObject?["anims"];
            if (!(animsToken is JArray anims) || anims.Count == 0)
                return;

            string customMessage = anims[0]["msg"]?.ToString();
            if (string.IsNullOrEmpty(customMessage))
                return;

            string msgLower = customMessage.ToLowerInvariant();

            foreach (HandlerScriptRule rule in _definition.Rules ?? Enumerable.Empty<HandlerScriptRule>())
            {
                if (!MessageMatches(rule, msgLower))
                    continue;
                if (!ConditionsPass(rule.Conditions))
                    continue;

                await ExecuteActionsAsync(rule.Actions);
                return;
            }

            await ExecuteActionsAsync(_definition.DefaultActions);
        }

        private static bool ZoneMatches(HandlerScriptRule rule, string zoneSet)
        {
            if (string.IsNullOrWhiteSpace(rule?.ZoneSet))
                return false;

            if (rule.ZoneSet.Equals("default", StringComparison.OrdinalIgnoreCase) ||
                rule.ZoneSet.Equals("*", StringComparison.OrdinalIgnoreCase))
                return zoneSet != "A" && zoneSet != "B";

            return rule.ZoneSet.Equals(zoneSet, StringComparison.OrdinalIgnoreCase);
        }

        private static bool MessageMatches(HandlerScriptRule rule, string msgLower)
        {
            if (string.IsNullOrWhiteSpace(rule?.MessageContains))
                return true;

            return msgLower.Contains(rule.MessageContains.ToLowerInvariant());
        }

        private static bool ConditionsPass(IEnumerable<HandlerScriptCondition> conditions)
        {
            if (conditions == null)
                return true;

            foreach (HandlerScriptCondition condition in conditions)
            {
                if (condition == null || condition.Type == HandlerScriptConditionType.None)
                    continue;

                switch (condition.Type)
                {
                    case HandlerScriptConditionType.HasAura:
                        if (Player.GetAuras(condition.FriendlyAuras, condition.AuraName) <= 0)
                            return false;
                        break;
                    case HandlerScriptConditionType.NotHasAura:
                        if (Player.GetAuras(condition.FriendlyAuras, condition.AuraName) > 0)
                            return false;
                        break;
                    case HandlerScriptConditionType.MapEquals:
                        if (!Player.Map.EqualsIgnoreCase(condition.Value ?? string.Empty))
                            return false;
                        break;
                    case HandlerScriptConditionType.CellEquals:
                        if (!Player.Cell.EqualsIgnoreCase(condition.Value ?? string.Empty))
                            return false;
                        break;
                }
            }

            return true;
        }

        private async Task ExecuteActionsAsync(IEnumerable<HandlerScriptAction> actions)
        {
            if (actions == null)
                return;

            foreach (HandlerScriptAction action in actions)
            {
                if (action == null)
                    continue;

                switch (action.Type)
                {
                    case HandlerScriptActionType.Walk:
                        if (!string.IsNullOrWhiteSpace(action.X) && !string.IsNullOrWhiteSpace(action.Y))
                            Player.WalkToPoint(action.X, action.Y);
                        break;
                    case HandlerScriptActionType.UseSkill:
                        if (!string.IsNullOrWhiteSpace(action.SkillIndex))
                            Player.UseSkill(action.SkillIndex);
                        break;
                    case HandlerScriptActionType.ForceUseSkill:
                        if (!string.IsNullOrWhiteSpace(action.SkillIndex))
                            Player.ForceUseSkill(action.SkillIndex);
                        break;
                    case HandlerScriptActionType.Delay:
                        if (action.DelayMs > 0)
                            await Task.Delay(action.DelayMs);
                        break;
                }
            }
        }
    }
}
