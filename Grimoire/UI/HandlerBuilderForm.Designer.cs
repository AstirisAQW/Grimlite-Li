namespace Grimoire.UI
{
    partial class HandlerBuilderForm
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
            this.txtDisplayName = new DarkUI.Controls.DarkTextBox();
            this.cmbPacketCommand = new System.Windows.Forms.ComboBox();
            this.cmbTriggerType = new System.Windows.Forms.ComboBox();
            this.numHandlerDelay = new System.Windows.Forms.NumericUpDown();
            this.lstRules = new System.Windows.Forms.ListBox();
            this.lstDefaultActions = new System.Windows.Forms.ListBox();
            this.lstSavedHandlers = new System.Windows.Forms.ListBox();
            this.txtZoneA_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneA_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneDefault_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneDefault_Y = new DarkUI.Controls.DarkTextBox();
            this.txtRuleZone = new DarkUI.Controls.DarkTextBox();
            this.txtRuleMessage = new DarkUI.Controls.DarkTextBox();
            this.cmbConditionType = new System.Windows.Forms.ComboBox();
            this.txtConditionAura = new DarkUI.Controls.DarkTextBox();
            this.txtConditionValue = new DarkUI.Controls.DarkTextBox();
            this.chkFriendlyAura = new DarkUI.Controls.DarkCheckBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.txtActionX = new DarkUI.Controls.DarkTextBox();
            this.txtActionY = new DarkUI.Controls.DarkTextBox();
            this.txtActionSkill = new DarkUI.Controls.DarkTextBox();
            this.numActionDelay = new System.Windows.Forms.NumericUpDown();
            this.btnNew = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnLoadFile = new DarkUI.Controls.DarkButton();
            this.btnQuickZoneApply = new DarkUI.Controls.DarkButton();
            this.btnAddRule = new DarkUI.Controls.DarkButton();
            this.btnRemoveRule = new DarkUI.Controls.DarkButton();
            this.btnAddDefaultAction = new DarkUI.Controls.DarkButton();
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // HandlerBuilderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btnAddDefaultAction);
            this.Controls.Add(this.btnRemoveRule);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.btnQuickZoneApply);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.numActionDelay);
            this.Controls.Add(this.txtActionSkill);
            this.Controls.Add(this.txtActionY);
            this.Controls.Add(this.txtActionX);
            this.Controls.Add(this.cmbActionType);
            this.Controls.Add(this.chkFriendlyAura);
            this.Controls.Add(this.txtConditionValue);
            this.Controls.Add(this.txtConditionAura);
            this.Controls.Add(this.cmbConditionType);
            this.Controls.Add(this.txtRuleMessage);
            this.Controls.Add(this.txtRuleZone);
            this.Controls.Add(this.txtZoneDefault_Y);
            this.Controls.Add(this.txtZoneDefault_X);
            this.Controls.Add(this.txtZoneB_Y);
            this.Controls.Add(this.txtZoneB_X);
            this.Controls.Add(this.txtZoneA_Y);
            this.Controls.Add(this.txtZoneA_X);
            this.Controls.Add(this.lstSavedHandlers);
            this.Controls.Add(this.lstDefaultActions);
            this.Controls.Add(this.lstRules);
            this.Controls.Add(this.numHandlerDelay);
            this.Controls.Add(this.cmbTriggerType);
            this.Controls.Add(this.cmbPacketCommand);
            this.Controls.Add(this.txtDisplayName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "HandlerBuilderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Handler Builder (.ghandler)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HandlerBuilderForm_FormClosing);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(12, 12);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(220, 20);
            this.txtDisplayName.TabIndex = 0;
            // 
            // cmbPacketCommand
            // 
            this.cmbPacketCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacketCommand.Location = new System.Drawing.Point(238, 12);
            this.cmbPacketCommand.Name = "cmbPacketCommand";
            this.cmbPacketCommand.Size = new System.Drawing.Size(70, 21);
            this.cmbPacketCommand.TabIndex = 1;
            // 
            // cmbTriggerType
            // 
            this.cmbTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriggerType.Location = new System.Drawing.Point(314, 12);
            this.cmbTriggerType.Name = "cmbTriggerType";
            this.cmbTriggerType.Size = new System.Drawing.Size(140, 21);
            this.cmbTriggerType.TabIndex = 2;
            // 
            // numHandlerDelay
            // 
            this.numHandlerDelay.Location = new System.Drawing.Point(460, 12);
            this.numHandlerDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHandlerDelay.Name = "numHandlerDelay";
            this.numHandlerDelay.Size = new System.Drawing.Size(60, 20);
            this.numHandlerDelay.TabIndex = 3;
            // 
            // lstRules
            // 
            this.lstRules.FormattingEnabled = true;
            this.lstRules.Location = new System.Drawing.Point(12, 200);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(360, 199);
            this.lstRules.TabIndex = 4;
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // lstDefaultActions
            // 
            this.lstDefaultActions.FormattingEnabled = true;
            this.lstDefaultActions.Location = new System.Drawing.Point(378, 200);
            this.lstDefaultActions.Name = "lstDefaultActions";
            this.lstDefaultActions.Size = new System.Drawing.Size(180, 95);
            this.lstDefaultActions.TabIndex = 5;
            // 
            // lstSavedHandlers
            // 
            this.lstSavedHandlers.FormattingEnabled = true;
            this.lstSavedHandlers.Location = new System.Drawing.Point(564, 40);
            this.lstSavedHandlers.Name = "lstSavedHandlers";
            this.lstSavedHandlers.Size = new System.Drawing.Size(208, 459);
            this.lstSavedHandlers.TabIndex = 6;
            this.lstSavedHandlers.DoubleClick += new System.EventHandler(this.lstSavedHandlers_DoubleClick);
            // 
            // Quick zone fields
            // 
            this.txtZoneA_X.Location = new System.Drawing.Point(40, 48);
            this.txtZoneA_Y.Location = new System.Drawing.Point(120, 48);
            this.txtZoneB_X.Location = new System.Drawing.Point(40, 74);
            this.txtZoneB_Y.Location = new System.Drawing.Point(120, 74);
            this.txtZoneDefault_X.Location = new System.Drawing.Point(40, 100);
            this.txtZoneDefault_Y.Location = new System.Drawing.Point(120, 100);
            this.txtZoneA_X.Size = this.txtZoneA_Y.Size = this.txtZoneB_X.Size = this.txtZoneB_Y.Size =
                this.txtZoneDefault_X.Size = this.txtZoneDefault_Y.Size = new System.Drawing.Size(70, 20);
            // 
            // Rule editor
            // 
            this.txtRuleZone.Location = new System.Drawing.Point(12, 140);
            this.txtRuleMessage.Location = new System.Drawing.Point(120, 140);
            this.txtRuleZone.Size = new System.Drawing.Size(100, 20);
            this.txtRuleMessage.Size = new System.Drawing.Size(120, 20);
            this.cmbConditionType.Location = new System.Drawing.Point(250, 140);
            this.cmbConditionType.Size = new System.Drawing.Size(100, 21);
            this.txtConditionAura.Location = new System.Drawing.Point(12, 166);
            this.txtConditionValue.Location = new System.Drawing.Point(200, 166);
            this.txtConditionAura.Size = new System.Drawing.Size(180, 20);
            this.txtConditionValue.Size = new System.Drawing.Size(120, 20);
            this.chkFriendlyAura.Location = new System.Drawing.Point(330, 166);
            this.chkFriendlyAura.Text = "Friendly aura";
            this.chkFriendlyAura.AutoSize = true;
            this.cmbActionType.Location = new System.Drawing.Point(12, 420);
            this.cmbActionType.Size = new System.Drawing.Size(110, 21);
            this.txtActionX.Location = new System.Drawing.Point(130, 420);
            this.txtActionY.Location = new System.Drawing.Point(210, 420);
            this.txtActionSkill.Location = new System.Drawing.Point(290, 420);
            this.txtActionX.Size = this.txtActionY.Size = new System.Drawing.Size(70, 20);
            this.txtActionSkill.Size = new System.Drawing.Size(50, 20);
            this.numActionDelay.Location = new System.Drawing.Point(350, 420);
            this.numActionDelay.Size = new System.Drawing.Size(60, 20);
            this.numActionDelay.Maximum = 10000;
            // 
            // Buttons
            // 
            this.btnNew.Location = new System.Drawing.Point(530, 12);
            this.btnNew.Size = new System.Drawing.Size(70, 23);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            this.btnSave.Location = new System.Drawing.Point(606, 12);
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnLoadFile.Location = new System.Drawing.Point(682, 12);
            this.btnLoadFile.Size = new System.Drawing.Size(70, 23);
            this.btnLoadFile.Text = "Open";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            this.btnQuickZoneApply.Location = new System.Drawing.Point(200, 74);
            this.btnQuickZoneApply.Size = new System.Drawing.Size(120, 23);
            this.btnQuickZoneApply.Text = "Apply A/B/Default";
            this.btnQuickZoneApply.Click += new System.EventHandler(this.btnQuickZoneApply_Click);
            this.btnAddRule.Location = new System.Drawing.Point(12, 446);
            this.btnAddRule.Size = new System.Drawing.Size(90, 23);
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            this.btnRemoveRule.Location = new System.Drawing.Point(108, 446);
            this.btnRemoveRule.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveRule.Text = "Remove rule";
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            this.btnAddDefaultAction.Location = new System.Drawing.Point(378, 300);
            this.btnAddDefaultAction.Size = new System.Drawing.Size(120, 23);
            this.btnAddDefaultAction.Text = "Add default action";
            this.btnAddDefaultAction.Click += new System.EventHandler(this.btnAddDefaultAction_Click);
            // 
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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
    }
}
