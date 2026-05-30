using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DarkUI.Forms;
using Grimoire.Networking.Handlers;
using Newtonsoft.Json;

namespace Grimoire.UI
{
    public partial class HandlerBuilderForm : DarkForm
    {
        private static HandlerBuilderForm _instance;

        public static void ShowSingleton()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new HandlerBuilderForm();
            _instance.Show();
            _instance.BringToFront();
        }

        public event EventHandler HandlersSaved;

        public string LastSavedDisplayName { get; private set; }

        public HandlerBuilderForm()
        {
            InitializeComponent();
            cmbPacketCommand.Items.AddRange(new object[] { "event", "ct" });
            cmbPacketCommand.SelectedIndex = 0;
            cmbTriggerType.Items.AddRange(Enum.GetNames(typeof(HandlerTriggerType)));
            cmbTriggerType.SelectedIndex = 0;
            cmbActionType.Items.AddRange(Enum.GetNames(typeof(HandlerScriptActionType)));
            cmbActionType.SelectedIndex = 0;
            cmbConditionType.Items.AddRange(Enum.GetNames(typeof(HandlerScriptConditionType)));
            cmbConditionType.SelectedIndex = 0;
            RefreshHandlerList();
        }

        private void RefreshHandlerList()
        {
            lstSavedHandlers.Items.Clear();
            CustomHandlerRegistry.ReloadFromDisk();
            foreach (string name in CustomHandlerRegistry.CustomDisplayNames)
                lstSavedHandlers.Items.Add(name);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDisplayName.Clear();
            cmbPacketCommand.SelectedIndex = 0;
            cmbTriggerType.SelectedIndex = 0;
            numHandlerDelay.Value = 0;
            lstRules.Items.Clear();
            lstDefaultActions.Items.Clear();
            txtZoneA_X.Clear();
            txtZoneA_Y.Clear();
            txtZoneB_X.Clear();
            txtZoneB_Y.Clear();
            txtZoneDefault_X.Clear();
            txtZoneDefault_Y.Clear();
        }

        private void btnQuickZoneApply_Click(object sender, EventArgs e)
        {
            cmbTriggerType.SelectedItem = nameof(HandlerTriggerType.ZoneEvent);
            cmbPacketCommand.SelectedItem = "event";
            lstRules.Items.Clear();

            AddZoneWalkRule("A", txtZoneA_X.Text, txtZoneA_Y.Text);
            AddZoneWalkRule("B", txtZoneB_X.Text, txtZoneB_Y.Text);

            lstDefaultActions.Items.Clear();
            if (!string.IsNullOrWhiteSpace(txtZoneDefault_X.Text) && !string.IsNullOrWhiteSpace(txtZoneDefault_Y.Text))
            {
                lstDefaultActions.Items.Add(new HandlerScriptAction
                {
                    Type = HandlerScriptActionType.Walk,
                    X = txtZoneDefault_X.Text.Trim(),
                    Y = txtZoneDefault_Y.Text.Trim()
                });
            }
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
                        X = x.Trim(),
                        Y = y.Trim()
                    }
                }
            });
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var rule = new HandlerScriptRule();
            if (!string.IsNullOrWhiteSpace(txtRuleZone.Text))
                rule.ZoneSet = txtRuleZone.Text.Trim();
            if (!string.IsNullOrWhiteSpace(txtRuleMessage.Text))
                rule.MessageContains = txtRuleMessage.Text.Trim();

            if (cmbConditionType.SelectedItem != null &&
                Enum.TryParse(cmbConditionType.SelectedItem.ToString(), out HandlerScriptConditionType condType) &&
                condType != HandlerScriptConditionType.None)
            {
                rule.Conditions.Add(new HandlerScriptCondition
                {
                    Type = condType,
                    AuraName = txtConditionAura.Text.Trim(),
                    Value = txtConditionValue.Text.Trim(),
                    FriendlyAuras = chkFriendlyAura.Checked
                });
            }

            if (Enum.TryParse(cmbActionType.SelectedItem?.ToString(), out HandlerScriptActionType actionType))
            {
                var action = new HandlerScriptAction { Type = actionType };
                if (actionType == HandlerScriptActionType.Walk)
                {
                    action.X = txtActionX.Text.Trim();
                    action.Y = txtActionY.Text.Trim();
                }
                else if (actionType == HandlerScriptActionType.UseSkill || actionType == HandlerScriptActionType.ForceUseSkill)
                    action.SkillIndex = txtActionSkill.Text.Trim();
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
                action.X = txtActionX.Text.Trim();
                action.Y = txtActionY.Text.Trim();
            }
            else if (actionType == HandlerScriptActionType.UseSkill || actionType == HandlerScriptActionType.ForceUseSkill)
                action.SkillIndex = txtActionSkill.Text.Trim();
            else if (actionType == HandlerScriptActionType.Delay)
                action.DelayMs = (int)numActionDelay.Value;

            return true;
        }

        private HandlerScriptDefinition BuildDefinition()
        {
            Enum.TryParse(cmbTriggerType.SelectedItem?.ToString(), out HandlerTriggerType trigger);

            var definition = new HandlerScriptDefinition
            {
                DisplayName = txtDisplayName.Text.Trim(),
                PacketCommand = cmbPacketCommand.SelectedItem?.ToString() ?? "event",
                TriggerType = trigger,
                DelayMs = (int)numHandlerDelay.Value,
                Rules = lstRules.Items.Cast<HandlerScriptRule>().ToList(),
                DefaultActions = lstDefaultActions.Items.Cast<HandlerScriptAction>().ToList()
            };

            return definition;
        }

        private void LoadDefinition(HandlerScriptDefinition definition)
        {
            if (definition == null)
                return;

            txtDisplayName.Text = definition.DisplayName;
            cmbPacketCommand.SelectedItem = definition.PacketCommand ?? "event";
            cmbTriggerType.SelectedItem = definition.TriggerType.ToString();
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

            if (walkA != null) { txtZoneA_X.Text = walkA.X; txtZoneA_Y.Text = walkA.Y; }
            if (walkB != null) { txtZoneB_X.Text = walkB.X; txtZoneB_Y.Text = walkB.Y; }
            if (walkDefault != null) { txtZoneDefault_X.Text = walkDefault.X; txtZoneDefault_Y.Text = walkDefault.Y; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDisplayName.Text))
            {
                MessageBox.Show("Enter a display name for this handler.");
                return;
            }

            try
            {
                HandlerScriptDefinition definition = BuildDefinition();
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

            txtRuleZone.Text = rule.ZoneSet ?? string.Empty;
            txtRuleMessage.Text = rule.MessageContains ?? string.Empty;
            HandlerScriptAction first = rule.Actions?.FirstOrDefault();
            if (first == null)
                return;

            cmbActionType.SelectedItem = first.Type.ToString();
            txtActionX.Text = first.X ?? string.Empty;
            txtActionY.Text = first.Y ?? string.Empty;
            txtActionSkill.Text = first.SkillIndex ?? string.Empty;
            numActionDelay.Value = Math.Max(0, Math.Min((int)numActionDelay.Maximum, first.DelayMs));
        }

        private void HandlerBuilderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
