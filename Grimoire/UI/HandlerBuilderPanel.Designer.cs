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
            this.components = new System.ComponentModel.Container();
            this.scrollBuilder = new System.Windows.Forms.Panel();
            this.grpSaved = new DarkUI.Controls.DarkGroupBox();
            this.lstSavedHandlers = new System.Windows.Forms.ListBox();
            this.grpRules = new DarkUI.Controls.DarkGroupBox();
            this.btnAddDefaultAction = new DarkUI.Controls.DarkButton();
            this.lstDefaultActions = new System.Windows.Forms.ListBox();
            this.lstRules = new System.Windows.Forms.ListBox();
            this.btnRemoveRule = new DarkUI.Controls.DarkButton();
            this.btnAddRule = new DarkUI.Controls.DarkButton();
            this.numActionDelay = new System.Windows.Forms.NumericUpDown();
            this.txtActionSkill = new DarkUI.Controls.DarkTextBox();
            this.txtActionY = new DarkUI.Controls.DarkTextBox();
            this.txtActionX = new DarkUI.Controls.DarkTextBox();
            this.cmbActionType = new System.Windows.Forms.ComboBox();
            this.grpAdvanced = new DarkUI.Controls.DarkGroupBox();
            this.lblAdvancedHelp = new DarkUI.Controls.DarkLabel();
            this.chkFriendlyAura = new DarkUI.Controls.DarkCheckBox();
            this.txtConditionValue = new DarkUI.Controls.DarkTextBox();
            this.txtConditionAura = new DarkUI.Controls.DarkTextBox();
            this.cmbConditionType = new System.Windows.Forms.ComboBox();
            this.txtRuleMessage = new DarkUI.Controls.DarkTextBox();
            this.txtRuleZone = new DarkUI.Controls.DarkTextBox();
            this.lblColAction = new DarkUI.Controls.DarkLabel();
            this.lblColCondition = new DarkUI.Controls.DarkLabel();
            this.lblColMessage = new DarkUI.Controls.DarkLabel();
            this.lblColZone = new DarkUI.Controls.DarkLabel();
            this.grpSkillWhen = new DarkUI.Controls.DarkGroupBox();
            this.btnQuickSkillRule = new DarkUI.Controls.DarkButton();
            this.txtQuickSkillNum = new DarkUI.Controls.DarkTextBox();
            this.txtQuickSkillMsg = new DarkUI.Controls.DarkTextBox();
            this.lblQuickSkillNum = new DarkUI.Controls.DarkLabel();
            this.lblQuickSkillMsg = new DarkUI.Controls.DarkLabel();
            this.lblSkillWhenHelp = new DarkUI.Controls.DarkLabel();
            this.grpQuickZone = new DarkUI.Controls.DarkGroupBox();
            this.btnQuickZoneApply = new DarkUI.Controls.DarkButton();
            this.txtZoneDefault_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneDefault_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneB_X = new DarkUI.Controls.DarkTextBox();
            this.txtZoneA_Y = new DarkUI.Controls.DarkTextBox();
            this.txtZoneA_X = new DarkUI.Controls.DarkTextBox();
            this.lblZoneDefault = new DarkUI.Controls.DarkLabel();
            this.lblZoneB = new DarkUI.Controls.DarkLabel();
            this.lblZoneA = new DarkUI.Controls.DarkLabel();
            this.lblQuickZoneHelp = new DarkUI.Controls.DarkLabel();
            this.grpHandlerSetup = new DarkUI.Controls.DarkGroupBox();
            this.btnLoadFile = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.btnNew = new DarkUI.Controls.DarkButton();
            this.lblDelay = new DarkUI.Controls.DarkLabel();
            this.numHandlerDelay = new System.Windows.Forms.NumericUpDown();
            this.cmbTriggerType = new System.Windows.Forms.ComboBox();
            this.lblTriggerCaption = new DarkUI.Controls.DarkLabel();
            this.cmbPacketCommand = new System.Windows.Forms.ComboBox();
            this.lblPacketCaption = new DarkUI.Controls.DarkLabel();
            this.txtDisplayName = new DarkUI.Controls.DarkTextBox();
            this.lblNameCaption = new DarkUI.Controls.DarkLabel();
            this.grpIntro = new DarkUI.Controls.DarkGroupBox();
            this.lblIntroHelp = new DarkUI.Controls.DarkLabel();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.scrollBuilder.SuspendLayout();
            this.grpSaved.SuspendLayout();
            this.grpRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).BeginInit();
            this.grpAdvanced.SuspendLayout();
            this.grpSkillWhen.SuspendLayout();
            this.grpQuickZone.SuspendLayout();
            this.grpHandlerSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).BeginInit();
            this.grpIntro.SuspendLayout();
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
            this.scrollBuilder.Controls.Add(this.grpSaved);
            this.scrollBuilder.Controls.Add(this.grpRules);
            this.scrollBuilder.Controls.Add(this.grpAdvanced);
            this.scrollBuilder.Controls.Add(this.grpSkillWhen);
            this.scrollBuilder.Controls.Add(this.grpQuickZone);
            this.scrollBuilder.Controls.Add(this.grpHandlerSetup);
            this.scrollBuilder.Controls.Add(this.grpIntro);
            this.scrollBuilder.Dock = System.Windows.Forms.DockStyle.Top;
            this.scrollBuilder.Location = new System.Drawing.Point(0, 0);
            this.scrollBuilder.Name = "scrollBuilder";
            this.scrollBuilder.Size = new System.Drawing.Size(520, 660);
            this.scrollBuilder.TabIndex = 0;
            // 
            // grpIntro
            // 
            this.grpIntro.Controls.Add(this.lblIntroHelp);
            this.grpIntro.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpIntro.Location = new System.Drawing.Point(4, 4);
            this.grpIntro.Name = "grpIntro";
            this.grpIntro.Size = new System.Drawing.Size(512, 58);
            this.grpIntro.TabIndex = 0;
            this.grpIntro.TabStop = false;
            this.grpIntro.Text = "What are handlers?";
            // 
            // lblIntroHelp
            // 
            this.lblIntroHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.lblIntroHelp.Location = new System.Drawing.Point(8, 18);
            this.lblIntroHelp.Name = "lblIntroHelp";
            this.lblIntroHelp.Size = new System.Drawing.Size(496, 36);
            this.lblIntroHelp.TabIndex = 0;
            this.lblIntroHelp.Text = "While your bot runs, handlers listen to game packets and react—walk to boss zones, press skills on Truth/Listen, etc. Pick a built-in handler above, or build your own here and Save.";
            // 
            // grpHandlerSetup
            // 
            this.grpHandlerSetup.Controls.Add(this.btnLoadFile);
            this.grpHandlerSetup.Controls.Add(this.btnSave);
            this.grpHandlerSetup.Controls.Add(this.btnNew);
            this.grpHandlerSetup.Controls.Add(this.lblDelay);
            this.grpHandlerSetup.Controls.Add(this.numHandlerDelay);
            this.grpHandlerSetup.Controls.Add(this.cmbTriggerType);
            this.grpHandlerSetup.Controls.Add(this.lblTriggerCaption);
            this.grpHandlerSetup.Controls.Add(this.cmbPacketCommand);
            this.grpHandlerSetup.Controls.Add(this.lblPacketCaption);
            this.grpHandlerSetup.Controls.Add(this.txtDisplayName);
            this.grpHandlerSetup.Controls.Add(this.lblNameCaption);
            this.grpHandlerSetup.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpHandlerSetup.Location = new System.Drawing.Point(4, 66);
            this.grpHandlerSetup.Name = "grpHandlerSetup";
            this.grpHandlerSetup.Size = new System.Drawing.Size(512, 108);
            this.grpHandlerSetup.TabIndex = 1;
            this.grpHandlerSetup.TabStop = false;
            this.grpHandlerSetup.Text = "Handler file (.ghandler)";
            // 
            // lblNameCaption
            // 
            this.lblNameCaption.AutoSize = true;
            this.lblNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblNameCaption.Location = new System.Drawing.Point(8, 22);
            this.lblNameCaption.Name = "lblNameCaption";
            this.lblNameCaption.Size = new System.Drawing.Size(38, 13);
            this.lblNameCaption.TabIndex = 0;
            this.lblNameCaption.Text = "Name:";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(52, 18);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(200, 20);
            this.txtDisplayName.TabIndex = 1;
            // 
            // lblPacketCaption
            // 
            this.lblPacketCaption.AutoSize = true;
            this.lblPacketCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblPacketCaption.Location = new System.Drawing.Point(8, 48);
            this.lblPacketCaption.Name = "lblPacketCaption";
            this.lblPacketCaption.Size = new System.Drawing.Size(41, 13);
            this.lblPacketCaption.TabIndex = 2;
            this.lblPacketCaption.Text = "Listen:";
            // 
            // cmbPacketCommand
            // 
            this.cmbPacketCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacketCommand.Location = new System.Drawing.Point(52, 44);
            this.cmbPacketCommand.Name = "cmbPacketCommand";
            this.cmbPacketCommand.Size = new System.Drawing.Size(220, 21);
            this.cmbPacketCommand.TabIndex = 3;
            // 
            // lblTriggerCaption
            // 
            this.lblTriggerCaption.AutoSize = true;
            this.lblTriggerCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblTriggerCaption.Location = new System.Drawing.Point(8, 76);
            this.lblTriggerCaption.Name = "lblTriggerCaption";
            this.lblTriggerCaption.Size = new System.Drawing.Size(43, 13);
            this.lblTriggerCaption.TabIndex = 4;
            this.lblTriggerCaption.Text = "When:";
            // 
            // cmbTriggerType
            // 
            this.cmbTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTriggerType.Location = new System.Drawing.Point(52, 72);
            this.cmbTriggerType.Name = "cmbTriggerType";
            this.cmbTriggerType.Size = new System.Drawing.Size(220, 21);
            this.cmbTriggerType.TabIndex = 5;
            // 
            // numHandlerDelay
            // 
            this.numHandlerDelay.Location = new System.Drawing.Point(328, 72);
            this.numHandlerDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numHandlerDelay.Name = "numHandlerDelay";
            this.numHandlerDelay.Size = new System.Drawing.Size(50, 20);
            this.numHandlerDelay.TabIndex = 6;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblDelay.Location = new System.Drawing.Point(278, 76);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(48, 13);
            this.lblDelay.TabIndex = 7;
            this.lblDelay.Text = "Delay ms";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(278, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 22);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Clear";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 22);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(430, 16);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(70, 22);
            this.btnLoadFile.TabIndex = 10;
            this.btnLoadFile.Text = "Open";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // grpQuickZone
            // 
            this.grpQuickZone.Controls.Add(this.lblQuickZoneHelp);
            this.grpQuickZone.Controls.Add(this.lblZoneA);
            this.grpQuickZone.Controls.Add(this.lblZoneB);
            this.grpQuickZone.Controls.Add(this.lblZoneDefault);
            this.grpQuickZone.Controls.Add(this.txtZoneA_X);
            this.grpQuickZone.Controls.Add(this.txtZoneA_Y);
            this.grpQuickZone.Controls.Add(this.txtZoneB_X);
            this.grpQuickZone.Controls.Add(this.txtZoneB_Y);
            this.grpQuickZone.Controls.Add(this.txtZoneDefault_X);
            this.grpQuickZone.Controls.Add(this.txtZoneDefault_Y);
            this.grpQuickZone.Controls.Add(this.btnQuickZoneApply);
            this.grpQuickZone.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpQuickZone.Location = new System.Drawing.Point(4, 178);
            this.grpQuickZone.Name = "grpQuickZone";
            this.grpQuickZone.Size = new System.Drawing.Size(250, 148);
            this.grpQuickZone.TabIndex = 2;
            this.grpQuickZone.TabStop = false;
            this.grpQuickZone.Text = "Boss zones (event)";
            // 
            // lblQuickZoneHelp
            // 
            this.lblQuickZoneHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblQuickZoneHelp.Location = new System.Drawing.Point(8, 18);
            this.lblQuickZoneHelp.Name = "lblQuickZoneHelp";
            this.lblQuickZoneHelp.Size = new System.Drawing.Size(234, 28);
            this.lblQuickZoneHelp.TabIndex = 0;
            this.lblQuickZoneHelp.Text = "Boss sends zoneSet A, B, or other. Enter map X,Y to walk there.";
            // 
            // lblZoneA
            // 
            this.lblZoneA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneA.Location = new System.Drawing.Point(8, 50);
            this.lblZoneA.Name = "lblZoneA";
            this.lblZoneA.Size = new System.Drawing.Size(16, 20);
            this.lblZoneA.TabIndex = 1;
            this.lblZoneA.Text = "A";
            this.lblZoneA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneA_X
            // 
            this.txtZoneA_X.Location = new System.Drawing.Point(26, 50);
            this.txtZoneA_X.Name = "txtZoneA_X";
            this.txtZoneA_X.Size = new System.Drawing.Size(48, 20);
            this.txtZoneA_X.TabIndex = 2;
            // 
            // txtZoneA_Y
            // 
            this.txtZoneA_Y.Location = new System.Drawing.Point(80, 50);
            this.txtZoneA_Y.Name = "txtZoneA_Y";
            this.txtZoneA_Y.Size = new System.Drawing.Size(48, 20);
            this.txtZoneA_Y.TabIndex = 3;
            // 
            // lblZoneB
            // 
            this.lblZoneB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneB.Location = new System.Drawing.Point(8, 74);
            this.lblZoneB.Name = "lblZoneB";
            this.lblZoneB.Size = new System.Drawing.Size(16, 20);
            this.lblZoneB.TabIndex = 4;
            this.lblZoneB.Text = "B";
            this.lblZoneB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneB_X
            // 
            this.txtZoneB_X.Location = new System.Drawing.Point(26, 74);
            this.txtZoneB_X.Name = "txtZoneB_X";
            this.txtZoneB_X.Size = new System.Drawing.Size(48, 20);
            this.txtZoneB_X.TabIndex = 5;
            // 
            // txtZoneB_Y
            // 
            this.txtZoneB_Y.Location = new System.Drawing.Point(80, 74);
            this.txtZoneB_Y.Name = "txtZoneB_Y";
            this.txtZoneB_Y.Size = new System.Drawing.Size(48, 20);
            this.txtZoneB_Y.TabIndex = 6;
            // 
            // lblZoneDefault
            // 
            this.lblZoneDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblZoneDefault.Location = new System.Drawing.Point(8, 98);
            this.lblZoneDefault.Name = "lblZoneDefault";
            this.lblZoneDefault.Size = new System.Drawing.Size(32, 20);
            this.lblZoneDefault.TabIndex = 7;
            this.lblZoneDefault.Text = "Safe";
            this.lblZoneDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtZoneDefault_X
            // 
            this.txtZoneDefault_X.Location = new System.Drawing.Point(42, 98);
            this.txtZoneDefault_X.Name = "txtZoneDefault_X";
            this.txtZoneDefault_X.Size = new System.Drawing.Size(48, 20);
            this.txtZoneDefault_X.TabIndex = 8;
            // 
            // txtZoneDefault_Y
            // 
            this.txtZoneDefault_Y.Location = new System.Drawing.Point(96, 98);
            this.txtZoneDefault_Y.Name = "txtZoneDefault_Y";
            this.txtZoneDefault_Y.Size = new System.Drawing.Size(48, 20);
            this.txtZoneDefault_Y.TabIndex = 9;
            // 
            // btnQuickZoneApply
            // 
            this.btnQuickZoneApply.Location = new System.Drawing.Point(134, 50);
            this.btnQuickZoneApply.Name = "btnQuickZoneApply";
            this.btnQuickZoneApply.Size = new System.Drawing.Size(108, 40);
            this.btnQuickZoneApply.TabIndex = 10;
            this.btnQuickZoneApply.Text = "Build zone\r\nwalk rules";
            this.btnQuickZoneApply.Click += new System.EventHandler(this.btnQuickZoneApply_Click);
            // 
            // grpSkillWhen
            // 
            this.grpSkillWhen.Controls.Add(this.lblSkillWhenHelp);
            this.grpSkillWhen.Controls.Add(this.lblQuickSkillMsg);
            this.grpSkillWhen.Controls.Add(this.txtQuickSkillMsg);
            this.grpSkillWhen.Controls.Add(this.lblQuickSkillNum);
            this.grpSkillWhen.Controls.Add(this.txtQuickSkillNum);
            this.grpSkillWhen.Controls.Add(this.btnQuickSkillRule);
            this.grpSkillWhen.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSkillWhen.Location = new System.Drawing.Point(262, 178);
            this.grpSkillWhen.Name = "grpSkillWhen";
            this.grpSkillWhen.Size = new System.Drawing.Size(254, 148);
            this.grpSkillWhen.TabIndex = 3;
            this.grpSkillWhen.TabStop = false;
            this.grpSkillWhen.Text = "Press skill (ct)";
            // 
            // lblSkillWhenHelp
            // 
            this.lblSkillWhenHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblSkillWhenHelp.Location = new System.Drawing.Point(8, 18);
            this.lblSkillWhenHelp.Name = "lblSkillWhenHelp";
            this.lblSkillWhenHelp.Size = new System.Drawing.Size(238, 28);
            this.lblSkillWhenHelp.TabIndex = 0;
            this.lblSkillWhenHelp.Text = "When boss chat contains your text, press a skill (e.g. Truth → skill 5).";
            // 
            // lblQuickSkillMsg
            // 
            this.lblQuickSkillMsg.AutoSize = true;
            this.lblQuickSkillMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblQuickSkillMsg.Location = new System.Drawing.Point(8, 52);
            this.lblQuickSkillMsg.Name = "lblQuickSkillMsg";
            this.lblQuickSkillMsg.Size = new System.Drawing.Size(106, 13);
            this.lblQuickSkillMsg.TabIndex = 1;
            this.lblQuickSkillMsg.Text = "Boss line contains:";
            // 
            // txtQuickSkillMsg
            // 
            this.txtQuickSkillMsg.Location = new System.Drawing.Point(8, 68);
            this.txtQuickSkillMsg.Name = "txtQuickSkillMsg";
            this.txtQuickSkillMsg.Size = new System.Drawing.Size(120, 20);
            this.txtQuickSkillMsg.TabIndex = 2;
            // 
            // lblQuickSkillNum
            // 
            this.lblQuickSkillNum.AutoSize = true;
            this.lblQuickSkillNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblQuickSkillNum.Location = new System.Drawing.Point(136, 52);
            this.lblQuickSkillNum.Name = "lblQuickSkillNum";
            this.lblQuickSkillNum.Size = new System.Drawing.Size(72, 13);
            this.lblQuickSkillNum.TabIndex = 3;
            this.lblQuickSkillNum.Text = "Press skill #:";
            // 
            // txtQuickSkillNum
            // 
            this.txtQuickSkillNum.Location = new System.Drawing.Point(136, 68);
            this.txtQuickSkillNum.Name = "txtQuickSkillNum";
            this.txtQuickSkillNum.Size = new System.Drawing.Size(40, 20);
            this.txtQuickSkillNum.TabIndex = 4;
            // 
            // btnQuickSkillRule
            // 
            this.btnQuickSkillRule.Location = new System.Drawing.Point(8, 98);
            this.btnQuickSkillRule.Name = "btnQuickSkillRule";
            this.btnQuickSkillRule.Size = new System.Drawing.Size(168, 40);
            this.btnQuickSkillRule.TabIndex = 5;
            this.btnQuickSkillRule.Text = "Add skill rule\r\n(sets ct packet)";
            this.btnQuickSkillRule.Click += new System.EventHandler(this.btnQuickSkillRule_Click);
            // 
            // grpAdvanced
            // 
            this.grpAdvanced.Controls.Add(this.lblAdvancedHelp);
            this.grpAdvanced.Controls.Add(this.lblColZone);
            this.grpAdvanced.Controls.Add(this.lblColMessage);
            this.grpAdvanced.Controls.Add(this.lblColCondition);
            this.grpAdvanced.Controls.Add(this.lblColAction);
            this.grpAdvanced.Controls.Add(this.txtRuleZone);
            this.grpAdvanced.Controls.Add(this.txtRuleMessage);
            this.grpAdvanced.Controls.Add(this.cmbConditionType);
            this.grpAdvanced.Controls.Add(this.txtConditionAura);
            this.grpAdvanced.Controls.Add(this.txtConditionValue);
            this.grpAdvanced.Controls.Add(this.chkFriendlyAura);
            this.grpAdvanced.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAdvanced.Location = new System.Drawing.Point(4, 330);
            this.grpAdvanced.Name = "grpAdvanced";
            this.grpAdvanced.Size = new System.Drawing.Size(512, 118);
            this.grpAdvanced.TabIndex = 4;
            this.grpAdvanced.TabStop = false;
            this.grpAdvanced.Text = "Advanced rule (optional)";
            // 
            // lblAdvancedHelp
            // 
            this.lblAdvancedHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.lblAdvancedHelp.Location = new System.Drawing.Point(8, 18);
            this.lblAdvancedHelp.Name = "lblAdvancedHelp";
            this.lblAdvancedHelp.Size = new System.Drawing.Size(496, 28);
            this.lblAdvancedHelp.TabIndex = 0;
            this.lblAdvancedHelp.Text = "Combine zone + boss text + aura (Queen Iona) or map/cell. Add matching action below in Rules.";
            // 
            // lblColZone
            // 
            this.lblColZone.AutoSize = true;
            this.lblColZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblColZone.Location = new System.Drawing.Point(8, 50);
            this.lblColZone.Name = "lblColZone";
            this.lblColZone.Size = new System.Drawing.Size(32, 13);
            this.lblColZone.TabIndex = 1;
            this.lblColZone.Text = "Zone";
            // 
            // lblColMessage
            // 
            this.lblColMessage.AutoSize = true;
            this.lblColMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblColMessage.Location = new System.Drawing.Point(78, 50);
            this.lblColMessage.Name = "lblColMessage";
            this.lblColMessage.Size = new System.Drawing.Size(53, 13);
            this.lblColMessage.TabIndex = 2;
            this.lblColMessage.Text = "Boss text";
            // 
            // lblColCondition
            // 
            this.lblColCondition.AutoSize = true;
            this.lblColCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblColCondition.Location = new System.Drawing.Point(168, 50);
            this.lblColCondition.Name = "lblColCondition";
            this.lblColCondition.Size = new System.Drawing.Size(51, 13);
            this.lblColCondition.TabIndex = 3;
            this.lblColCondition.Text = "Condition";
            // 
            // lblColAction
            // 
            this.lblColAction.AutoSize = true;
            this.lblColAction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(150)))));
            this.lblColAction.Location = new System.Drawing.Point(8, 92);
            this.lblColAction.Name = "lblColAction";
            this.lblColAction.Size = new System.Drawing.Size(0, 13);
            this.lblColAction.TabIndex = 4;
            // 
            // txtRuleZone
            // 
            this.txtRuleZone.Location = new System.Drawing.Point(8, 66);
            this.txtRuleZone.Name = "txtRuleZone";
            this.txtRuleZone.Size = new System.Drawing.Size(64, 20);
            this.txtRuleZone.TabIndex = 5;
            // 
            // txtRuleMessage
            // 
            this.txtRuleMessage.Location = new System.Drawing.Point(78, 66);
            this.txtRuleMessage.Name = "txtRuleMessage";
            this.txtRuleMessage.Size = new System.Drawing.Size(84, 20);
            this.txtRuleMessage.TabIndex = 6;
            // 
            // cmbConditionType
            // 
            this.cmbConditionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConditionType.Location = new System.Drawing.Point(168, 66);
            this.cmbConditionType.Name = "cmbConditionType";
            this.cmbConditionType.Size = new System.Drawing.Size(90, 21);
            this.cmbConditionType.TabIndex = 7;
            // 
            // txtConditionAura
            // 
            this.txtConditionAura.Location = new System.Drawing.Point(264, 66);
            this.txtConditionAura.Name = "txtConditionAura";
            this.txtConditionAura.Size = new System.Drawing.Size(110, 20);
            this.txtConditionAura.TabIndex = 8;
            // 
            // txtConditionValue
            // 
            this.txtConditionValue.Location = new System.Drawing.Point(380, 66);
            this.txtConditionValue.Name = "txtConditionValue";
            this.txtConditionValue.Size = new System.Drawing.Size(80, 20);
            this.txtConditionValue.TabIndex = 9;
            // 
            // chkFriendlyAura
            // 
            this.chkFriendlyAura.AutoSize = true;
            this.chkFriendlyAura.Location = new System.Drawing.Point(264, 92);
            this.chkFriendlyAura.Name = "chkFriendlyAura";
            this.chkFriendlyAura.Size = new System.Drawing.Size(90, 17);
            this.chkFriendlyAura.TabIndex = 10;
            this.chkFriendlyAura.Text = "Friendly aura";
            // 
            // grpRules
            // 
            this.grpRules.Controls.Add(this.cmbActionType);
            this.grpRules.Controls.Add(this.txtActionX);
            this.grpRules.Controls.Add(this.txtActionY);
            this.grpRules.Controls.Add(this.txtActionSkill);
            this.grpRules.Controls.Add(this.numActionDelay);
            this.grpRules.Controls.Add(this.btnAddRule);
            this.grpRules.Controls.Add(this.btnRemoveRule);
            this.grpRules.Controls.Add(this.lstRules);
            this.grpRules.Controls.Add(this.lstDefaultActions);
            this.grpRules.Controls.Add(this.btnAddDefaultAction);
            this.grpRules.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpRules.Location = new System.Drawing.Point(4, 452);
            this.grpRules.Name = "grpRules";
            this.grpRules.Size = new System.Drawing.Size(512, 148);
            this.grpRules.TabIndex = 5;
            this.grpRules.TabStop = false;
            this.grpRules.Text = "Rules & actions";
            // 
            // lstRules
            // 
            this.lstRules.FormattingEnabled = true;
            this.lstRules.Location = new System.Drawing.Point(8, 20);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(248, 82);
            this.lstRules.TabIndex = 0;
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // lstDefaultActions
            // 
            this.lstDefaultActions.FormattingEnabled = true;
            this.lstDefaultActions.Location = new System.Drawing.Point(262, 20);
            this.lstDefaultActions.Name = "lstDefaultActions";
            this.lstDefaultActions.Size = new System.Drawing.Size(150, 56);
            this.lstDefaultActions.TabIndex = 1;
            // 
            // btnAddDefaultAction
            // 
            this.btnAddDefaultAction.Location = new System.Drawing.Point(262, 80);
            this.btnAddDefaultAction.Name = "btnAddDefaultAction";
            this.btnAddDefaultAction.Size = new System.Drawing.Size(100, 22);
            this.btnAddDefaultAction.TabIndex = 2;
            this.btnAddDefaultAction.Text = "Add fallback";
            this.btnAddDefaultAction.Click += new System.EventHandler(this.btnAddDefaultAction_Click);
            // 
            // cmbActionType
            // 
            this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActionType.Location = new System.Drawing.Point(8, 108);
            this.cmbActionType.Name = "cmbActionType";
            this.cmbActionType.Size = new System.Drawing.Size(80, 21);
            this.cmbActionType.TabIndex = 3;
            // 
            // txtActionX
            // 
            this.txtActionX.Location = new System.Drawing.Point(94, 108);
            this.txtActionX.Name = "txtActionX";
            this.txtActionX.Size = new System.Drawing.Size(44, 20);
            this.txtActionX.TabIndex = 4;
            // 
            // txtActionY
            // 
            this.txtActionY.Location = new System.Drawing.Point(142, 108);
            this.txtActionY.Name = "txtActionY";
            this.txtActionY.Size = new System.Drawing.Size(44, 20);
            this.txtActionY.TabIndex = 5;
            // 
            // txtActionSkill
            // 
            this.txtActionSkill.Location = new System.Drawing.Point(192, 108);
            this.txtActionSkill.Name = "txtActionSkill";
            this.txtActionSkill.Size = new System.Drawing.Size(32, 20);
            this.txtActionSkill.TabIndex = 6;
            // 
            // numActionDelay
            // 
            this.numActionDelay.Location = new System.Drawing.Point(230, 108);
            this.numActionDelay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numActionDelay.Name = "numActionDelay";
            this.numActionDelay.Size = new System.Drawing.Size(44, 20);
            this.numActionDelay.TabIndex = 7;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(280, 108);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(70, 22);
            this.btnAddRule.TabIndex = 8;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Location = new System.Drawing.Point(356, 108);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(70, 22);
            this.btnRemoveRule.TabIndex = 9;
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // grpSaved
            // 
            this.grpSaved.Controls.Add(this.lstSavedHandlers);
            this.grpSaved.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSaved.Location = new System.Drawing.Point(4, 604);
            this.grpSaved.Name = "grpSaved";
            this.grpSaved.Size = new System.Drawing.Size(512, 52);
            this.grpSaved.TabIndex = 6;
            this.grpSaved.TabStop = false;
            this.grpSaved.Text = "Your saved handlers";
            // 
            // lstSavedHandlers
            // 
            this.lstSavedHandlers.FormattingEnabled = true;
            this.lstSavedHandlers.Location = new System.Drawing.Point(8, 18);
            this.lstSavedHandlers.Name = "lstSavedHandlers";
            this.lstSavedHandlers.Size = new System.Drawing.Size(496, 30);
            this.lstSavedHandlers.TabIndex = 0;
            this.lstSavedHandlers.DoubleClick += new System.EventHandler(this.lstSavedHandlers_DoubleClick);
            // 
            // toolTips
            // 
            this.toolTips.AutoPopDelay = 12000;
            this.toolTips.InitialDelay = 400;
            this.toolTips.ReshowDelay = 200;
            // 
            ((System.ComponentModel.ISupportInitialize)(this.numActionDelay)).EndInit();
            this.grpAdvanced.ResumeLayout(false);
            this.grpAdvanced.PerformLayout();
            this.grpSkillWhen.ResumeLayout(false);
            this.grpSkillWhen.PerformLayout();
            this.grpQuickZone.ResumeLayout(false);
            this.grpQuickZone.PerformLayout();
            this.grpHandlerSetup.ResumeLayout(false);
            this.grpHandlerSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHandlerDelay)).EndInit();
            this.grpIntro.ResumeLayout(false);
            this.grpRules.ResumeLayout(false);
            this.grpSaved.ResumeLayout(false);
            this.scrollBuilder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel scrollBuilder;
        private System.Windows.Forms.ToolTip toolTips;
        private DarkUI.Controls.DarkGroupBox grpIntro;
        private DarkUI.Controls.DarkLabel lblIntroHelp;
        private DarkUI.Controls.DarkGroupBox grpHandlerSetup;
        private DarkUI.Controls.DarkLabel lblNameCaption;
        private DarkUI.Controls.DarkTextBox txtDisplayName;
        private DarkUI.Controls.DarkLabel lblPacketCaption;
        private System.Windows.Forms.ComboBox cmbPacketCommand;
        private DarkUI.Controls.DarkLabel lblTriggerCaption;
        private System.Windows.Forms.ComboBox cmbTriggerType;
        private System.Windows.Forms.NumericUpDown numHandlerDelay;
        private DarkUI.Controls.DarkLabel lblDelay;
        private DarkUI.Controls.DarkButton btnNew;
        private DarkUI.Controls.DarkButton btnSave;
        private DarkUI.Controls.DarkButton btnLoadFile;
        private DarkUI.Controls.DarkGroupBox grpQuickZone;
        private DarkUI.Controls.DarkLabel lblQuickZoneHelp;
        private DarkUI.Controls.DarkLabel lblZoneA;
        private DarkUI.Controls.DarkLabel lblZoneB;
        private DarkUI.Controls.DarkLabel lblZoneDefault;
        private DarkUI.Controls.DarkTextBox txtZoneA_X;
        private DarkUI.Controls.DarkTextBox txtZoneA_Y;
        private DarkUI.Controls.DarkTextBox txtZoneB_X;
        private DarkUI.Controls.DarkTextBox txtZoneB_Y;
        private DarkUI.Controls.DarkTextBox txtZoneDefault_X;
        private DarkUI.Controls.DarkTextBox txtZoneDefault_Y;
        private DarkUI.Controls.DarkButton btnQuickZoneApply;
        private DarkUI.Controls.DarkGroupBox grpSkillWhen;
        private DarkUI.Controls.DarkLabel lblSkillWhenHelp;
        private DarkUI.Controls.DarkLabel lblQuickSkillMsg;
        private DarkUI.Controls.DarkTextBox txtQuickSkillMsg;
        private DarkUI.Controls.DarkLabel lblQuickSkillNum;
        private DarkUI.Controls.DarkTextBox txtQuickSkillNum;
        private DarkUI.Controls.DarkButton btnQuickSkillRule;
        private DarkUI.Controls.DarkGroupBox grpAdvanced;
        private DarkUI.Controls.DarkLabel lblAdvancedHelp;
        private DarkUI.Controls.DarkLabel lblColZone;
        private DarkUI.Controls.DarkLabel lblColMessage;
        private DarkUI.Controls.DarkLabel lblColCondition;
        private DarkUI.Controls.DarkLabel lblColAction;
        private DarkUI.Controls.DarkTextBox txtRuleZone;
        private DarkUI.Controls.DarkTextBox txtRuleMessage;
        private System.Windows.Forms.ComboBox cmbConditionType;
        private DarkUI.Controls.DarkTextBox txtConditionAura;
        private DarkUI.Controls.DarkTextBox txtConditionValue;
        private DarkUI.Controls.DarkCheckBox chkFriendlyAura;
        private DarkUI.Controls.DarkGroupBox grpRules;
        private System.Windows.Forms.ListBox lstRules;
        private System.Windows.Forms.ListBox lstDefaultActions;
        private DarkUI.Controls.DarkButton btnAddDefaultAction;
        private System.Windows.Forms.ComboBox cmbActionType;
        private DarkUI.Controls.DarkTextBox txtActionX;
        private DarkUI.Controls.DarkTextBox txtActionY;
        private DarkUI.Controls.DarkTextBox txtActionSkill;
        private System.Windows.Forms.NumericUpDown numActionDelay;
        private DarkUI.Controls.DarkButton btnAddRule;
        private DarkUI.Controls.DarkButton btnRemoveRule;
        private DarkUI.Controls.DarkGroupBox grpSaved;
        private System.Windows.Forms.ListBox lstSavedHandlers;
    }
}
