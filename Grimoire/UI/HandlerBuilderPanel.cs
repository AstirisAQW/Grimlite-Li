using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Grimoire.Networking.Handlers;
using Newtonsoft.Json;

namespace Grimoire.UI
{
    public partial class HandlerBuilderPanel : UserControl
    {
        public event EventHandler HandlersSaved;

        public string LastSavedDisplayName { get; private set; }

        public HandlerBuilderPanel()
        {
            InitializeComponent();
            HandlerBuilderPlaceholders.ApplyAll(this);
            InitializeComboBoxes();
            SetupToolTips();
            RefreshHandlerList();
        }

        private void InitializeComboBoxes()
        {
            cmbPacketCommand.Items.Clear();
            cmbPacketCommand.Items.Add(new LabeledValue<string>("event", "event — boss zone (A / B / safe spot)"));
            cmbPacketCommand.Items.Add(new LabeledValue<string>("ct", "ct — boss combat line (Truth, Listen, …)"));
            cmbPacketCommand.SelectedIndex = 0;

            cmbTriggerType.Items.Clear();
            cmbTriggerType.Items.Add(new LabeledValue<HandlerTriggerType>(
                HandlerTriggerType.ZoneEvent, "Zone change → walk to map X,Y"));
            cmbTriggerType.Items.Add(new LabeledValue<HandlerTriggerType>(
                HandlerTriggerType.AnimationMessage, "Boss message → skill or walk"));
            cmbTriggerType.SelectedIndex = 0;

            cmbActionType.Items.Clear();
            cmbActionType.Items.AddRange(Enum.GetNames(typeof(HandlerScriptActionType)));
            cmbActionType.SelectedIndex = 0;

            cmbConditionType.Items.Clear();
            cmbConditionType.Items.AddRange(Enum.GetNames(typeof(HandlerScriptConditionType)));
            cmbConditionType.SelectedIndex = 0;
        }

        private void SetupToolTips()
        {
            toolTips.SetToolTip(cmbPacketCommand,
                "event = boss sends zoneSet (A, B, or other) — used for Ultradage-style mechanics.\r\n" +
                "ct = combat/animation packet with boss chat (Truth, Listen, etc.) — used for Speaker-style mechanics.");
            toolTips.SetToolTip(cmbTriggerType,
                "Zone change reads zoneSet from an event packet.\r\n" +
                "Boss message reads text from a ct packet (anims msg).");
            toolTips.SetToolTip(numHandlerDelay, "Wait this many ms after the packet before running actions.");
            toolTips.SetToolTip(txtRuleZone,
                "Only for event packets. Match zoneSet: A, B, or default (anything else). Leave empty if using boss message only.");
            toolTips.SetToolTip(txtRuleMessage,
                "Only for ct packets. Part of the boss line, e.g. truth or listen (not case sensitive).");
            toolTips.SetToolTip(txtConditionAura,
                "Optional. Exact aura name on your character, e.g. Positive Charge (Queen Iona).");
            toolTips.SetToolTip(txtConditionValue,
                "For MapEquals / CellEquals: map name or cell name (e.g. Boss).");
            toolTips.SetToolTip(txtActionSkill, "Skill bar slot 1–5 to press when this rule matches.");
            toolTips.SetToolTip(btnQuickSkillRule,
                "Adds a rule: when boss line contains your text → UseSkill. Sets packet to ct automatically.");
            toolTips.SetToolTip(btnQuickZoneApply,
                "Builds walk rules for zone A, B, and a default fallback. Sets packet to event.");
        }

        private string GetSelectedPacketCommand()
        {
            if (cmbPacketCommand.SelectedItem is LabeledValue<string> item)
                return item.Value;
            return cmbPacketCommand.SelectedItem?.ToString() ?? "event";
        }

        private void SelectPacketCommand(string command)
        {
            for (int i = 0; i < cmbPacketCommand.Items.Count; i++)
            {
                if (cmbPacketCommand.Items[i] is LabeledValue<string> lv &&
                    lv.Value.Equals(command, StringComparison.OrdinalIgnoreCase))
                {
                    cmbPacketCommand.SelectedIndex = i;
                    return;
                }
            }
        }

        private HandlerTriggerType GetSelectedTriggerType()
        {
            if (cmbTriggerType.SelectedItem is LabeledValue<HandlerTriggerType> item)
                return item.Value;
            Enum.TryParse(cmbTriggerType.SelectedItem?.ToString(), out HandlerTriggerType trigger);
            return trigger;
        }

        private void SelectTriggerType(HandlerTriggerType trigger)
        {
            for (int i = 0; i < cmbTriggerType.Items.Count; i++)
            {
                if (cmbTriggerType.Items[i] is LabeledValue<HandlerTriggerType> lv && lv.Value == trigger)
                {
                    cmbTriggerType.SelectedIndex = i;
                    return;
                }
            }
        }

        private void RefreshHandlerList()
        {
            lstSavedHandlers.Items.Clear();
            CustomHandlerRegistry.ReloadFromDisk();
            foreach (string name in CustomHandlerRegistry.CustomDisplayNames)
                lstSavedHandlers.Items.Add(name);
        }

        private void ResetAllFields()
        {
            foreach (string name in HandlerBuilderPlaceholders.Defaults.Keys)
            {
                Control[] found = Controls.Find(name, true);
                if (found.Length > 0 && found[0] is TextBox textBox)
                    HandlerBuilderPlaceholders.ClearField(textBox);
            }

            cmbPacketCommand.SelectedIndex = 0;
            cmbTriggerType.SelectedIndex = 0;
            numHandlerDelay.Value = 0;
            lstRules.Items.Clear();
            lstDefaultActions.Items.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e) => ResetAllFields();

        private void btnQuickZoneApply_Click(object sender, EventArgs e)
        {
            SelectTriggerType(HandlerTriggerType.ZoneEvent);
            SelectPacketCommand("event");
            lstRules.Items.Clear();

            AddZoneWalkRule("A", HandlerBuilderPlaceholders.GetEffectiveText(txtZoneA_X), HandlerBuilderPlaceholders.GetEffectiveText(txtZoneA_Y));
            AddZoneWalkRule("B", HandlerBuilderPlaceholders.GetEffectiveText(txtZoneB_X), HandlerBuilderPlaceholders.GetEffectiveText(txtZoneB_Y));

            lstDefaultActions.Items.Clear();
            string defX = HandlerBuilderPlaceholders.GetEffectiveText(txtZoneDefault_X);
            string defY = HandlerBuilderPlaceholders.GetEffectiveText(txtZoneDefault_Y);
            if (!string.IsNullOrWhiteSpace(defX) && !string.IsNullOrWhiteSpace(defY))
            {
                lstDefaultActions.Items.Add(new HandlerScriptAction
                {
                    Type = HandlerScriptActionType.Walk,
                    X = defX,
                    Y = defY
                });
            }
        }

        private void btnQuickSkillRule_Click(object sender, EventArgs e)
        {
            string message = HandlerBuilderPlaceholders.GetEffectiveText(txtQuickSkillMsg);
            string skill = HandlerBuilderPlaceholders.GetEffectiveText(txtQuickSkillNum);
            if (string.IsNullOrWhiteSpace(message) || string.IsNullOrWhiteSpace(skill))
            {
                MessageBox.Show("Enter boss line text (e.g. truth) and a skill number (1–5).");
                return;
            }

            SelectPacketCommand("ct");
            SelectTriggerType(HandlerTriggerType.AnimationMessage);

            var rule = new HandlerScriptRule
            {
                MessageContains = message,
                Actions = new List<HandlerScriptAction>
                {
                    new HandlerScriptAction
                    {
                        Type = HandlerScriptActionType.UseSkill,
                        SkillIndex = skill
                    }
                }
            };
            lstRules.Items.Add(rule);
        }

        private void AddZoneWalkRule(string zone, string x, string y)
        {
            if (string.IsNullOrWhiteSpace(x) || string.IsNullOrWhiteSpace(y))
                return;

            lstRules.Items.Add(new HandlerScriptRule
            {
                ZoneSet = zone,
                Actions = new List<HandlerScriptAction>
                {
                    new HandlerScriptAction
                    {
                        Type = HandlerScriptActionType.Walk,
                        X = x,
                        Y = y
                    }
                }
            });
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var rule = new HandlerScriptRule();
            string zone = HandlerBuilderPlaceholders.GetEffectiveText(txtRuleZone);
            string message = HandlerBuilderPlaceholders.GetEffectiveText(txtRuleMessage);
            if (!string.IsNullOrWhiteSpace(zone))
                rule.ZoneSet = zone;
            if (!string.IsNullOrWhiteSpace(message))
                rule.MessageContains = message;

            if (cmbConditionType.SelectedItem != null &&
                Enum.TryParse(cmbConditionType.SelectedItem.ToString(), out HandlerScriptConditionType condType) &&
                condType != HandlerScriptConditionType.None)
            {
                rule.Conditions.Add(new HandlerScriptCondition
                {
                    Type = condType,
                    AuraName = HandlerBuilderPlaceholders.GetEffectiveText(txtConditionAura),
                    Value = HandlerBuilderPlaceholders.GetEffectiveText(txtConditionValue),
                    FriendlyAuras = chkFriendlyAura.Checked
                });
            }

            if (Enum.TryParse(cmbActionType.SelectedItem?.ToString(), out HandlerScriptActionType actionType))
            {
                var action = new HandlerScriptAction { Type = actionType };
                if (actionType == HandlerScriptActionType.Walk)
                {
                    action.X = HandlerBuilderPlaceholders.GetEffectiveText(txtActionX);
                    action.Y = HandlerBuilderPlaceholders.GetEffectiveText(txtActionY);
                }
                else if (actionType == HandlerScriptActionType.UseSkill || actionType == HandlerScriptActionType.ForceUseSkill)
                    action.SkillIndex = HandlerBuilderPlaceholders.GetEffectiveText(txtActionSkill);
                else if (actionType == HandlerScriptActionType.Delay)
                    action.DelayMs = (int)numActionDelay.Value;

                rule.Actions.Add(action);
            }

            lstRules.Items.Add(rule);
        }

        private void btnRemoveRule_Click(object sender, EventArgs e)
        {
            if (lstRules.SelectedIndex >= 0)
                lstRules.Items.RemoveAt(lstRules.SelectedIndex);
        }

        private void btnAddDefaultAction_Click(object sender, EventArgs e)
        {
            if (!TryBuildActionFromFields(out HandlerScriptAction action))
                return;
            lstDefaultActions.Items.Add(action);
        }

        private bool TryBuildActionFromFields(out HandlerScriptAction action)
        {
            action = null;
            if (!Enum.TryParse(cmbActionType.SelectedItem?.ToString(), out HandlerScriptActionType actionType))
                return false;

            action = new HandlerScriptAction { Type = actionType };
            if (actionType == HandlerScriptActionType.Walk)
            {
                action.X = HandlerBuilderPlaceholders.GetEffectiveText(txtActionX);
                action.Y = HandlerBuilderPlaceholders.GetEffectiveText(txtActionY);
            }
            else if (actionType == HandlerScriptActionType.UseSkill || actionType == HandlerScriptActionType.ForceUseSkill)
                action.SkillIndex = HandlerBuilderPlaceholders.GetEffectiveText(txtActionSkill);
            else if (actionType == HandlerScriptActionType.Delay)
                action.DelayMs = (int)numActionDelay.Value;

            return true;
        }

        private HandlerScriptDefinition BuildDefinition()
        {
            return new HandlerScriptDefinition
            {
                DisplayName = HandlerBuilderPlaceholders.GetEffectiveText(txtDisplayName),
                PacketCommand = GetSelectedPacketCommand(),
                TriggerType = GetSelectedTriggerType(),
                DelayMs = (int)numHandlerDelay.Value,
                Rules = lstRules.Items.Cast<HandlerScriptRule>().ToList(),
                DefaultActions = lstDefaultActions.Items.Cast<HandlerScriptAction>().ToList()
            };
        }

        private void SetTextBoxValue(TextBox textBox, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                HandlerBuilderPlaceholders.ClearField(textBox);
                return;
            }

            textBox.Text = value;
            textBox.ForeColor = Color.Gainsboro;
        }

        private void LoadDefinition(HandlerScriptDefinition definition)
        {
            if (definition == null)
                return;

            SetTextBoxValue(txtDisplayName, definition.DisplayName);
            SelectPacketCommand(definition.PacketCommand ?? "event");
            SelectTriggerType(definition.TriggerType);
            numHandlerDelay.Value = Math.Max(0, Math.Min((int)numHandlerDelay.Maximum, definition.DelayMs));

            lstRules.Items.Clear();
            foreach (HandlerScriptRule rule in definition.Rules ?? Enumerable.Empty<HandlerScriptRule>())
                lstRules.Items.Add(rule);

            lstDefaultActions.Items.Clear();
            foreach (HandlerScriptAction action in definition.DefaultActions ?? Enumerable.Empty<HandlerScriptAction>())
                lstDefaultActions.Items.Add(action);

            TryFillQuickZoneFromDefinition(definition);
        }

        private void TryFillQuickZoneFromDefinition(HandlerScriptDefinition definition)
        {
            if (definition.TriggerType != HandlerTriggerType.ZoneEvent)
                return;

            HandlerScriptRule zoneA = definition.Rules?.FirstOrDefault(r => r.ZoneSet == "A");
            HandlerScriptRule zoneB = definition.Rules?.FirstOrDefault(r => r.ZoneSet == "B");
            HandlerScriptAction walkA = zoneA?.Actions?.FirstOrDefault(a => a.Type == HandlerScriptActionType.Walk);
            HandlerScriptAction walkB = zoneB?.Actions?.FirstOrDefault(a => a.Type == HandlerScriptActionType.Walk);
            HandlerScriptAction walkDefault = definition.DefaultActions?.FirstOrDefault(a => a.Type == HandlerScriptActionType.Walk);

            if (walkA != null) { SetTextBoxValue(txtZoneA_X, walkA.X); SetTextBoxValue(txtZoneA_Y, walkA.Y); }
            if (walkB != null) { SetTextBoxValue(txtZoneB_X, walkB.X); SetTextBoxValue(txtZoneB_Y, walkB.Y); }
            if (walkDefault != null) { SetTextBoxValue(txtZoneDefault_X, walkDefault.X); SetTextBoxValue(txtZoneDefault_Y, walkDefault.Y); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = HandlerBuilderPlaceholders.GetEffectiveText(txtDisplayName);
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter a display name for this handler.");
                return;
            }

            try
            {
                HandlerScriptDefinition definition = BuildDefinition();
                definition.DisplayName = name;
                CustomHandlerRegistry.Save(definition);
                LastSavedDisplayName = definition.DisplayName;
                RefreshHandlerList();
                HandlersSaved?.Invoke(this, EventArgs.Empty);
                MessageBox.Show("Saved to:\n" + CustomHandlerRegistry.GetPath(definition.DisplayName));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message);
            }
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Grimoire handlers|*.ghandler|JSON files|*.json|All files|*.*";
                dialog.InitialDirectory = CustomHandlerRegistry.HandlersDirectory;
                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    var definition = JsonConvert.DeserializeObject<HandlerScriptDefinition>(File.ReadAllText(dialog.FileName));
                    LoadDefinition(definition);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Load failed: " + ex.Message);
                }
            }
        }

        private void lstSavedHandlers_DoubleClick(object sender, EventArgs e)
        {
            if (lstSavedHandlers.SelectedItem == null)
                return;

            string name = lstSavedHandlers.SelectedItem.ToString();
            if (!CustomHandlerRegistry.TryGetDefinition(name, out HandlerScriptDefinition definition))
                return;

            LoadDefinition(definition);
        }

        private void lstRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(lstRules.SelectedItem is HandlerScriptRule rule))
                return;

            SetTextBoxValue(txtRuleZone, rule.ZoneSet ?? string.Empty);
            SetTextBoxValue(txtRuleMessage, rule.MessageContains ?? string.Empty);
            HandlerScriptAction first = rule.Actions?.FirstOrDefault();
            if (first == null)
                return;

            cmbActionType.SelectedItem = first.Type.ToString();
            SetTextBoxValue(txtActionX, first.X ?? string.Empty);
            SetTextBoxValue(txtActionY, first.Y ?? string.Empty);
            SetTextBoxValue(txtActionSkill, first.SkillIndex ?? string.Empty);
            numActionDelay.Value = Math.Max(0, Math.Min((int)numActionDelay.Maximum, first.DelayMs));
        }

        private sealed class LabeledValue<T>
        {
            public LabeledValue(T value, string label)
            {
                Value = value;
                Label = label;
            }

            public T Value { get; }
            public string Label { get; }

            public override string ToString() => Label;
        }

        private static class HandlerBuilderPlaceholders
        {
            private static readonly Color PlaceholderColor = Color.FromArgb(140, 140, 150);
            private static readonly Color NormalColor = Color.Gainsboro;

            public static readonly IReadOnlyDictionary<string, string> Defaults = new Dictionary<string, string>
            {
                { "txtDisplayName", "My Ultra Zone Handler" },
                { "txtZoneA_X", "X" },
                { "txtZoneA_Y", "Y" },
                { "txtZoneB_X", "X" },
                { "txtZoneB_Y", "Y" },
                { "txtZoneDefault_X", "X" },
                { "txtZoneDefault_Y", "Y" },
                { "txtRuleZone", "A, B, or default" },
                { "txtRuleMessage", "truth" },
                { "txtConditionAura", "Positive Charge" },
                { "txtConditionValue", "ultraspeaker" },
                { "txtActionX", "X" },
                { "txtActionY", "Y" },
                { "txtActionSkill", "5" },
                { "txtQuickSkillMsg", "truth" },
                { "txtQuickSkillNum", "5" }
            };

            public static void ApplyAll(Control root)
            {
                foreach (Control control in root.Controls)
                {
                    if (control is TextBox textBox && Defaults.TryGetValue(textBox.Name, out string placeholder))
                        Wire(textBox, placeholder);
                    else if (control.HasChildren)
                        ApplyAll(control);
                }
            }

            public static void Wire(TextBox textBox, string placeholder)
            {
                if (textBox == null || string.IsNullOrEmpty(placeholder))
                    return;

                SetPlaceholder(textBox, placeholder);

                textBox.Enter += (s, e) =>
                {
                    if (IsPlaceholder(textBox))
                        textBox.Clear();
                    textBox.ForeColor = NormalColor;
                };

                textBox.Leave += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        SetPlaceholder(textBox, placeholder);
                };
            }

            public static void SetPlaceholder(TextBox textBox, string placeholder)
            {
                textBox.Text = placeholder;
                textBox.ForeColor = PlaceholderColor;
            }

            public static bool IsPlaceholder(TextBox textBox)
            {
                return Defaults.TryGetValue(textBox.Name, out string placeholder) &&
                       textBox.Text == placeholder;
            }

            public static string GetEffectiveText(TextBox textBox)
            {
                if (textBox == null || IsPlaceholder(textBox))
                    return string.Empty;
                return textBox.Text.Trim();
            }

            public static void ClearField(TextBox textBox)
            {
                if (textBox == null)
                    return;

                if (Defaults.TryGetValue(textBox.Name, out string placeholder))
                    SetPlaceholder(textBox, placeholder);
                else
                    textBox.Clear();
            }
        }
    }
}
