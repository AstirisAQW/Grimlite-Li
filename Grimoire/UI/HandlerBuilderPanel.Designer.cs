namespace Grimoire.UI
{
    partial class HandlerBuilderPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.scrollBuilder = new System.Windows.Forms.Panel();
            this.txtDisplayName = new DarkUI.Controls.DarkTextBox();
            this.cmbPacketCommand = new System.Windows.Forms.ComboBox();
            this.cmbTriggerType = new System.Windows.Forms.ComboBox();
            this.numHandlerDelay = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnLoadFile = new DarkUI.Controls.DarkButton();
            this.lblQuickZone = new DarkUI.Controls.DarkLabel();
            this.lblZoneA = new DarkUI.Controls.DarkLabel();
            this.lblZoneB = new DarkUI.Controls.DarkLabel();
            this.lblZoneDefault = new DarkUI.Controls.DarkLabel();
            this.txtZoneA_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneA_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneDefault_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneDefault_Y = new DarkUI.Controls.DarkTextBox();
            this.btnQuickZoneApply = new DarkUI.Controls.DarkButton();
            this.lblRuleEditor = new DarkUI.Controls.DarkLabel();
            this.txtRuleZone = new DarkUI.Controls.DarkTextBox();
            this.txtRuleMessage = new DarkUI.Controls.DarkTextBox();
            this.cmbConditionType = new System.Windows.Forms.ComboBox();
            this.txtConditionAura = new DarkUI.Controls.DarkTextBox();
            this.txtConditionValue = new DarkUI.Controls.DarkTextBox();
            this.chkFriendlyAura = new DarkUI.Controls.DarkCheckBox();
            this.lblRules = new DarkUI.Controls.DarkLabel();
            this.lstRules = new System.Windows.Forms.ListBox();
            this.lblDefaultActions = new DarkUI.Controls.DarkLabel();
            this.lstDefaultActions = new System.Windows.Forms.ListBox();
            this.btnAddDefaultAction = new DarkUI.Controls.DarkButton();
            this.lblActionEditor = new DarkUI.Controls.DarkLabel();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.txtActionX = new DarkUI.Controls.DarkTextBox();
            this.txtActionY = new DarkUI.Controls.DarkTextBox();
            this.txtActionSkill = new DarkUI.Controls.DarkTextBox();
            this.numActionDelay = new System.Windows.Forms.NumericUpDown();
            this.btnAddRule = new DarkUI.Controls.DarkButton();
            this.btnRemoveRule = new DarkUI.Controls.DarkButton();
            this.lblSavedHandlers = new DarkUI.Controls.DarkLabel();
            this.lstSavedHandlers = new System.Windows.Forms.ListBox();
            this.lblBuilderTitle = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).BeginInit();
            this.scrollBuilder.SuspendLayout();
            this.SuspendLayout();
            // 
            // HandlerBuilderPanel
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.scrollBuilder);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name = "HandlerBuilderPanel";
            this.Size = new System.Drawing.Size(532, 220);
            // 
            // scrollBuilder
            // 
            this.scrollBuilder.AutoSize = true;
            this.scrollBuilder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scrollBuilder.Controls.Add(this.lblBuilderTitle);
            this.scrollBuilder.Controls.Add(this.lstSavedHandlers);
            this.scrollBuilder.Controls.Add(this.lblSavedHandlers);
            this.scrollBuilder.Controls.Add(this.btnRemoveRule);
            this.scrollBuilder.Controls.Add(this.btnAddRule);
            this.scrollBuilder.Controls.Add(this.numActionDelay);
            this.scrollBuilder.Controls.Add(this.txtActionSkill);
            this.scrollBuilder.Controls.Add(this.txtActionY);
            this.scrollBuilder.Controls.Add(this.txtActionX);
            this.scrollBuilder.Controls.Add(this.cmbActionType);
            this.scrollBuilder.Controls.Add(this.lblActionEditor);
            this.scrollBuilder.Controls.Add(this.btnAddDefaultAction);
            this.scrollBuilder.Controls.Add(this.lstDefaultActions);
            this.scrollBuilder.Controls.Add(this.lblDefaultActions);
            this.scrollBuilder.Controls.Add(this.lstRules);
            this.scrollBuilder.Controls.Add(this.lblRules);
            this.scrollBuilder.Controls.Add(this.chkFriendlyAura);
            this.scrollBuilder.Controls.Add(this.txtConditionValue);
            this.scrollBuilder.Controls.Add(this.txtConditionAura);
            this.scrollBuilder.Controls.Add(this.cmbConditionType);
            this.scrollBuilder.Controls.Add(this.txtRuleMessage);
            this.scrollBuilder.Controls.Add(this.txtRuleZone);
            this.scrollBuilder.Controls.Add(this.lblRuleEditor);
            this.scrollBuilder.Controls.Add(this.btnQuickZoneApply);
            this.scrollBuilder.Controls.Add(this.txtZoneDefault_Y);
            this.scrollBuilder.Controls.Add(this.txtZoneDefault_X);
            this.scrollBuilder.Controls.Add(this.lblZoneDefault);
            this.scrollBuilder.Controls.Add(this.txtZoneB_Y);
            this.scrollBuilder.Controls.Add(this.txtZoneB_X);
            this.scrollBuilder.Controls.Add(this.lblZoneB);
            this.scrollBuilder.Controls.Add(this.txtZoneA_Y);
            this.scrollBuilder.Controls.Add(this.txtZoneA_X);
            this.scrollBuilder.Controls.Add(this.lblZoneA);
            this.scrollBuilder.Controls.Add(this.lblQuickZone);
            this.scrollBuilder.Controls.Add(this.btnLoadFile);
            this.scrollBuilder.Controls.Add(this.btnSave);
            this.scrollBuilder.Controls.Add(this.btnNew);
            this.scrollBuilder.Controls.Add(this.numHandlerDelay);
            this.scrollBuilder.Controls.Add(this.cmbTriggerType);
            this.scrollBuilder.Controls.Add(this.cmbPacketCommand);
            this.scrollBuilder.Controls.Add(this.txtDisplayName);
            this.scrollBuilder.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrollBuilder.Location = new System.Drawing.Point(0, 0);
            this.scrollBuilder.Name = "scrollBuilder";
            this.scrollBuilder.Size = new System.Drawing.Size(520, 430);
            this.scrollBuilder.TabIndex = 0;
            // 
            // lblBuilderTitle
            // 
            this.lblBuilderTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBuilderTitle.Location = new System.Drawing.Point(4, 4);
            this.lblBuilderTitle.Name = "lblBuilderTitle";
            this.lblBuilderTitle.Size = new System.Drawing.Size(300, 16);
            this.lblBuilderTitle.TabIndex = 200;
            this.lblBuilderTitle.Text = "Custom handler builder (.ghandler)";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(4, 24);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(200, 20);
            this.txtDisplayName.TabIndex = 0;
            // 
            // cmbPacketCommand
            // 
            this.cmbPacketCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacketCommand.Location = new System.Drawing.Point(210, 24);
            this.cmbPacketCommand.Name = "cmbPacketCommand";
            this.cmbPacketCommand.Size = new System.Drawing.Size(55, 21);
            this.cmbPacketCommand.TabIndex = 1;
            // 
            // cmbTriggerType
            // 
            this.cmbTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriggerType.Location = new System.Drawing.Point(270, 24);
            this.cmbTriggerType.Name = "cmbTriggerType";
            this.cmbTriggerType.Size = new System.Drawing.Size(110, 21);
            this.cmbTriggerType.TabIndex = 2;
            // 
            // numHandlerDelay
            // 
            this.numHandlerDelay.Location = new System.Drawing.Point(386, 24);
            this.numHandlerDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHandlerDelay.Name = "numHandlerDelay";
            this.numHandlerDelay.Size = new System.Drawing.Size(50, 20);
            this.numHandlerDelay.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(442, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 23);
            this.btnNew.TabIndex = 50;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(442, 48);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(442, 74);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(44, 23);
            this.btnLoadFile.TabIndex = 52;
            this.btnLoadFile.Text = "Open";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // lblQuickZone
            // 
            this.lblQuickZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblQuickZone.Location = new System.Drawing.Point(4, 50);
            this.lblQuickZone.Name = "lblQuickZone";
            this.lblQuickZone.Size = new System.Drawing.Size(320, 16);
            this.lblQuickZone.TabIndex = 104;
            this.lblQuickZone.Text = "Quick zone: A / B / default (event → zoneSet)";
            // 
            // lblZoneA
            // 
            this.lblZoneA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneA.Location = new System.Drawing.Point(4, 68);
            this.lblZoneA.Name = "lblZoneA";
            this.lblZoneA.Size = new System.Drawing.Size(16, 20);
            this.lblZoneA.TabIndex = 105;
            this.lblZoneA.Text = "A";
            this.lblZoneA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneA_X
            // 
            this.txtZoneA_X.Location = new System.Drawing.Point(22, 68);
            this.txtZoneA_X.Name = "txtZoneA_X";
            this.txtZoneA_X.Size = new System.Drawing.Size(55, 20);
            this.txtZoneA_X.TabIndex = 10;
            // 
            // txtZoneA_Y
            // 
            this.txtZoneA_Y.Location = new System.Drawing.Point(82, 68);
            this.txtZoneA_Y.Name = "txtZoneA_Y";
            this.txtZoneA_Y.Size = new System.Drawing.Size(55, 20);
            this.txtZoneA_Y.TabIndex = 11;
            // 
            // lblZoneB
            // 
            this.lblZoneB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneB.Location = new System.Drawing.Point(4, 92);
            this.lblZoneB.Name = "lblZoneB";
            this.lblZoneB.Size = new System.Drawing.Size(16, 20);
            this.lblZoneB.TabIndex = 106;
            this.lblZoneB.Text = "B";
            this.lblZoneB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneB_X
            // 
            this.txtZoneB_X.Location = new System.Drawing.Point(22, 92);
            this.txtZoneB_X.Name = "txtZoneB_X";
            this.txtZoneB_X.Size = new System.Drawing.Size(55, 20);
            this.txtZoneB_X.TabIndex = 12;
            // 
            // txtZoneB_Y
            // 
            this.txtZoneB_Y.Location = new System.Drawing.Point(82, 92);
            this.txtZoneB_Y.Name = "txtZoneB_Y";
            this.txtZoneB_Y.Size = new System.Drawing.Size(55, 20);
            this.txtZoneB_Y.TabIndex = 13;
            // 
            // lblZoneDefault
            // 
            this.lblZoneDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneDefault.Location = new System.Drawing.Point(4, 116);
            this.lblZoneDefault.Name = "lblZoneDefault";
            this.lblZoneDefault.Size = new System.Drawing.Size(48, 20);
            this.lblZoneDefault.TabIndex = 107;
            this.lblZoneDefault.Text = "Def.";
            this.lblZoneDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneDefault_X
            // 
            this.txtZoneDefault_X.Location = new System.Drawing.Point(42, 116);
            this.txtZoneDefault_X.Name = "txtZoneDefault_X";
            this.txtZoneDefault_X.Size = new System.Drawing.Size(55, 20);
            this.txtZoneDefault_X.TabIndex = 14;
            // 
            // txtZoneDefault_Y
            // 
            this.txtZoneDefault_Y.Location = new System.Drawing.Point(102, 116);
            this.txtZoneDefault_Y.Name = "txtZoneDefault_Y";
            this.txtZoneDefault_Y.Size = new System.Drawing.Size(55, 20);
            this.txtZoneDefault_Y.TabIndex = 15;
            // 
            // btnQuickZoneApply
            // 
            this.btnQuickZoneApply.Location = new System.Drawing.Point(168, 92);
            this.btnQuickZoneApply.Name = "btnQuickZoneApply";
            this.btnQuickZoneApply.Size = new System.Drawing.Size(110, 23);
            this.btnQuickZoneApply.TabIndex = 16;
            this.btnQuickZoneApply.Text = "Apply A/B/Default";
            this.btnQuickZoneApply.Click += new System.EventHandler(this.btnQuickZoneApply_Click);
            // 
            // lblRuleEditor
            // 
            this.lblRuleEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblRuleEditor.Location = new System.Drawing.Point(4, 142);
            this.lblRuleEditor.Name = "lblRuleEditor";
            this.lblRuleEditor.Size = new System.Drawing.Size(400, 16);
            this.lblRuleEditor.TabIndex = 108;
            this.lblRuleEditor.Text = "Advanced rule";
            // 
            // txtRuleZone
            // 
            this.txtRuleZone.Location = new System.Drawing.Point(4, 160);
            this.txtRuleZone.Name = "txtRuleZone";
            this.txtRuleZone.Size = new System.Drawing.Size(70, 20);
            this.txtRuleZone.TabIndex = 20;
            // 
            // txtRuleMessage
            // 
            this.txtRuleMessage.Location = new System.Drawing.Point(80, 160);
            this.txtRuleMessage.Name = "txtRuleMessage";
            this.txtRuleMessage.Size = new System.Drawing.Size(90, 20);
            this.txtRuleMessage.TabIndex = 21;
            // 
            // cmbConditionType
            // 
            this.cmbConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionType.Location = new System.Drawing.Point(176, 160);
            this.cmbConditionType.Name = "cmbConditionType";
            this.cmbConditionType.Size = new System.Drawing.Size(90, 21);
            this.cmbConditionType.TabIndex = 22;
            // 
            // txtConditionAura
            // 
            this.txtConditionAura.Location = new System.Drawing.Point(4, 184);
            this.txtConditionAura.Name = "txtConditionAura";
            this.txtConditionAura.Size = new System.Drawing.Size(120, 20);
            this.txtConditionAura.TabIndex = 23;
            // 
            // txtConditionValue
            // 
            this.txtConditionValue.Location = new System.Drawing.Point(130, 184);
            this.txtConditionValue.Name = "txtConditionValue";
            this.txtConditionValue.Size = new System.Drawing.Size(90, 20);
            this.txtConditionValue.TabIndex = 24;
            // 
            // chkFriendlyAura
            // 
            this.chkFriendlyAura.AutoSize = true;
            this.chkFriendlyAura.Location = new System.Drawing.Point(226, 186);
            this.chkFriendlyAura.Name = "chkFriendlyAura";
            this.chkFriendlyAura.Size = new System.Drawing.Size(90, 17);
            this.chkFriendlyAura.TabIndex = 25;
            this.chkFriendlyAura.Text = "Friendly aura";
            // 
            // lblRules
            // 
            this.lblRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblRules.Location = new System.Drawing.Point(4, 208);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(120, 16);
            this.lblRules.TabIndex = 109;
            this.lblRules.Text = "Rules";
            // 
            // lstRules
            // 
            this.lstRules.FormattingEnabled = true;
            this.lstRules.Location = new System.Drawing.Point(4, 224);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(250, 82);
            this.lstRules.TabIndex = 4;
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // lblDefaultActions
            // 
            this.lblDefaultActions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblDefaultActions.Location = new System.Drawing.Point(260, 208);
            this.lblDefaultActions.Name = "lblDefaultActions";
            this.lblDefaultActions.Size = new System.Drawing.Size(120, 16);
            this.lblDefaultActions.TabIndex = 110;
            this.lblDefaultActions.Text = "Default actions";
            // 
            // lstDefaultActions
            // 
            this.lstDefaultActions.FormattingEnabled = true;
            this.lstDefaultActions.Location = new System.Drawing.Point(260, 224);
            this.lstDefaultActions.Name = "lstDefaultActions";
            this.lstDefaultActions.Size = new System.Drawing.Size(170, 56);
            this.lstDefaultActions.TabIndex = 5;
            // 
            // btnAddDefaultAction
            // 
            this.btnAddDefaultAction.Location = new System.Drawing.Point(260, 284);
            this.btnAddDefaultAction.Name = "btnAddDefaultAction";
            this.btnAddDefaultAction.Size = new System.Drawing.Size(110, 22);
            this.btnAddDefaultAction.TabIndex = 30;
            this.btnAddDefaultAction.Text = "Add default";
            this.btnAddDefaultAction.Click += new System.EventHandler(this.btnAddDefaultAction_Click);
            // 
            // lblActionEditor
            // 
            this.lblActionEditor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblActionEditor.Location = new System.Drawing.Point(4, 312);
            this.lblActionEditor.Name = "lblActionEditor";
            this.lblActionEditor.Size = new System.Drawing.Size(280, 13);
            this.lblActionEditor.TabIndex = 111;
            this.lblActionEditor.Text = "Action for new rule";
            // 
            // cmbActionType
            // 
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.Location = new System.Drawing.Point(4, 328);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(90, 21);
            this.cmbActionType.TabIndex = 40;
            // 
            // txtActionX
            // 
            this.txtActionX.Location = new System.Drawing.Point(100, 328);
            this.txtActionX.Name = "txtActionX";
            this.txtActionX.Size = new System.Drawing.Size(55, 20);
            this.txtActionX.TabIndex = 41;
            // 
            // txtActionY
            // 
            this.txtActionY.Location = new System.Drawing.Point(160, 328);
            this.txtActionY.Name = "txtActionY";
            this.txtActionY.Size = new System.Drawing.Size(55, 20);
            this.txtActionY.TabIndex = 42;
            // 
            // txtActionSkill
            // 
            this.txtActionSkill.Location = new System.Drawing.Point(220, 328);
            this.txtActionSkill.Name = "txtActionSkill";
            this.txtActionSkill.Size = new System.Drawing.Size(40, 20);
            this.txtActionSkill.TabIndex = 43;
            // 
            // numActionDelay
            // 
            this.numActionDelay.Location = new System.Drawing.Point(266, 328);
            this.numActionDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numActionDelay.Name = "numActionDelay";
            this.numActionDelay.Size = new System.Drawing.Size(50, 20);
            this.numActionDelay.TabIndex = 44;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(4, 354);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(80, 22);
            this.btnAddRule.TabIndex = 45;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(90, 354);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(80, 22);
            this.btnRemoveRule.TabIndex = 46;
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // lblSavedHandlers
            // 
            this.lblSavedHandlers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblSavedHandlers.Location = new System.Drawing.Point(4, 382);
            this.lblSavedHandlers.Name = "lblSavedHandlers";
            this.lblSavedHandlers.Size = new System.Drawing.Size(200, 16);
            this.lblSavedHandlers.TabIndex = 112;
            this.lblSavedHandlers.Text = "Saved (double-click to load)";
            // 
            // lstSavedHandlers
            // 
            this.lstSavedHandlers.FormattingEnabled = true;
            this.lstSavedHandlers.Location = new System.Drawing.Point(4, 400);
            this.lstSavedHandlers.Name = "lstSavedHandlers";
            this.lstSavedHandlers.Size = new System.Drawing.Size(426, 25);
            this.lstSavedHandlers.TabIndex = 6;
            this.lstSavedHandlers.DoubleClick += new System.EventHandler(this.lstSavedHandlers_DoubleClick);
            // 
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).EndInit();
            this.scrollBuilder.ResumeLayout(false);
            this.scrollBuilder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel scrollBuilder;
        private DarkUI.Controls.DarkLabel lblBuilderTitle;
        private DarkUI.Controls.DarkTextBox txtDisplayName;
        private System.Windows.Forms.ComboBox cmbPacketCommand;
        private System.Windows.Forms.ComboBox cmbTriggerType;
        private System.Windows.Forms.NumericUpDown numHandlerDelay;
        private System.Windows.Forms.ListBox lstRules;
        private System.Windows.Forms.ListBox lstDefaultActions;
        private System.Windows.Forms.ListBox lstSavedHandlers;
        private DarkUI.Controls.DarkTextBox txtZoneA_X;
        private DarkUI.Controls.DarkTextBox txtZoneA_Y;
        private DarkUI.Controls.DarkTextBox txtZoneB_X;
        private DarkUI.Controls.DarkTextBox txtZoneB_Y;
        private DarkUI.Controls.DarkTextBox txtZoneDefault_X;
        private DarkUI.Controls.DarkTextBox txtZoneDefault_Y;
        private DarkUI.Controls.DarkTextBox txtRuleZone;
        private DarkUI.Controls.DarkTextBox txtRuleMessage;
        private System.Windows.Forms.ComboBox cmbConditionType;
        private DarkUI.Controls.DarkTextBox txtConditionAura;
        private DarkUI.Controls.DarkTextBox txtConditionValue;
        private DarkUI.Controls.DarkCheckBox chkFriendlyAura;
        private System.Windows.Forms.ComboBox cmbActionType;
        private DarkUI.Controls.DarkTextBox txtActionX;
        private DarkUI.Controls.DarkTextBox txtActionY;
        private DarkUI.Controls.DarkTextBox txtActionSkill;
        private System.Windows.Forms.NumericUpDown numActionDelay;
        private DarkUI.Controls.DarkButton btnNew;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkButton btnLoadFile;
        private DarkUI.Controls.DarkButton btnQuickZoneApply;
        private DarkUI.Controls.DarkButton btnAddRule;
        private DarkUI.Controls.DarkButton btnRemoveRule;
        private DarkUI.Controls.DarkButton btnAddDefaultAction;
        private DarkUI.Controls.DarkLabel lblQuickZone;
        private DarkUI.Controls.DarkLabel lblZoneA;
        private DarkUI.Controls.DarkLabel lblZoneB;
        private DarkUI.Controls.DarkLabel lblZoneDefault;
        private DarkUI.Controls.DarkLabel lblRules;
        private DarkUI.Controls.DarkLabel lblDefaultActions;
        private DarkUI.Controls.DarkLabel lblSavedHandlers;
        private DarkUI.Controls.DarkLabel lblRuleEditor;
        private DarkUI.Controls.DarkLabel lblActionEditor;
    }
}
