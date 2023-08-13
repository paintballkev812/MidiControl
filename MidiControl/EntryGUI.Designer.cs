﻿namespace MidiControl
{
    partial class EntryGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.LblNote = new System.Windows.Forms.Label();
            this.TxtBoxNote = new System.Windows.Forms.TextBox();
            this.TxtBoxDevice = new System.Windows.Forms.TextBox();
            this.LblDevice = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxChannel = new System.Windows.Forms.TextBox();
            this.LblChannel = new System.Windows.Forms.Label();
            this.GrpBoxKeyPress = new System.Windows.Forms.GroupBox();
            this.TabKeyPress = new System.Windows.Forms.TabControl();
            this.TabOBSPress = new System.Windows.Forms.TabPage();
            this.ChkCboBoxHotkeyPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxHotkeyPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMediaStopPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMediaStopPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMediaRestartPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMediaRestartPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMediaPlayPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMediaPlayPress = new System.Windows.Forms.CheckBox();
            this.CboBoxPreviewScenePress = new System.Windows.Forms.ComboBox();
            this.ChkBoxPreviewScenePress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMiscPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMiscPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxToggleFilterPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxToggleFilterPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxShowFilterPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxShowFilterPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxHideFilterPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxHideFilterPress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxToggleSourcePress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxToggleSourcePress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxToggleMutePress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxTogglemutePress = new System.Windows.Forms.CheckBox();
            this.ChkBoxTransitionPress = new System.Windows.Forms.CheckBox();
            this.NumericTransitionPress = new System.Windows.Forms.NumericUpDown();
            this.CboBoxTransitionPress = new System.Windows.Forms.ComboBox();
            this.ChkCboBoxHidePress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxHideSourcePress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxShowPress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxShowSourcePress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxUnmutePress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxUnmutePress = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMutePress = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMutePress = new System.Windows.Forms.CheckBox();
            this.CboBoxSwitchScenePress = new System.Windows.Forms.ComboBox();
            this.ChkBoxSwitchScenePress = new System.Windows.Forms.CheckBox();
            this.TabSoundPress = new System.Windows.Forms.TabPage();
            this.LblVolume = new System.Windows.Forms.Label();
            this.volumeSlider = new NAudio.Gui.VolumeSlider();
            this.chkBoxLoop = new System.Windows.Forms.CheckBox();
            this.LblAudioFile = new System.Windows.Forms.Label();
            this.LblAudioDevice = new System.Windows.Forms.Label();
            this.ChkBoxEnableAudio = new System.Windows.Forms.CheckBox();
            this.CboBoxAudioDevice = new System.Windows.Forms.ComboBox();
            this.BtnAudioSelect = new System.Windows.Forms.Button();
            this.TxtBoxAudioFile = new System.Windows.Forms.TextBox();
            this.TabMediaKeyPress = new System.Windows.Forms.TabPage();
            this.ChkBoxMediaKeyPreviousPress = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaKeyNextPress = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaKeyPlayPress = new System.Windows.Forms.CheckBox();
            this.TabTwitchPress = new System.Windows.Forms.TabPage();
            this.LblTwitchMessagePress = new System.Windows.Forms.Label();
            this.TxtBoxTwitchMessagePress = new System.Windows.Forms.TextBox();
            this.TxtBoxTwitchChannelPress = new System.Windows.Forms.TextBox();
            this.LblChannelTwitchPress = new System.Windows.Forms.Label();
            this.TabMIDIControlPress = new System.Windows.Forms.TabPage();
            this.CboBoxProfilePress = new System.Windows.Forms.ComboBox();
            this.ChkBoxSwitchToProfilePress = new System.Windows.Forms.CheckBox();
            this.ChkBoxStopAllSoundPress = new System.Windows.Forms.CheckBox();
            this.TabGoXLRControlPress = new System.Windows.Forms.TabPage();
            this.LblXLROutputPress = new System.Windows.Forms.Label();
            this.LblXLRInputPress = new System.Windows.Forms.Label();
            this.PanelXLRPress = new System.Windows.Forms.Panel();
            this.RadioButtonUnMuteXLRPress = new System.Windows.Forms.RadioButton();
            this.RadioButtonMuteXLRPress = new System.Windows.Forms.RadioButton();
            this.RadioButtonToggleXLRPress = new System.Windows.Forms.RadioButton();
            this.RadioButtonDisabledXLRPress = new System.Windows.Forms.RadioButton();
            this.CboBoxXLROutputPress = new System.Windows.Forms.ComboBox();
            this.CboBoxXLRInputPress = new System.Windows.Forms.ComboBox();
            this.tabLaunchProgramKeyPress = new System.Windows.Forms.TabPage();
            this.ChkBoxHideProgramPress = new System.Windows.Forms.CheckBox();
            this.lblArgsPress = new System.Windows.Forms.Label();
            this.TxtBoxArgsPress = new System.Windows.Forms.TextBox();
            this.lblFilePress = new System.Windows.Forms.Label();
            this.BtnProgramSelectPress = new System.Windows.Forms.Button();
            this.TxtBoxProgramPress = new System.Windows.Forms.TextBox();
            this.GrpBoxKeyRelease = new System.Windows.Forms.GroupBox();
            this.TabKeyRelease = new System.Windows.Forms.TabControl();
            this.TabOBSRelease = new System.Windows.Forms.TabPage();
            this.ChkCboBoxHotkeyRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxHotkeyRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMediaStopRelease = new CheckComboBoxTest.CheckedComboBox();
            this.CboBoxPreviewSceneRelease = new System.Windows.Forms.ComboBox();
            this.ChkBoxMediaStopRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMediaRestartRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxPreviewSceneRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaRestartRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMiscRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkCboBoxMediaPlayRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMiscRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaPlayRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxToggleFilterRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkCboBoxToggleSourceRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxToggleFilterRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxToggleSourceRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxShowFilterRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkCboBoxToggleMuteRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxShowFilterRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxHideFilterRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxTogglemuteRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxHideFilterRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxTransitionRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxHideRelease = new CheckComboBoxTest.CheckedComboBox();
            this.NumericTransitionRelease = new System.Windows.Forms.NumericUpDown();
            this.ChkBoxSwitchSceneRelease = new System.Windows.Forms.CheckBox();
            this.CboBoxTransitionRelease = new System.Windows.Forms.ComboBox();
            this.ChkBoxHideSourceRelease = new System.Windows.Forms.CheckBox();
            this.CboBoxSwitchSceneRelease = new System.Windows.Forms.ComboBox();
            this.ChkCboBoxShowRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxMuteRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxShowSourceRelease = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxMuteRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkCboBoxUnmuteRelease = new CheckComboBoxTest.CheckedComboBox();
            this.ChkBoxUnmuteRelease = new System.Windows.Forms.CheckBox();
            this.TabSoundRelease = new System.Windows.Forms.TabPage();
            this.ChkBoxAudioStop = new System.Windows.Forms.CheckBox();
            this.TabMediaKeyRelease = new System.Windows.Forms.TabPage();
            this.ChkBoxMediaKeyPreviousRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaKeyNextRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxMediaKeyPlayRelease = new System.Windows.Forms.CheckBox();
            this.TabTwitchRelease = new System.Windows.Forms.TabPage();
            this.LblTwitchMessageRelease = new System.Windows.Forms.Label();
            this.TxtBoxTwitchMessageRelease = new System.Windows.Forms.TextBox();
            this.TxtBoxTwitchChannelRelease = new System.Windows.Forms.TextBox();
            this.LblChannelTwitchRelease = new System.Windows.Forms.Label();
            this.TabMIDIControlRelease = new System.Windows.Forms.TabPage();
            this.CboBoxProfileRelease = new System.Windows.Forms.ComboBox();
            this.ChkBoxSwitchToProfileRelease = new System.Windows.Forms.CheckBox();
            this.ChkBoxStopAllSoundRelease = new System.Windows.Forms.CheckBox();
            this.TabGoXLRControlRelease = new System.Windows.Forms.TabPage();
            this.LblXLROutputRelease = new System.Windows.Forms.Label();
            this.LblXLRInputRelease = new System.Windows.Forms.Label();
            this.PanelXLRRelease = new System.Windows.Forms.Panel();
            this.RadioButtonUnMuteXLRRelease = new System.Windows.Forms.RadioButton();
            this.RadioButtonMuteXLRRelease = new System.Windows.Forms.RadioButton();
            this.RadioButtonToggleXLRRelease = new System.Windows.Forms.RadioButton();
            this.RadioButtonDisabledXLRRelease = new System.Windows.Forms.RadioButton();
            this.CboBoxXLROutputRelease = new System.Windows.Forms.ComboBox();
            this.CboBoxXLRInputRelease = new System.Windows.Forms.ComboBox();
            this.tabLaunchProgramKeyRelease = new System.Windows.Forms.TabPage();
            this.ChkBoxHideProgramRelease = new System.Windows.Forms.CheckBox();
            this.lblArgsRelease = new System.Windows.Forms.Label();
            this.TxtBoxArgsRelease = new System.Windows.Forms.TextBox();
            this.lblFileRelease = new System.Windows.Forms.Label();
            this.BtnProgramSelectRelease = new System.Windows.Forms.Button();
            this.TxtBoxProgramRelease = new System.Windows.Forms.TextBox();
            this.GrpBoxKeySlider = new System.Windows.Forms.GroupBox();
            this.TabKeySlider = new System.Windows.Forms.TabControl();
            this.TabOBSSlider = new System.Windows.Forms.TabPage();
            this.CboBoxFilterSettingSlider = new System.Windows.Forms.ComboBox();
            this.CboBoxFilterNameSlider = new System.Windows.Forms.ComboBox();
            this.ChkBoxAdjustFilter = new System.Windows.Forms.CheckBox();
            this.ChkBoxSlideTransition = new System.Windows.Forms.CheckBox();
            this.ChkBoxAdjustTransitionDuration = new System.Windows.Forms.CheckBox();
            this.ChkBoxAdjustVolume = new System.Windows.Forms.CheckBox();
            this.ChkCboBoxVolumeSlider = new CheckComboBoxTest.CheckedComboBox();
            this.GrpBoxKeyPress.SuspendLayout();
            this.TabKeyPress.SuspendLayout();
            this.TabOBSPress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTransitionPress)).BeginInit();
            this.TabSoundPress.SuspendLayout();
            this.TabMediaKeyPress.SuspendLayout();
            this.TabTwitchPress.SuspendLayout();
            this.TabMIDIControlPress.SuspendLayout();
            this.TabGoXLRControlPress.SuspendLayout();
            this.PanelXLRPress.SuspendLayout();
            this.tabLaunchProgramKeyPress.SuspendLayout();
            this.GrpBoxKeyRelease.SuspendLayout();
            this.TabKeyRelease.SuspendLayout();
            this.TabOBSRelease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTransitionRelease)).BeginInit();
            this.TabSoundRelease.SuspendLayout();
            this.TabMediaKeyRelease.SuspendLayout();
            this.TabTwitchRelease.SuspendLayout();
            this.TabMIDIControlRelease.SuspendLayout();
            this.TabGoXLRControlRelease.SuspendLayout();
            this.PanelXLRRelease.SuspendLayout();
            this.tabLaunchProgramKeyRelease.SuspendLayout();
            this.GrpBoxKeySlider.SuspendLayout();
            this.TabKeySlider.SuspendLayout();
            this.TabOBSSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 0;
            this.LblName.Text = "Name";
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(54, 10);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(176, 20);
            this.TxtBoxName.TabIndex = 1;
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Location = new System.Drawing.Point(523, 13);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(30, 13);
            this.LblNote.TabIndex = 2;
            this.LblNote.Text = "Note";
            // 
            // TxtBoxNote
            // 
            this.TxtBoxNote.Enabled = false;
            this.TxtBoxNote.Location = new System.Drawing.Point(559, 10);
            this.TxtBoxNote.Name = "TxtBoxNote";
            this.TxtBoxNote.Size = new System.Drawing.Size(29, 20);
            this.TxtBoxNote.TabIndex = 3;
            // 
            // TxtBoxDevice
            // 
            this.TxtBoxDevice.Enabled = false;
            this.TxtBoxDevice.Location = new System.Drawing.Point(309, 10);
            this.TxtBoxDevice.Name = "TxtBoxDevice";
            this.TxtBoxDevice.Size = new System.Drawing.Size(116, 20);
            this.TxtBoxDevice.TabIndex = 7;
            // 
            // LblDevice
            // 
            this.LblDevice.AutoSize = true;
            this.LblDevice.Location = new System.Drawing.Point(236, 13);
            this.LblDevice.Name = "LblDevice";
            this.LblDevice.Size = new System.Drawing.Size(67, 13);
            this.LblDevice.TabIndex = 6;
            this.LblDevice.Text = "MIDI Device";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(513, 696);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtBoxChannel
            // 
            this.TxtBoxChannel.Enabled = false;
            this.TxtBoxChannel.Location = new System.Drawing.Point(488, 10);
            this.TxtBoxChannel.Name = "TxtBoxChannel";
            this.TxtBoxChannel.Size = new System.Drawing.Size(29, 20);
            this.TxtBoxChannel.TabIndex = 10;
            // 
            // LblChannel
            // 
            this.LblChannel.AutoSize = true;
            this.LblChannel.Location = new System.Drawing.Point(436, 13);
            this.LblChannel.Name = "LblChannel";
            this.LblChannel.Size = new System.Drawing.Size(46, 13);
            this.LblChannel.TabIndex = 9;
            this.LblChannel.Text = "Channel";
            // 
            // GrpBoxKeyPress
            // 
            this.GrpBoxKeyPress.Controls.Add(this.TabKeyPress);
            this.GrpBoxKeyPress.Location = new System.Drawing.Point(9, 36);
            this.GrpBoxKeyPress.Name = "GrpBoxKeyPress";
            this.GrpBoxKeyPress.Size = new System.Drawing.Size(579, 271);
            this.GrpBoxKeyPress.TabIndex = 11;
            this.GrpBoxKeyPress.TabStop = false;
            this.GrpBoxKeyPress.Text = "On Key Press";
            // 
            // TabKeyPress
            // 
            this.TabKeyPress.Controls.Add(this.TabOBSPress);
            this.TabKeyPress.Controls.Add(this.TabSoundPress);
            this.TabKeyPress.Controls.Add(this.TabMediaKeyPress);
            this.TabKeyPress.Controls.Add(this.TabTwitchPress);
            this.TabKeyPress.Controls.Add(this.TabMIDIControlPress);
            this.TabKeyPress.Controls.Add(this.TabGoXLRControlPress);
            this.TabKeyPress.Controls.Add(this.tabLaunchProgramKeyPress);
            this.TabKeyPress.Location = new System.Drawing.Point(6, 20);
            this.TabKeyPress.Name = "TabKeyPress";
            this.TabKeyPress.SelectedIndex = 0;
            this.TabKeyPress.Size = new System.Drawing.Size(568, 245);
            this.TabKeyPress.TabIndex = 0;
            // 
            // TabOBSPress
            // 
            this.TabOBSPress.Controls.Add(this.ChkCboBoxHotkeyPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxHotkeyPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxMediaStopPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxMediaStopPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxMediaRestartPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxMediaRestartPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxMediaPlayPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxMediaPlayPress);
            this.TabOBSPress.Controls.Add(this.CboBoxPreviewScenePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxPreviewScenePress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxMiscPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxMiscPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxToggleFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxToggleFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxShowFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxShowFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxHideFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxHideFilterPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxToggleSourcePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxToggleSourcePress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxToggleMutePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxTogglemutePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxTransitionPress);
            this.TabOBSPress.Controls.Add(this.NumericTransitionPress);
            this.TabOBSPress.Controls.Add(this.CboBoxTransitionPress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxHidePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxHideSourcePress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxShowPress);
            this.TabOBSPress.Controls.Add(this.ChkBoxShowSourcePress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxUnmutePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxUnmutePress);
            this.TabOBSPress.Controls.Add(this.ChkCboBoxMutePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxMutePress);
            this.TabOBSPress.Controls.Add(this.CboBoxSwitchScenePress);
            this.TabOBSPress.Controls.Add(this.ChkBoxSwitchScenePress);
            this.TabOBSPress.Location = new System.Drawing.Point(4, 22);
            this.TabOBSPress.Name = "TabOBSPress";
            this.TabOBSPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabOBSPress.Size = new System.Drawing.Size(560, 219);
            this.TabOBSPress.TabIndex = 0;
            this.TabOBSPress.Text = "OBS";
            this.TabOBSPress.UseVisualStyleBackColor = true;
            // 
            // ChkCboBoxHotkeyPress
            // 
            this.ChkCboBoxHotkeyPress.CheckOnClick = true;
            this.ChkCboBoxHotkeyPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHotkeyPress.DropDownHeight = 1;
            this.ChkCboBoxHotkeyPress.Enabled = false;
            this.ChkCboBoxHotkeyPress.FormattingEnabled = true;
            this.ChkCboBoxHotkeyPress.IntegralHeight = false;
            this.ChkCboBoxHotkeyPress.Location = new System.Drawing.Point(363, 192);
            this.ChkCboBoxHotkeyPress.Name = "ChkCboBoxHotkeyPress";
            this.ChkCboBoxHotkeyPress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxHotkeyPress.TabIndex = 35;
            this.ChkCboBoxHotkeyPress.ValueSeparator = ", ";
            // 
            // ChkBoxHotkeyPress
            // 
            this.ChkBoxHotkeyPress.AutoSize = true;
            this.ChkBoxHotkeyPress.Location = new System.Drawing.Point(276, 194);
            this.ChkBoxHotkeyPress.Name = "ChkBoxHotkeyPress";
            this.ChkBoxHotkeyPress.Size = new System.Drawing.Size(60, 17);
            this.ChkBoxHotkeyPress.TabIndex = 34;
            this.ChkBoxHotkeyPress.Text = "Hotkey";
            this.ChkBoxHotkeyPress.UseVisualStyleBackColor = true;
            this.ChkBoxHotkeyPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMediaStopPress
            // 
            this.ChkCboBoxMediaStopPress.CheckOnClick = true;
            this.ChkCboBoxMediaStopPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaStopPress.DropDownHeight = 1;
            this.ChkCboBoxMediaStopPress.Enabled = false;
            this.ChkCboBoxMediaStopPress.FormattingEnabled = true;
            this.ChkCboBoxMediaStopPress.IntegralHeight = false;
            this.ChkCboBoxMediaStopPress.Location = new System.Drawing.Point(363, 123);
            this.ChkCboBoxMediaStopPress.Name = "ChkCboBoxMediaStopPress";
            this.ChkCboBoxMediaStopPress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaStopPress.TabIndex = 33;
            this.ChkCboBoxMediaStopPress.ValueSeparator = ", ";
            // 
            // ChkBoxMediaStopPress
            // 
            this.ChkBoxMediaStopPress.AutoSize = true;
            this.ChkBoxMediaStopPress.Location = new System.Drawing.Point(276, 125);
            this.ChkBoxMediaStopPress.Name = "ChkBoxMediaStopPress";
            this.ChkBoxMediaStopPress.Size = new System.Drawing.Size(80, 17);
            this.ChkBoxMediaStopPress.TabIndex = 32;
            this.ChkBoxMediaStopPress.Text = "Media Stop";
            this.ChkBoxMediaStopPress.UseVisualStyleBackColor = true;
            this.ChkBoxMediaStopPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMediaRestartPress
            // 
            this.ChkCboBoxMediaRestartPress.CheckOnClick = true;
            this.ChkCboBoxMediaRestartPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaRestartPress.DropDownHeight = 1;
            this.ChkCboBoxMediaRestartPress.Enabled = false;
            this.ChkCboBoxMediaRestartPress.FormattingEnabled = true;
            this.ChkCboBoxMediaRestartPress.IntegralHeight = false;
            this.ChkCboBoxMediaRestartPress.Location = new System.Drawing.Point(363, 146);
            this.ChkCboBoxMediaRestartPress.Name = "ChkCboBoxMediaRestartPress";
            this.ChkCboBoxMediaRestartPress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaRestartPress.TabIndex = 31;
            this.ChkCboBoxMediaRestartPress.ValueSeparator = ", ";
            // 
            // ChkBoxMediaRestartPress
            // 
            this.ChkBoxMediaRestartPress.AutoSize = true;
            this.ChkBoxMediaRestartPress.Location = new System.Drawing.Point(276, 148);
            this.ChkBoxMediaRestartPress.Name = "ChkBoxMediaRestartPress";
            this.ChkBoxMediaRestartPress.Size = new System.Drawing.Size(92, 17);
            this.ChkBoxMediaRestartPress.TabIndex = 30;
            this.ChkBoxMediaRestartPress.Text = "Media Restart";
            this.ChkBoxMediaRestartPress.UseVisualStyleBackColor = true;
            this.ChkBoxMediaRestartPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMediaPlayPress
            // 
            this.ChkCboBoxMediaPlayPress.CheckOnClick = true;
            this.ChkCboBoxMediaPlayPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaPlayPress.DropDownHeight = 1;
            this.ChkCboBoxMediaPlayPress.Enabled = false;
            this.ChkCboBoxMediaPlayPress.FormattingEnabled = true;
            this.ChkCboBoxMediaPlayPress.IntegralHeight = false;
            this.ChkCboBoxMediaPlayPress.Location = new System.Drawing.Point(363, 98);
            this.ChkCboBoxMediaPlayPress.Name = "ChkCboBoxMediaPlayPress";
            this.ChkCboBoxMediaPlayPress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaPlayPress.TabIndex = 29;
            this.ChkCboBoxMediaPlayPress.ValueSeparator = ", ";
            // 
            // ChkBoxMediaPlayPress
            // 
            this.ChkBoxMediaPlayPress.AutoSize = true;
            this.ChkBoxMediaPlayPress.Location = new System.Drawing.Point(276, 100);
            this.ChkBoxMediaPlayPress.Name = "ChkBoxMediaPlayPress";
            this.ChkBoxMediaPlayPress.Size = new System.Drawing.Size(78, 17);
            this.ChkBoxMediaPlayPress.TabIndex = 28;
            this.ChkBoxMediaPlayPress.Text = "Media Play";
            this.ChkBoxMediaPlayPress.UseVisualStyleBackColor = true;
            this.ChkBoxMediaPlayPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // CboBoxPreviewScenePress
            // 
            this.CboBoxPreviewScenePress.Enabled = false;
            this.CboBoxPreviewScenePress.FormattingEnabled = true;
            this.CboBoxPreviewScenePress.Location = new System.Drawing.Point(98, 27);
            this.CboBoxPreviewScenePress.Name = "CboBoxPreviewScenePress";
            this.CboBoxPreviewScenePress.Size = new System.Drawing.Size(172, 21);
            this.CboBoxPreviewScenePress.TabIndex = 27;
            // 
            // ChkBoxPreviewScenePress
            // 
            this.ChkBoxPreviewScenePress.AutoSize = true;
            this.ChkBoxPreviewScenePress.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxPreviewScenePress.Name = "ChkBoxPreviewScenePress";
            this.ChkBoxPreviewScenePress.Size = new System.Drawing.Size(98, 17);
            this.ChkBoxPreviewScenePress.TabIndex = 26;
            this.ChkBoxPreviewScenePress.Text = "Preview Scene";
            this.ChkBoxPreviewScenePress.UseVisualStyleBackColor = true;
            this.ChkBoxPreviewScenePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMiscPress
            // 
            this.ChkCboBoxMiscPress.CheckOnClick = true;
            this.ChkCboBoxMiscPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMiscPress.DropDownHeight = 1;
            this.ChkCboBoxMiscPress.Enabled = false;
            this.ChkCboBoxMiscPress.FormattingEnabled = true;
            this.ChkCboBoxMiscPress.IntegralHeight = false;
            this.ChkCboBoxMiscPress.Location = new System.Drawing.Point(363, 169);
            this.ChkCboBoxMiscPress.Name = "ChkCboBoxMiscPress";
            this.ChkCboBoxMiscPress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMiscPress.TabIndex = 25;
            this.ChkCboBoxMiscPress.ValueSeparator = ", ";
            // 
            // ChkBoxMiscPress
            // 
            this.ChkBoxMiscPress.AutoSize = true;
            this.ChkBoxMiscPress.Location = new System.Drawing.Point(276, 171);
            this.ChkBoxMiscPress.Name = "ChkBoxMiscPress";
            this.ChkBoxMiscPress.Size = new System.Drawing.Size(48, 17);
            this.ChkBoxMiscPress.TabIndex = 24;
            this.ChkBoxMiscPress.Text = "Misc";
            this.ChkBoxMiscPress.UseVisualStyleBackColor = true;
            this.ChkBoxMiscPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxToggleFilterPress
            // 
            this.ChkCboBoxToggleFilterPress.CheckOnClick = true;
            this.ChkCboBoxToggleFilterPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleFilterPress.DropDownHeight = 1;
            this.ChkCboBoxToggleFilterPress.Enabled = false;
            this.ChkCboBoxToggleFilterPress.FormattingEnabled = true;
            this.ChkCboBoxToggleFilterPress.IntegralHeight = false;
            this.ChkCboBoxToggleFilterPress.Location = new System.Drawing.Point(98, 169);
            this.ChkCboBoxToggleFilterPress.Name = "ChkCboBoxToggleFilterPress";
            this.ChkCboBoxToggleFilterPress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxToggleFilterPress.TabIndex = 23;
            this.ChkCboBoxToggleFilterPress.ValueSeparator = ", ";
            // 
            // ChkBoxToggleFilterPress
            // 
            this.ChkBoxToggleFilterPress.AutoSize = true;
            this.ChkBoxToggleFilterPress.Location = new System.Drawing.Point(6, 171);
            this.ChkBoxToggleFilterPress.Name = "ChkBoxToggleFilterPress";
            this.ChkBoxToggleFilterPress.Size = new System.Drawing.Size(84, 17);
            this.ChkBoxToggleFilterPress.TabIndex = 22;
            this.ChkBoxToggleFilterPress.Text = "Toggle Filter";
            this.ChkBoxToggleFilterPress.UseVisualStyleBackColor = true;
            this.ChkBoxToggleFilterPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxShowFilterPress
            // 
            this.ChkCboBoxShowFilterPress.CheckOnClick = true;
            this.ChkCboBoxShowFilterPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxShowFilterPress.DropDownHeight = 1;
            this.ChkCboBoxShowFilterPress.Enabled = false;
            this.ChkCboBoxShowFilterPress.FormattingEnabled = true;
            this.ChkCboBoxShowFilterPress.IntegralHeight = false;
            this.ChkCboBoxShowFilterPress.Location = new System.Drawing.Point(98, 121);
            this.ChkCboBoxShowFilterPress.Name = "ChkCboBoxShowFilterPress";
            this.ChkCboBoxShowFilterPress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxShowFilterPress.TabIndex = 21;
            this.ChkCboBoxShowFilterPress.ValueSeparator = ", ";
            // 
            // ChkBoxShowFilterPress
            // 
            this.ChkBoxShowFilterPress.AutoSize = true;
            this.ChkBoxShowFilterPress.Location = new System.Drawing.Point(6, 123);
            this.ChkBoxShowFilterPress.Name = "ChkBoxShowFilterPress";
            this.ChkBoxShowFilterPress.Size = new System.Drawing.Size(78, 17);
            this.ChkBoxShowFilterPress.TabIndex = 20;
            this.ChkBoxShowFilterPress.Text = "Show Filter";
            this.ChkBoxShowFilterPress.UseVisualStyleBackColor = true;
            this.ChkBoxShowFilterPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxHideFilterPress
            // 
            this.ChkCboBoxHideFilterPress.CheckOnClick = true;
            this.ChkCboBoxHideFilterPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHideFilterPress.DropDownHeight = 1;
            this.ChkCboBoxHideFilterPress.Enabled = false;
            this.ChkCboBoxHideFilterPress.FormattingEnabled = true;
            this.ChkCboBoxHideFilterPress.IntegralHeight = false;
            this.ChkCboBoxHideFilterPress.Location = new System.Drawing.Point(98, 145);
            this.ChkCboBoxHideFilterPress.Name = "ChkCboBoxHideFilterPress";
            this.ChkCboBoxHideFilterPress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxHideFilterPress.TabIndex = 19;
            this.ChkCboBoxHideFilterPress.ValueSeparator = ", ";
            // 
            // ChkBoxHideFilterPress
            // 
            this.ChkBoxHideFilterPress.AutoSize = true;
            this.ChkBoxHideFilterPress.Location = new System.Drawing.Point(6, 147);
            this.ChkBoxHideFilterPress.Name = "ChkBoxHideFilterPress";
            this.ChkBoxHideFilterPress.Size = new System.Drawing.Size(73, 17);
            this.ChkBoxHideFilterPress.TabIndex = 18;
            this.ChkBoxHideFilterPress.Text = "Hide Filter";
            this.ChkBoxHideFilterPress.UseVisualStyleBackColor = true;
            this.ChkBoxHideFilterPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxToggleSourcePress
            // 
            this.ChkCboBoxToggleSourcePress.CheckOnClick = true;
            this.ChkCboBoxToggleSourcePress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleSourcePress.DropDownHeight = 1;
            this.ChkCboBoxToggleSourcePress.Enabled = false;
            this.ChkCboBoxToggleSourcePress.FormattingEnabled = true;
            this.ChkCboBoxToggleSourcePress.IntegralHeight = false;
            this.ChkCboBoxToggleSourcePress.Location = new System.Drawing.Point(98, 97);
            this.ChkCboBoxToggleSourcePress.Name = "ChkCboBoxToggleSourcePress";
            this.ChkCboBoxToggleSourcePress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxToggleSourcePress.TabIndex = 17;
            this.ChkCboBoxToggleSourcePress.ValueSeparator = ", ";
            // 
            // ChkBoxToggleSourcePress
            // 
            this.ChkBoxToggleSourcePress.AutoSize = true;
            this.ChkBoxToggleSourcePress.Location = new System.Drawing.Point(6, 99);
            this.ChkBoxToggleSourcePress.Name = "ChkBoxToggleSourcePress";
            this.ChkBoxToggleSourcePress.Size = new System.Drawing.Size(96, 17);
            this.ChkBoxToggleSourcePress.TabIndex = 16;
            this.ChkBoxToggleSourcePress.Text = "Toggle Source";
            this.ChkBoxToggleSourcePress.UseVisualStyleBackColor = true;
            this.ChkBoxToggleSourcePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxToggleMutePress
            // 
            this.ChkCboBoxToggleMutePress.CheckOnClick = true;
            this.ChkCboBoxToggleMutePress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleMutePress.DropDownHeight = 1;
            this.ChkCboBoxToggleMutePress.Enabled = false;
            this.ChkCboBoxToggleMutePress.FormattingEnabled = true;
            this.ChkCboBoxToggleMutePress.IntegralHeight = false;
            this.ChkCboBoxToggleMutePress.Location = new System.Drawing.Point(363, 74);
            this.ChkCboBoxToggleMutePress.Name = "ChkCboBoxToggleMutePress";
            this.ChkCboBoxToggleMutePress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxToggleMutePress.TabIndex = 15;
            this.ChkCboBoxToggleMutePress.ValueSeparator = ", ";
            // 
            // ChkBoxTogglemutePress
            // 
            this.ChkBoxTogglemutePress.AutoSize = true;
            this.ChkBoxTogglemutePress.Location = new System.Drawing.Point(276, 76);
            this.ChkBoxTogglemutePress.Name = "ChkBoxTogglemutePress";
            this.ChkBoxTogglemutePress.Size = new System.Drawing.Size(86, 17);
            this.ChkBoxTogglemutePress.TabIndex = 14;
            this.ChkBoxTogglemutePress.Text = "Toggle Mute";
            this.ChkBoxTogglemutePress.UseVisualStyleBackColor = true;
            this.ChkBoxTogglemutePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxTransitionPress
            // 
            this.ChkBoxTransitionPress.AutoSize = true;
            this.ChkBoxTransitionPress.Location = new System.Drawing.Point(276, 6);
            this.ChkBoxTransitionPress.Name = "ChkBoxTransitionPress";
            this.ChkBoxTransitionPress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkBoxTransitionPress.Size = new System.Drawing.Size(72, 17);
            this.ChkBoxTransitionPress.TabIndex = 13;
            this.ChkBoxTransitionPress.Text = "Transition";
            this.ChkBoxTransitionPress.UseVisualStyleBackColor = true;
            this.ChkBoxTransitionPress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // NumericTransitionPress
            // 
            this.NumericTransitionPress.Enabled = false;
            this.NumericTransitionPress.Location = new System.Drawing.Point(502, 4);
            this.NumericTransitionPress.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericTransitionPress.Name = "NumericTransitionPress";
            this.NumericTransitionPress.Size = new System.Drawing.Size(52, 20);
            this.NumericTransitionPress.TabIndex = 12;
            // 
            // CboBoxTransitionPress
            // 
            this.CboBoxTransitionPress.Enabled = false;
            this.CboBoxTransitionPress.FormattingEnabled = true;
            this.CboBoxTransitionPress.Location = new System.Drawing.Point(363, 4);
            this.CboBoxTransitionPress.Name = "CboBoxTransitionPress";
            this.CboBoxTransitionPress.Size = new System.Drawing.Size(133, 21);
            this.CboBoxTransitionPress.TabIndex = 10;
            // 
            // ChkCboBoxHidePress
            // 
            this.ChkCboBoxHidePress.CheckOnClick = true;
            this.ChkCboBoxHidePress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHidePress.DropDownHeight = 1;
            this.ChkCboBoxHidePress.Enabled = false;
            this.ChkCboBoxHidePress.FormattingEnabled = true;
            this.ChkCboBoxHidePress.IntegralHeight = false;
            this.ChkCboBoxHidePress.Location = new System.Drawing.Point(98, 74);
            this.ChkCboBoxHidePress.Name = "ChkCboBoxHidePress";
            this.ChkCboBoxHidePress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxHidePress.TabIndex = 9;
            this.ChkCboBoxHidePress.ValueSeparator = ", ";
            // 
            // ChkBoxHideSourcePress
            // 
            this.ChkBoxHideSourcePress.AutoSize = true;
            this.ChkBoxHideSourcePress.Location = new System.Drawing.Point(6, 76);
            this.ChkBoxHideSourcePress.Name = "ChkBoxHideSourcePress";
            this.ChkBoxHideSourcePress.Size = new System.Drawing.Size(85, 17);
            this.ChkBoxHideSourcePress.TabIndex = 8;
            this.ChkBoxHideSourcePress.Text = "Hide Source";
            this.ChkBoxHideSourcePress.UseVisualStyleBackColor = true;
            this.ChkBoxHideSourcePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxShowPress
            // 
            this.ChkCboBoxShowPress.CheckOnClick = true;
            this.ChkCboBoxShowPress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxShowPress.DropDownHeight = 1;
            this.ChkCboBoxShowPress.Enabled = false;
            this.ChkCboBoxShowPress.FormattingEnabled = true;
            this.ChkCboBoxShowPress.IntegralHeight = false;
            this.ChkCboBoxShowPress.Location = new System.Drawing.Point(98, 50);
            this.ChkCboBoxShowPress.Name = "ChkCboBoxShowPress";
            this.ChkCboBoxShowPress.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxShowPress.TabIndex = 7;
            this.ChkCboBoxShowPress.ValueSeparator = ", ";
            // 
            // ChkBoxShowSourcePress
            // 
            this.ChkBoxShowSourcePress.AutoSize = true;
            this.ChkBoxShowSourcePress.Location = new System.Drawing.Point(6, 52);
            this.ChkBoxShowSourcePress.Name = "ChkBoxShowSourcePress";
            this.ChkBoxShowSourcePress.Size = new System.Drawing.Size(90, 17);
            this.ChkBoxShowSourcePress.TabIndex = 6;
            this.ChkBoxShowSourcePress.Text = "Show Source";
            this.ChkBoxShowSourcePress.UseVisualStyleBackColor = true;
            this.ChkBoxShowSourcePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxUnmutePress
            // 
            this.ChkCboBoxUnmutePress.CheckOnClick = true;
            this.ChkCboBoxUnmutePress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxUnmutePress.DropDownHeight = 1;
            this.ChkCboBoxUnmutePress.Enabled = false;
            this.ChkCboBoxUnmutePress.FormattingEnabled = true;
            this.ChkCboBoxUnmutePress.IntegralHeight = false;
            this.ChkCboBoxUnmutePress.Location = new System.Drawing.Point(363, 51);
            this.ChkCboBoxUnmutePress.Name = "ChkCboBoxUnmutePress";
            this.ChkCboBoxUnmutePress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxUnmutePress.TabIndex = 5;
            this.ChkCboBoxUnmutePress.ValueSeparator = ", ";
            // 
            // ChkBoxUnmutePress
            // 
            this.ChkBoxUnmutePress.AutoSize = true;
            this.ChkBoxUnmutePress.Location = new System.Drawing.Point(276, 53);
            this.ChkBoxUnmutePress.Name = "ChkBoxUnmutePress";
            this.ChkBoxUnmutePress.Size = new System.Drawing.Size(64, 17);
            this.ChkBoxUnmutePress.TabIndex = 4;
            this.ChkBoxUnmutePress.Text = "UnMute";
            this.ChkBoxUnmutePress.UseVisualStyleBackColor = true;
            this.ChkBoxUnmutePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMutePress
            // 
            this.ChkCboBoxMutePress.CheckOnClick = true;
            this.ChkCboBoxMutePress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMutePress.DropDownHeight = 1;
            this.ChkCboBoxMutePress.Enabled = false;
            this.ChkCboBoxMutePress.FormattingEnabled = true;
            this.ChkCboBoxMutePress.IntegralHeight = false;
            this.ChkCboBoxMutePress.Location = new System.Drawing.Point(363, 28);
            this.ChkCboBoxMutePress.Name = "ChkCboBoxMutePress";
            this.ChkCboBoxMutePress.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMutePress.TabIndex = 3;
            this.ChkCboBoxMutePress.ValueSeparator = ", ";
            // 
            // ChkBoxMutePress
            // 
            this.ChkBoxMutePress.AutoSize = true;
            this.ChkBoxMutePress.Location = new System.Drawing.Point(276, 30);
            this.ChkBoxMutePress.Name = "ChkBoxMutePress";
            this.ChkBoxMutePress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkBoxMutePress.Size = new System.Drawing.Size(50, 17);
            this.ChkBoxMutePress.TabIndex = 2;
            this.ChkBoxMutePress.Text = "Mute";
            this.ChkBoxMutePress.UseVisualStyleBackColor = true;
            this.ChkBoxMutePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // CboBoxSwitchScenePress
            // 
            this.CboBoxSwitchScenePress.Enabled = false;
            this.CboBoxSwitchScenePress.FormattingEnabled = true;
            this.CboBoxSwitchScenePress.Location = new System.Drawing.Point(98, 4);
            this.CboBoxSwitchScenePress.Name = "CboBoxSwitchScenePress";
            this.CboBoxSwitchScenePress.Size = new System.Drawing.Size(172, 21);
            this.CboBoxSwitchScenePress.TabIndex = 1;
            // 
            // ChkBoxSwitchScenePress
            // 
            this.ChkBoxSwitchScenePress.AutoSize = true;
            this.ChkBoxSwitchScenePress.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxSwitchScenePress.Name = "ChkBoxSwitchScenePress";
            this.ChkBoxSwitchScenePress.Size = new System.Drawing.Size(92, 17);
            this.ChkBoxSwitchScenePress.TabIndex = 0;
            this.ChkBoxSwitchScenePress.Text = "Switch Scene";
            this.ChkBoxSwitchScenePress.UseVisualStyleBackColor = true;
            this.ChkBoxSwitchScenePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // TabSoundPress
            // 
            this.TabSoundPress.Controls.Add(this.LblVolume);
            this.TabSoundPress.Controls.Add(this.volumeSlider);
            this.TabSoundPress.Controls.Add(this.chkBoxLoop);
            this.TabSoundPress.Controls.Add(this.LblAudioFile);
            this.TabSoundPress.Controls.Add(this.LblAudioDevice);
            this.TabSoundPress.Controls.Add(this.ChkBoxEnableAudio);
            this.TabSoundPress.Controls.Add(this.CboBoxAudioDevice);
            this.TabSoundPress.Controls.Add(this.BtnAudioSelect);
            this.TabSoundPress.Controls.Add(this.TxtBoxAudioFile);
            this.TabSoundPress.Location = new System.Drawing.Point(4, 22);
            this.TabSoundPress.Name = "TabSoundPress";
            this.TabSoundPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabSoundPress.Size = new System.Drawing.Size(560, 219);
            this.TabSoundPress.TabIndex = 1;
            this.TabSoundPress.Text = "SoundBoard";
            this.TabSoundPress.UseVisualStyleBackColor = true;
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Location = new System.Drawing.Point(99, 54);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(42, 13);
            this.LblVolume.TabIndex = 8;
            this.LblVolume.Text = "Volume";
            // 
            // volumeSlider
            // 
            this.volumeSlider.Location = new System.Drawing.Point(147, 51);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(96, 19);
            this.volumeSlider.TabIndex = 7;
            // 
            // chkBoxLoop
            // 
            this.chkBoxLoop.AutoSize = true;
            this.chkBoxLoop.Location = new System.Drawing.Point(6, 53);
            this.chkBoxLoop.Name = "chkBoxLoop";
            this.chkBoxLoop.Size = new System.Drawing.Size(50, 17);
            this.chkBoxLoop.TabIndex = 6;
            this.chkBoxLoop.Text = "Loop";
            this.chkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // LblAudioFile
            // 
            this.LblAudioFile.AutoSize = true;
            this.LblAudioFile.Location = new System.Drawing.Point(3, 28);
            this.LblAudioFile.Name = "LblAudioFile";
            this.LblAudioFile.Size = new System.Drawing.Size(23, 13);
            this.LblAudioFile.TabIndex = 5;
            this.LblAudioFile.Text = "File";
            // 
            // LblAudioDevice
            // 
            this.LblAudioDevice.AutoSize = true;
            this.LblAudioDevice.Location = new System.Drawing.Point(282, 54);
            this.LblAudioDevice.Name = "LblAudioDevice";
            this.LblAudioDevice.Size = new System.Drawing.Size(71, 13);
            this.LblAudioDevice.TabIndex = 4;
            this.LblAudioDevice.Text = "Audio Device";
            // 
            // ChkBoxEnableAudio
            // 
            this.ChkBoxEnableAudio.AutoSize = true;
            this.ChkBoxEnableAudio.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxEnableAudio.Name = "ChkBoxEnableAudio";
            this.ChkBoxEnableAudio.Size = new System.Drawing.Size(59, 17);
            this.ChkBoxEnableAudio.TabIndex = 3;
            this.ChkBoxEnableAudio.Text = "Enable";
            this.ChkBoxEnableAudio.UseVisualStyleBackColor = true;
            this.ChkBoxEnableAudio.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // CboBoxAudioDevice
            // 
            this.CboBoxAudioDevice.Enabled = false;
            this.CboBoxAudioDevice.FormattingEnabled = true;
            this.CboBoxAudioDevice.Location = new System.Drawing.Point(366, 51);
            this.CboBoxAudioDevice.Name = "CboBoxAudioDevice";
            this.CboBoxAudioDevice.Size = new System.Drawing.Size(188, 21);
            this.CboBoxAudioDevice.TabIndex = 2;
            // 
            // BtnAudioSelect
            // 
            this.BtnAudioSelect.Enabled = false;
            this.BtnAudioSelect.Location = new System.Drawing.Point(479, 23);
            this.BtnAudioSelect.Name = "BtnAudioSelect";
            this.BtnAudioSelect.Size = new System.Drawing.Size(75, 23);
            this.BtnAudioSelect.TabIndex = 1;
            this.BtnAudioSelect.Text = "Browse ...";
            this.BtnAudioSelect.UseVisualStyleBackColor = true;
            this.BtnAudioSelect.Click += new System.EventHandler(this.BtnAudioSelect_Click);
            // 
            // TxtBoxAudioFile
            // 
            this.TxtBoxAudioFile.Enabled = false;
            this.TxtBoxAudioFile.Location = new System.Drawing.Point(35, 25);
            this.TxtBoxAudioFile.Name = "TxtBoxAudioFile";
            this.TxtBoxAudioFile.Size = new System.Drawing.Size(438, 20);
            this.TxtBoxAudioFile.TabIndex = 0;
            // 
            // TabMediaKeyPress
            // 
            this.TabMediaKeyPress.Controls.Add(this.ChkBoxMediaKeyPreviousPress);
            this.TabMediaKeyPress.Controls.Add(this.ChkBoxMediaKeyNextPress);
            this.TabMediaKeyPress.Controls.Add(this.ChkBoxMediaKeyPlayPress);
            this.TabMediaKeyPress.Location = new System.Drawing.Point(4, 22);
            this.TabMediaKeyPress.Name = "TabMediaKeyPress";
            this.TabMediaKeyPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabMediaKeyPress.Size = new System.Drawing.Size(560, 219);
            this.TabMediaKeyPress.TabIndex = 2;
            this.TabMediaKeyPress.Text = "Media Keys";
            this.TabMediaKeyPress.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyPreviousPress
            // 
            this.ChkBoxMediaKeyPreviousPress.AutoSize = true;
            this.ChkBoxMediaKeyPreviousPress.Location = new System.Drawing.Point(6, 52);
            this.ChkBoxMediaKeyPreviousPress.Name = "ChkBoxMediaKeyPreviousPress";
            this.ChkBoxMediaKeyPreviousPress.Size = new System.Drawing.Size(120, 17);
            this.ChkBoxMediaKeyPreviousPress.TabIndex = 6;
            this.ChkBoxMediaKeyPreviousPress.Text = "Previous Media Key";
            this.ChkBoxMediaKeyPreviousPress.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyNextPress
            // 
            this.ChkBoxMediaKeyNextPress.AutoSize = true;
            this.ChkBoxMediaKeyNextPress.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxMediaKeyNextPress.Name = "ChkBoxMediaKeyNextPress";
            this.ChkBoxMediaKeyNextPress.Size = new System.Drawing.Size(101, 17);
            this.ChkBoxMediaKeyNextPress.TabIndex = 5;
            this.ChkBoxMediaKeyNextPress.Text = "Next Media Key";
            this.ChkBoxMediaKeyNextPress.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyPlayPress
            // 
            this.ChkBoxMediaKeyPlayPress.AutoSize = true;
            this.ChkBoxMediaKeyPlayPress.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxMediaKeyPlayPress.Name = "ChkBoxMediaKeyPlayPress";
            this.ChkBoxMediaKeyPlayPress.Size = new System.Drawing.Size(140, 17);
            this.ChkBoxMediaKeyPlayPress.TabIndex = 4;
            this.ChkBoxMediaKeyPlayPress.Text = "Play / Pause Media Key";
            this.ChkBoxMediaKeyPlayPress.UseVisualStyleBackColor = true;
            // 
            // TabTwitchPress
            // 
            this.TabTwitchPress.Controls.Add(this.LblTwitchMessagePress);
            this.TabTwitchPress.Controls.Add(this.TxtBoxTwitchMessagePress);
            this.TabTwitchPress.Controls.Add(this.TxtBoxTwitchChannelPress);
            this.TabTwitchPress.Controls.Add(this.LblChannelTwitchPress);
            this.TabTwitchPress.Location = new System.Drawing.Point(4, 22);
            this.TabTwitchPress.Name = "TabTwitchPress";
            this.TabTwitchPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabTwitchPress.Size = new System.Drawing.Size(560, 219);
            this.TabTwitchPress.TabIndex = 3;
            this.TabTwitchPress.Text = "Twitch Chat";
            this.TabTwitchPress.UseVisualStyleBackColor = true;
            // 
            // LblTwitchMessagePress
            // 
            this.LblTwitchMessagePress.AutoSize = true;
            this.LblTwitchMessagePress.Location = new System.Drawing.Point(6, 30);
            this.LblTwitchMessagePress.Name = "LblTwitchMessagePress";
            this.LblTwitchMessagePress.Size = new System.Drawing.Size(50, 13);
            this.LblTwitchMessagePress.TabIndex = 3;
            this.LblTwitchMessagePress.Text = "Message";
            // 
            // TxtBoxTwitchMessagePress
            // 
            this.TxtBoxTwitchMessagePress.Location = new System.Drawing.Point(4, 46);
            this.TxtBoxTwitchMessagePress.Multiline = true;
            this.TxtBoxTwitchMessagePress.Name = "TxtBoxTwitchMessagePress";
            this.TxtBoxTwitchMessagePress.Size = new System.Drawing.Size(550, 144);
            this.TxtBoxTwitchMessagePress.TabIndex = 2;
            // 
            // TxtBoxTwitchChannelPress
            // 
            this.TxtBoxTwitchChannelPress.Location = new System.Drawing.Point(411, 6);
            this.TxtBoxTwitchChannelPress.Name = "TxtBoxTwitchChannelPress";
            this.TxtBoxTwitchChannelPress.Size = new System.Drawing.Size(143, 20);
            this.TxtBoxTwitchChannelPress.TabIndex = 1;
            // 
            // LblChannelTwitchPress
            // 
            this.LblChannelTwitchPress.AutoSize = true;
            this.LblChannelTwitchPress.Location = new System.Drawing.Point(324, 9);
            this.LblChannelTwitchPress.Name = "LblChannelTwitchPress";
            this.LblChannelTwitchPress.Size = new System.Drawing.Size(81, 13);
            this.LblChannelTwitchPress.TabIndex = 0;
            this.LblChannelTwitchPress.Text = "Twitch Channel";
            // 
            // TabMIDIControlPress
            // 
            this.TabMIDIControlPress.Controls.Add(this.CboBoxProfilePress);
            this.TabMIDIControlPress.Controls.Add(this.ChkBoxSwitchToProfilePress);
            this.TabMIDIControlPress.Controls.Add(this.ChkBoxStopAllSoundPress);
            this.TabMIDIControlPress.Location = new System.Drawing.Point(4, 22);
            this.TabMIDIControlPress.Name = "TabMIDIControlPress";
            this.TabMIDIControlPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabMIDIControlPress.Size = new System.Drawing.Size(560, 219);
            this.TabMIDIControlPress.TabIndex = 4;
            this.TabMIDIControlPress.Text = "MIDIControl";
            this.TabMIDIControlPress.UseVisualStyleBackColor = true;
            // 
            // CboBoxProfilePress
            // 
            this.CboBoxProfilePress.Enabled = false;
            this.CboBoxProfilePress.FormattingEnabled = true;
            this.CboBoxProfilePress.Location = new System.Drawing.Point(118, 27);
            this.CboBoxProfilePress.Name = "CboBoxProfilePress";
            this.CboBoxProfilePress.Size = new System.Drawing.Size(166, 21);
            this.CboBoxProfilePress.TabIndex = 6;
            // 
            // ChkBoxSwitchToProfilePress
            // 
            this.ChkBoxSwitchToProfilePress.AutoSize = true;
            this.ChkBoxSwitchToProfilePress.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxSwitchToProfilePress.Name = "ChkBoxSwitchToProfilePress";
            this.ChkBoxSwitchToProfilePress.Size = new System.Drawing.Size(106, 17);
            this.ChkBoxSwitchToProfilePress.TabIndex = 5;
            this.ChkBoxSwitchToProfilePress.Text = "Switch To Profile";
            this.ChkBoxSwitchToProfilePress.UseVisualStyleBackColor = true;
            this.ChkBoxSwitchToProfilePress.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxStopAllSoundPress
            // 
            this.ChkBoxStopAllSoundPress.AutoSize = true;
            this.ChkBoxStopAllSoundPress.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxStopAllSoundPress.Name = "ChkBoxStopAllSoundPress";
            this.ChkBoxStopAllSoundPress.Size = new System.Drawing.Size(101, 17);
            this.ChkBoxStopAllSoundPress.TabIndex = 4;
            this.ChkBoxStopAllSoundPress.Text = "Stop All Sounds";
            this.ChkBoxStopAllSoundPress.UseVisualStyleBackColor = true;
            // 
            // TabGoXLRControlPress
            // 
            this.TabGoXLRControlPress.Controls.Add(this.LblXLROutputPress);
            this.TabGoXLRControlPress.Controls.Add(this.LblXLRInputPress);
            this.TabGoXLRControlPress.Controls.Add(this.PanelXLRPress);
            this.TabGoXLRControlPress.Controls.Add(this.CboBoxXLROutputPress);
            this.TabGoXLRControlPress.Controls.Add(this.CboBoxXLRInputPress);
            this.TabGoXLRControlPress.Location = new System.Drawing.Point(4, 22);
            this.TabGoXLRControlPress.Name = "TabGoXLRControlPress";
            this.TabGoXLRControlPress.Padding = new System.Windows.Forms.Padding(3);
            this.TabGoXLRControlPress.Size = new System.Drawing.Size(560, 219);
            this.TabGoXLRControlPress.TabIndex = 5;
            this.TabGoXLRControlPress.Text = "Go XLR";
            this.TabGoXLRControlPress.UseVisualStyleBackColor = true;
            // 
            // LblXLROutputPress
            // 
            this.LblXLROutputPress.AutoSize = true;
            this.LblXLROutputPress.Location = new System.Drawing.Point(96, 63);
            this.LblXLROutputPress.Name = "LblXLROutputPress";
            this.LblXLROutputPress.Size = new System.Drawing.Size(39, 13);
            this.LblXLROutputPress.TabIndex = 10;
            this.LblXLROutputPress.Text = "Output";
            // 
            // LblXLRInputPress
            // 
            this.LblXLRInputPress.AutoSize = true;
            this.LblXLRInputPress.Location = new System.Drawing.Point(104, 24);
            this.LblXLRInputPress.Name = "LblXLRInputPress";
            this.LblXLRInputPress.Size = new System.Drawing.Size(31, 13);
            this.LblXLRInputPress.TabIndex = 9;
            this.LblXLRInputPress.Text = "Input";
            // 
            // PanelXLRPress
            // 
            this.PanelXLRPress.Controls.Add(this.RadioButtonUnMuteXLRPress);
            this.PanelXLRPress.Controls.Add(this.RadioButtonMuteXLRPress);
            this.PanelXLRPress.Controls.Add(this.RadioButtonToggleXLRPress);
            this.PanelXLRPress.Controls.Add(this.RadioButtonDisabledXLRPress);
            this.PanelXLRPress.Location = new System.Drawing.Point(7, 6);
            this.PanelXLRPress.Name = "PanelXLRPress";
            this.PanelXLRPress.Size = new System.Drawing.Size(71, 97);
            this.PanelXLRPress.TabIndex = 8;
            // 
            // RadioButtonUnMuteXLRPress
            // 
            this.RadioButtonUnMuteXLRPress.AutoSize = true;
            this.RadioButtonUnMuteXLRPress.Location = new System.Drawing.Point(3, 72);
            this.RadioButtonUnMuteXLRPress.Name = "RadioButtonUnMuteXLRPress";
            this.RadioButtonUnMuteXLRPress.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonUnMuteXLRPress.TabIndex = 10;
            this.RadioButtonUnMuteXLRPress.Text = "UnMute";
            this.RadioButtonUnMuteXLRPress.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMuteXLRPress
            // 
            this.RadioButtonMuteXLRPress.AutoSize = true;
            this.RadioButtonMuteXLRPress.Location = new System.Drawing.Point(3, 49);
            this.RadioButtonMuteXLRPress.Name = "RadioButtonMuteXLRPress";
            this.RadioButtonMuteXLRPress.Size = new System.Drawing.Size(49, 17);
            this.RadioButtonMuteXLRPress.TabIndex = 9;
            this.RadioButtonMuteXLRPress.Text = "Mute";
            this.RadioButtonMuteXLRPress.UseVisualStyleBackColor = true;
            // 
            // RadioButtonToggleXLRPress
            // 
            this.RadioButtonToggleXLRPress.AutoSize = true;
            this.RadioButtonToggleXLRPress.Location = new System.Drawing.Point(3, 26);
            this.RadioButtonToggleXLRPress.Name = "RadioButtonToggleXLRPress";
            this.RadioButtonToggleXLRPress.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonToggleXLRPress.TabIndex = 8;
            this.RadioButtonToggleXLRPress.Text = "Toggle";
            this.RadioButtonToggleXLRPress.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDisabledXLRPress
            // 
            this.RadioButtonDisabledXLRPress.AutoSize = true;
            this.RadioButtonDisabledXLRPress.Checked = true;
            this.RadioButtonDisabledXLRPress.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonDisabledXLRPress.Name = "RadioButtonDisabledXLRPress";
            this.RadioButtonDisabledXLRPress.Size = new System.Drawing.Size(66, 17);
            this.RadioButtonDisabledXLRPress.TabIndex = 7;
            this.RadioButtonDisabledXLRPress.TabStop = true;
            this.RadioButtonDisabledXLRPress.Text = "Disabled";
            this.RadioButtonDisabledXLRPress.UseVisualStyleBackColor = true;
            // 
            // CboBoxXLROutputPress
            // 
            this.CboBoxXLROutputPress.FormattingEnabled = true;
            this.CboBoxXLROutputPress.Location = new System.Drawing.Point(141, 60);
            this.CboBoxXLROutputPress.Name = "CboBoxXLROutputPress";
            this.CboBoxXLROutputPress.Size = new System.Drawing.Size(121, 21);
            this.CboBoxXLROutputPress.TabIndex = 2;
            // 
            // CboBoxXLRInputPress
            // 
            this.CboBoxXLRInputPress.FormattingEnabled = true;
            this.CboBoxXLRInputPress.Location = new System.Drawing.Point(141, 21);
            this.CboBoxXLRInputPress.Name = "CboBoxXLRInputPress";
            this.CboBoxXLRInputPress.Size = new System.Drawing.Size(121, 21);
            this.CboBoxXLRInputPress.TabIndex = 1;
            // 
            // tabLaunchProgramKeyPress
            // 
            this.tabLaunchProgramKeyPress.Controls.Add(this.ChkBoxHideProgramPress);
            this.tabLaunchProgramKeyPress.Controls.Add(this.lblArgsPress);
            this.tabLaunchProgramKeyPress.Controls.Add(this.TxtBoxArgsPress);
            this.tabLaunchProgramKeyPress.Controls.Add(this.lblFilePress);
            this.tabLaunchProgramKeyPress.Controls.Add(this.BtnProgramSelectPress);
            this.tabLaunchProgramKeyPress.Controls.Add(this.TxtBoxProgramPress);
            this.tabLaunchProgramKeyPress.Location = new System.Drawing.Point(4, 22);
            this.tabLaunchProgramKeyPress.Name = "tabLaunchProgramKeyPress";
            this.tabLaunchProgramKeyPress.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaunchProgramKeyPress.Size = new System.Drawing.Size(560, 219);
            this.tabLaunchProgramKeyPress.TabIndex = 6;
            this.tabLaunchProgramKeyPress.Text = "Launch Program";
            this.tabLaunchProgramKeyPress.UseVisualStyleBackColor = true;
            // 
            // ChkBoxHideProgramPress
            // 
            this.ChkBoxHideProgramPress.AutoSize = true;
            this.ChkBoxHideProgramPress.Location = new System.Drawing.Point(6, 58);
            this.ChkBoxHideProgramPress.Name = "ChkBoxHideProgramPress";
            this.ChkBoxHideProgramPress.Size = new System.Drawing.Size(141, 17);
            this.ChkBoxHideProgramPress.TabIndex = 16;
            this.ChkBoxHideProgramPress.Text = "Hide Launched Program";
            this.ChkBoxHideProgramPress.UseVisualStyleBackColor = true;
            // 
            // lblArgsPress
            // 
            this.lblArgsPress.AutoSize = true;
            this.lblArgsPress.Location = new System.Drawing.Point(4, 35);
            this.lblArgsPress.Name = "lblArgsPress";
            this.lblArgsPress.Size = new System.Drawing.Size(57, 13);
            this.lblArgsPress.TabIndex = 15;
            this.lblArgsPress.Text = "Arguments";
            // 
            // TxtBoxArgsPress
            // 
            this.TxtBoxArgsPress.Location = new System.Drawing.Point(67, 32);
            this.TxtBoxArgsPress.Name = "TxtBoxArgsPress";
            this.TxtBoxArgsPress.Size = new System.Drawing.Size(218, 20);
            this.TxtBoxArgsPress.TabIndex = 14;
            // 
            // lblFilePress
            // 
            this.lblFilePress.AutoSize = true;
            this.lblFilePress.Location = new System.Drawing.Point(6, 9);
            this.lblFilePress.Name = "lblFilePress";
            this.lblFilePress.Size = new System.Drawing.Size(23, 13);
            this.lblFilePress.TabIndex = 13;
            this.lblFilePress.Text = "File";
            // 
            // BtnProgramSelectPress
            // 
            this.BtnProgramSelectPress.Location = new System.Drawing.Point(477, 4);
            this.BtnProgramSelectPress.Name = "BtnProgramSelectPress";
            this.BtnProgramSelectPress.Size = new System.Drawing.Size(75, 23);
            this.BtnProgramSelectPress.TabIndex = 12;
            this.BtnProgramSelectPress.Text = "Browse ...";
            this.BtnProgramSelectPress.UseVisualStyleBackColor = true;
            this.BtnProgramSelectPress.Click += new System.EventHandler(this.BtnProgramSelectPress_Click);
            // 
            // TxtBoxProgramPress
            // 
            this.TxtBoxProgramPress.Location = new System.Drawing.Point(67, 6);
            this.TxtBoxProgramPress.Name = "TxtBoxProgramPress";
            this.TxtBoxProgramPress.Size = new System.Drawing.Size(407, 20);
            this.TxtBoxProgramPress.TabIndex = 11;
            // 
            // GrpBoxKeyRelease
            // 
            this.GrpBoxKeyRelease.Controls.Add(this.TabKeyRelease);
            this.GrpBoxKeyRelease.Location = new System.Drawing.Point(9, 312);
            this.GrpBoxKeyRelease.Name = "GrpBoxKeyRelease";
            this.GrpBoxKeyRelease.Size = new System.Drawing.Size(579, 259);
            this.GrpBoxKeyRelease.TabIndex = 12;
            this.GrpBoxKeyRelease.TabStop = false;
            this.GrpBoxKeyRelease.Text = "On Key Release";
            // 
            // TabKeyRelease
            // 
            this.TabKeyRelease.Controls.Add(this.TabOBSRelease);
            this.TabKeyRelease.Controls.Add(this.TabSoundRelease);
            this.TabKeyRelease.Controls.Add(this.TabMediaKeyRelease);
            this.TabKeyRelease.Controls.Add(this.TabTwitchRelease);
            this.TabKeyRelease.Controls.Add(this.TabMIDIControlRelease);
            this.TabKeyRelease.Controls.Add(this.TabGoXLRControlRelease);
            this.TabKeyRelease.Controls.Add(this.tabLaunchProgramKeyRelease);
            this.TabKeyRelease.Location = new System.Drawing.Point(7, 20);
            this.TabKeyRelease.Name = "TabKeyRelease";
            this.TabKeyRelease.SelectedIndex = 0;
            this.TabKeyRelease.Size = new System.Drawing.Size(568, 237);
            this.TabKeyRelease.TabIndex = 0;
            // 
            // TabOBSRelease
            // 
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxHotkeyRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxHotkeyRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxMediaStopRelease);
            this.TabOBSRelease.Controls.Add(this.CboBoxPreviewSceneRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxMediaStopRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxMediaRestartRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxPreviewSceneRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxMediaRestartRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxMiscRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxMediaPlayRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxMiscRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxMediaPlayRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxToggleFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxToggleSourceRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxToggleFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxToggleSourceRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxShowFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxToggleMuteRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxShowFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxHideFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxTogglemuteRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxHideFilterRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxTransitionRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxHideRelease);
            this.TabOBSRelease.Controls.Add(this.NumericTransitionRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxSwitchSceneRelease);
            this.TabOBSRelease.Controls.Add(this.CboBoxTransitionRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxHideSourceRelease);
            this.TabOBSRelease.Controls.Add(this.CboBoxSwitchSceneRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxShowRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxMuteRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxShowSourceRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxMuteRelease);
            this.TabOBSRelease.Controls.Add(this.ChkCboBoxUnmuteRelease);
            this.TabOBSRelease.Controls.Add(this.ChkBoxUnmuteRelease);
            this.TabOBSRelease.Location = new System.Drawing.Point(4, 22);
            this.TabOBSRelease.Name = "TabOBSRelease";
            this.TabOBSRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabOBSRelease.Size = new System.Drawing.Size(560, 211);
            this.TabOBSRelease.TabIndex = 0;
            this.TabOBSRelease.Text = "OBS";
            this.TabOBSRelease.UseVisualStyleBackColor = true;
            // 
            // ChkCboBoxHotkeyRelease
            // 
            this.ChkCboBoxHotkeyRelease.CheckOnClick = true;
            this.ChkCboBoxHotkeyRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHotkeyRelease.DropDownHeight = 1;
            this.ChkCboBoxHotkeyRelease.Enabled = false;
            this.ChkCboBoxHotkeyRelease.FormattingEnabled = true;
            this.ChkCboBoxHotkeyRelease.IntegralHeight = false;
            this.ChkCboBoxHotkeyRelease.Location = new System.Drawing.Point(363, 187);
            this.ChkCboBoxHotkeyRelease.Name = "ChkCboBoxHotkeyRelease";
            this.ChkCboBoxHotkeyRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxHotkeyRelease.TabIndex = 41;
            this.ChkCboBoxHotkeyRelease.ValueSeparator = ", ";
            // 
            // ChkBoxHotkeyRelease
            // 
            this.ChkBoxHotkeyRelease.AutoSize = true;
            this.ChkBoxHotkeyRelease.Location = new System.Drawing.Point(276, 189);
            this.ChkBoxHotkeyRelease.Name = "ChkBoxHotkeyRelease";
            this.ChkBoxHotkeyRelease.Size = new System.Drawing.Size(60, 17);
            this.ChkBoxHotkeyRelease.TabIndex = 40;
            this.ChkBoxHotkeyRelease.Text = "Hotkey";
            this.ChkBoxHotkeyRelease.UseVisualStyleBackColor = true;
            this.ChkBoxHotkeyRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMediaStopRelease
            // 
            this.ChkCboBoxMediaStopRelease.CheckOnClick = true;
            this.ChkCboBoxMediaStopRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaStopRelease.DropDownHeight = 1;
            this.ChkCboBoxMediaStopRelease.Enabled = false;
            this.ChkCboBoxMediaStopRelease.FormattingEnabled = true;
            this.ChkCboBoxMediaStopRelease.IntegralHeight = false;
            this.ChkCboBoxMediaStopRelease.Location = new System.Drawing.Point(363, 117);
            this.ChkCboBoxMediaStopRelease.Name = "ChkCboBoxMediaStopRelease";
            this.ChkCboBoxMediaStopRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaStopRelease.TabIndex = 39;
            this.ChkCboBoxMediaStopRelease.ValueSeparator = ", ";
            // 
            // CboBoxPreviewSceneRelease
            // 
            this.CboBoxPreviewSceneRelease.Enabled = false;
            this.CboBoxPreviewSceneRelease.FormattingEnabled = true;
            this.CboBoxPreviewSceneRelease.Location = new System.Drawing.Point(98, 27);
            this.CboBoxPreviewSceneRelease.Name = "CboBoxPreviewSceneRelease";
            this.CboBoxPreviewSceneRelease.Size = new System.Drawing.Size(172, 21);
            this.CboBoxPreviewSceneRelease.TabIndex = 31;
            // 
            // ChkBoxMediaStopRelease
            // 
            this.ChkBoxMediaStopRelease.AutoSize = true;
            this.ChkBoxMediaStopRelease.Location = new System.Drawing.Point(276, 119);
            this.ChkBoxMediaStopRelease.Name = "ChkBoxMediaStopRelease";
            this.ChkBoxMediaStopRelease.Size = new System.Drawing.Size(80, 17);
            this.ChkBoxMediaStopRelease.TabIndex = 38;
            this.ChkBoxMediaStopRelease.Text = "Media Stop";
            this.ChkBoxMediaStopRelease.UseVisualStyleBackColor = true;
            this.ChkBoxMediaStopRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMediaRestartRelease
            // 
            this.ChkCboBoxMediaRestartRelease.CheckOnClick = true;
            this.ChkCboBoxMediaRestartRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaRestartRelease.DropDownHeight = 1;
            this.ChkCboBoxMediaRestartRelease.Enabled = false;
            this.ChkCboBoxMediaRestartRelease.FormattingEnabled = true;
            this.ChkCboBoxMediaRestartRelease.IntegralHeight = false;
            this.ChkCboBoxMediaRestartRelease.Location = new System.Drawing.Point(363, 141);
            this.ChkCboBoxMediaRestartRelease.Name = "ChkCboBoxMediaRestartRelease";
            this.ChkCboBoxMediaRestartRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaRestartRelease.TabIndex = 37;
            this.ChkCboBoxMediaRestartRelease.ValueSeparator = ", ";
            // 
            // ChkBoxPreviewSceneRelease
            // 
            this.ChkBoxPreviewSceneRelease.AutoSize = true;
            this.ChkBoxPreviewSceneRelease.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxPreviewSceneRelease.Name = "ChkBoxPreviewSceneRelease";
            this.ChkBoxPreviewSceneRelease.Size = new System.Drawing.Size(98, 17);
            this.ChkBoxPreviewSceneRelease.TabIndex = 30;
            this.ChkBoxPreviewSceneRelease.Text = "Preview Scene";
            this.ChkBoxPreviewSceneRelease.UseVisualStyleBackColor = true;
            this.ChkBoxPreviewSceneRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxMediaRestartRelease
            // 
            this.ChkBoxMediaRestartRelease.AutoSize = true;
            this.ChkBoxMediaRestartRelease.Location = new System.Drawing.Point(276, 143);
            this.ChkBoxMediaRestartRelease.Name = "ChkBoxMediaRestartRelease";
            this.ChkBoxMediaRestartRelease.Size = new System.Drawing.Size(92, 17);
            this.ChkBoxMediaRestartRelease.TabIndex = 36;
            this.ChkBoxMediaRestartRelease.Text = "Media Restart";
            this.ChkBoxMediaRestartRelease.UseVisualStyleBackColor = true;
            this.ChkBoxMediaRestartRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMiscRelease
            // 
            this.ChkCboBoxMiscRelease.CheckOnClick = true;
            this.ChkCboBoxMiscRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMiscRelease.DropDownHeight = 1;
            this.ChkCboBoxMiscRelease.Enabled = false;
            this.ChkCboBoxMiscRelease.FormattingEnabled = true;
            this.ChkCboBoxMiscRelease.IntegralHeight = false;
            this.ChkCboBoxMiscRelease.Location = new System.Drawing.Point(363, 164);
            this.ChkCboBoxMiscRelease.Name = "ChkCboBoxMiscRelease";
            this.ChkCboBoxMiscRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMiscRelease.TabIndex = 27;
            this.ChkCboBoxMiscRelease.ValueSeparator = ", ";
            // 
            // ChkCboBoxMediaPlayRelease
            // 
            this.ChkCboBoxMediaPlayRelease.CheckOnClick = true;
            this.ChkCboBoxMediaPlayRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMediaPlayRelease.DropDownHeight = 1;
            this.ChkCboBoxMediaPlayRelease.Enabled = false;
            this.ChkCboBoxMediaPlayRelease.FormattingEnabled = true;
            this.ChkCboBoxMediaPlayRelease.IntegralHeight = false;
            this.ChkCboBoxMediaPlayRelease.Location = new System.Drawing.Point(363, 94);
            this.ChkCboBoxMediaPlayRelease.Name = "ChkCboBoxMediaPlayRelease";
            this.ChkCboBoxMediaPlayRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMediaPlayRelease.TabIndex = 35;
            this.ChkCboBoxMediaPlayRelease.ValueSeparator = ", ";
            // 
            // ChkBoxMiscRelease
            // 
            this.ChkBoxMiscRelease.AutoSize = true;
            this.ChkBoxMiscRelease.Location = new System.Drawing.Point(276, 166);
            this.ChkBoxMiscRelease.Name = "ChkBoxMiscRelease";
            this.ChkBoxMiscRelease.Size = new System.Drawing.Size(48, 17);
            this.ChkBoxMiscRelease.TabIndex = 26;
            this.ChkBoxMiscRelease.Text = "Misc";
            this.ChkBoxMiscRelease.UseVisualStyleBackColor = true;
            this.ChkBoxMiscRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxMediaPlayRelease
            // 
            this.ChkBoxMediaPlayRelease.AutoSize = true;
            this.ChkBoxMediaPlayRelease.Location = new System.Drawing.Point(276, 96);
            this.ChkBoxMediaPlayRelease.Name = "ChkBoxMediaPlayRelease";
            this.ChkBoxMediaPlayRelease.Size = new System.Drawing.Size(78, 17);
            this.ChkBoxMediaPlayRelease.TabIndex = 34;
            this.ChkBoxMediaPlayRelease.Text = "Media Play";
            this.ChkBoxMediaPlayRelease.UseVisualStyleBackColor = true;
            this.ChkBoxMediaPlayRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxToggleFilterRelease
            // 
            this.ChkCboBoxToggleFilterRelease.CheckOnClick = true;
            this.ChkCboBoxToggleFilterRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleFilterRelease.DropDownHeight = 1;
            this.ChkCboBoxToggleFilterRelease.Enabled = false;
            this.ChkCboBoxToggleFilterRelease.FormattingEnabled = true;
            this.ChkCboBoxToggleFilterRelease.IntegralHeight = false;
            this.ChkCboBoxToggleFilterRelease.Location = new System.Drawing.Point(98, 164);
            this.ChkCboBoxToggleFilterRelease.Name = "ChkCboBoxToggleFilterRelease";
            this.ChkCboBoxToggleFilterRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxToggleFilterRelease.TabIndex = 29;
            this.ChkCboBoxToggleFilterRelease.ValueSeparator = ", ";
            // 
            // ChkCboBoxToggleSourceRelease
            // 
            this.ChkCboBoxToggleSourceRelease.CheckOnClick = true;
            this.ChkCboBoxToggleSourceRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleSourceRelease.DropDownHeight = 1;
            this.ChkCboBoxToggleSourceRelease.Enabled = false;
            this.ChkCboBoxToggleSourceRelease.FormattingEnabled = true;
            this.ChkCboBoxToggleSourceRelease.IntegralHeight = false;
            this.ChkCboBoxToggleSourceRelease.Location = new System.Drawing.Point(98, 96);
            this.ChkCboBoxToggleSourceRelease.Name = "ChkCboBoxToggleSourceRelease";
            this.ChkCboBoxToggleSourceRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxToggleSourceRelease.TabIndex = 23;
            this.ChkCboBoxToggleSourceRelease.ValueSeparator = ", ";
            // 
            // ChkBoxToggleFilterRelease
            // 
            this.ChkBoxToggleFilterRelease.AutoSize = true;
            this.ChkBoxToggleFilterRelease.Location = new System.Drawing.Point(6, 166);
            this.ChkBoxToggleFilterRelease.Name = "ChkBoxToggleFilterRelease";
            this.ChkBoxToggleFilterRelease.Size = new System.Drawing.Size(84, 17);
            this.ChkBoxToggleFilterRelease.TabIndex = 28;
            this.ChkBoxToggleFilterRelease.Text = "Toggle Filter";
            this.ChkBoxToggleFilterRelease.UseVisualStyleBackColor = true;
            this.ChkBoxToggleFilterRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxToggleSourceRelease
            // 
            this.ChkBoxToggleSourceRelease.AutoSize = true;
            this.ChkBoxToggleSourceRelease.Location = new System.Drawing.Point(6, 98);
            this.ChkBoxToggleSourceRelease.Name = "ChkBoxToggleSourceRelease";
            this.ChkBoxToggleSourceRelease.Size = new System.Drawing.Size(96, 17);
            this.ChkBoxToggleSourceRelease.TabIndex = 22;
            this.ChkBoxToggleSourceRelease.Text = "Toggle Source";
            this.ChkBoxToggleSourceRelease.UseVisualStyleBackColor = true;
            this.ChkBoxToggleSourceRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxShowFilterRelease
            // 
            this.ChkCboBoxShowFilterRelease.CheckOnClick = true;
            this.ChkCboBoxShowFilterRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxShowFilterRelease.DropDownHeight = 1;
            this.ChkCboBoxShowFilterRelease.Enabled = false;
            this.ChkCboBoxShowFilterRelease.FormattingEnabled = true;
            this.ChkCboBoxShowFilterRelease.IntegralHeight = false;
            this.ChkCboBoxShowFilterRelease.Location = new System.Drawing.Point(98, 119);
            this.ChkCboBoxShowFilterRelease.Name = "ChkCboBoxShowFilterRelease";
            this.ChkCboBoxShowFilterRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxShowFilterRelease.TabIndex = 27;
            this.ChkCboBoxShowFilterRelease.ValueSeparator = ", ";
            // 
            // ChkCboBoxToggleMuteRelease
            // 
            this.ChkCboBoxToggleMuteRelease.CheckOnClick = true;
            this.ChkCboBoxToggleMuteRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxToggleMuteRelease.DropDownHeight = 1;
            this.ChkCboBoxToggleMuteRelease.Enabled = false;
            this.ChkCboBoxToggleMuteRelease.FormattingEnabled = true;
            this.ChkCboBoxToggleMuteRelease.IntegralHeight = false;
            this.ChkCboBoxToggleMuteRelease.Location = new System.Drawing.Point(363, 72);
            this.ChkCboBoxToggleMuteRelease.Name = "ChkCboBoxToggleMuteRelease";
            this.ChkCboBoxToggleMuteRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxToggleMuteRelease.TabIndex = 21;
            this.ChkCboBoxToggleMuteRelease.ValueSeparator = ", ";
            // 
            // ChkBoxShowFilterRelease
            // 
            this.ChkBoxShowFilterRelease.AutoSize = true;
            this.ChkBoxShowFilterRelease.Location = new System.Drawing.Point(6, 121);
            this.ChkBoxShowFilterRelease.Name = "ChkBoxShowFilterRelease";
            this.ChkBoxShowFilterRelease.Size = new System.Drawing.Size(78, 17);
            this.ChkBoxShowFilterRelease.TabIndex = 26;
            this.ChkBoxShowFilterRelease.Text = "Show Filter";
            this.ChkBoxShowFilterRelease.UseVisualStyleBackColor = true;
            this.ChkBoxShowFilterRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxHideFilterRelease
            // 
            this.ChkCboBoxHideFilterRelease.CheckOnClick = true;
            this.ChkCboBoxHideFilterRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHideFilterRelease.DropDownHeight = 1;
            this.ChkCboBoxHideFilterRelease.Enabled = false;
            this.ChkCboBoxHideFilterRelease.FormattingEnabled = true;
            this.ChkCboBoxHideFilterRelease.IntegralHeight = false;
            this.ChkCboBoxHideFilterRelease.Location = new System.Drawing.Point(98, 142);
            this.ChkCboBoxHideFilterRelease.Name = "ChkCboBoxHideFilterRelease";
            this.ChkCboBoxHideFilterRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxHideFilterRelease.TabIndex = 25;
            this.ChkCboBoxHideFilterRelease.ValueSeparator = ", ";
            // 
            // ChkBoxTogglemuteRelease
            // 
            this.ChkBoxTogglemuteRelease.AutoSize = true;
            this.ChkBoxTogglemuteRelease.Location = new System.Drawing.Point(276, 74);
            this.ChkBoxTogglemuteRelease.Name = "ChkBoxTogglemuteRelease";
            this.ChkBoxTogglemuteRelease.Size = new System.Drawing.Size(86, 17);
            this.ChkBoxTogglemuteRelease.TabIndex = 20;
            this.ChkBoxTogglemuteRelease.Text = "Toggle Mute";
            this.ChkBoxTogglemuteRelease.UseVisualStyleBackColor = true;
            this.ChkBoxTogglemuteRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxHideFilterRelease
            // 
            this.ChkBoxHideFilterRelease.AutoSize = true;
            this.ChkBoxHideFilterRelease.Location = new System.Drawing.Point(6, 144);
            this.ChkBoxHideFilterRelease.Name = "ChkBoxHideFilterRelease";
            this.ChkBoxHideFilterRelease.Size = new System.Drawing.Size(73, 17);
            this.ChkBoxHideFilterRelease.TabIndex = 24;
            this.ChkBoxHideFilterRelease.Text = "Hide Filter";
            this.ChkBoxHideFilterRelease.UseVisualStyleBackColor = true;
            this.ChkBoxHideFilterRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxTransitionRelease
            // 
            this.ChkBoxTransitionRelease.AutoSize = true;
            this.ChkBoxTransitionRelease.Location = new System.Drawing.Point(276, 6);
            this.ChkBoxTransitionRelease.Name = "ChkBoxTransitionRelease";
            this.ChkBoxTransitionRelease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkBoxTransitionRelease.Size = new System.Drawing.Size(72, 17);
            this.ChkBoxTransitionRelease.TabIndex = 16;
            this.ChkBoxTransitionRelease.Text = "Transition";
            this.ChkBoxTransitionRelease.UseVisualStyleBackColor = true;
            this.ChkBoxTransitionRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxHideRelease
            // 
            this.ChkCboBoxHideRelease.CheckOnClick = true;
            this.ChkCboBoxHideRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxHideRelease.DropDownHeight = 1;
            this.ChkCboBoxHideRelease.Enabled = false;
            this.ChkCboBoxHideRelease.FormattingEnabled = true;
            this.ChkCboBoxHideRelease.IntegralHeight = false;
            this.ChkCboBoxHideRelease.Location = new System.Drawing.Point(98, 73);
            this.ChkCboBoxHideRelease.Name = "ChkCboBoxHideRelease";
            this.ChkCboBoxHideRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxHideRelease.TabIndex = 19;
            this.ChkCboBoxHideRelease.ValueSeparator = ", ";
            // 
            // NumericTransitionRelease
            // 
            this.NumericTransitionRelease.Enabled = false;
            this.NumericTransitionRelease.Location = new System.Drawing.Point(502, 4);
            this.NumericTransitionRelease.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericTransitionRelease.Name = "NumericTransitionRelease";
            this.NumericTransitionRelease.Size = new System.Drawing.Size(52, 20);
            this.NumericTransitionRelease.TabIndex = 15;
            // 
            // ChkBoxSwitchSceneRelease
            // 
            this.ChkBoxSwitchSceneRelease.AutoSize = true;
            this.ChkBoxSwitchSceneRelease.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxSwitchSceneRelease.Name = "ChkBoxSwitchSceneRelease";
            this.ChkBoxSwitchSceneRelease.Size = new System.Drawing.Size(92, 17);
            this.ChkBoxSwitchSceneRelease.TabIndex = 10;
            this.ChkBoxSwitchSceneRelease.Text = "Switch Scene";
            this.ChkBoxSwitchSceneRelease.UseVisualStyleBackColor = true;
            this.ChkBoxSwitchSceneRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // CboBoxTransitionRelease
            // 
            this.CboBoxTransitionRelease.Enabled = false;
            this.CboBoxTransitionRelease.FormattingEnabled = true;
            this.CboBoxTransitionRelease.Location = new System.Drawing.Point(363, 4);
            this.CboBoxTransitionRelease.Name = "CboBoxTransitionRelease";
            this.CboBoxTransitionRelease.Size = new System.Drawing.Size(133, 21);
            this.CboBoxTransitionRelease.TabIndex = 14;
            // 
            // ChkBoxHideSourceRelease
            // 
            this.ChkBoxHideSourceRelease.AutoSize = true;
            this.ChkBoxHideSourceRelease.Location = new System.Drawing.Point(6, 75);
            this.ChkBoxHideSourceRelease.Name = "ChkBoxHideSourceRelease";
            this.ChkBoxHideSourceRelease.Size = new System.Drawing.Size(85, 17);
            this.ChkBoxHideSourceRelease.TabIndex = 18;
            this.ChkBoxHideSourceRelease.Text = "Hide Source";
            this.ChkBoxHideSourceRelease.UseVisualStyleBackColor = true;
            this.ChkBoxHideSourceRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // CboBoxSwitchSceneRelease
            // 
            this.CboBoxSwitchSceneRelease.Enabled = false;
            this.CboBoxSwitchSceneRelease.FormattingEnabled = true;
            this.CboBoxSwitchSceneRelease.Location = new System.Drawing.Point(98, 4);
            this.CboBoxSwitchSceneRelease.Name = "CboBoxSwitchSceneRelease";
            this.CboBoxSwitchSceneRelease.Size = new System.Drawing.Size(172, 21);
            this.CboBoxSwitchSceneRelease.TabIndex = 11;
            // 
            // ChkCboBoxShowRelease
            // 
            this.ChkCboBoxShowRelease.CheckOnClick = true;
            this.ChkCboBoxShowRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxShowRelease.DropDownHeight = 1;
            this.ChkCboBoxShowRelease.Enabled = false;
            this.ChkCboBoxShowRelease.FormattingEnabled = true;
            this.ChkCboBoxShowRelease.IntegralHeight = false;
            this.ChkCboBoxShowRelease.Location = new System.Drawing.Point(98, 50);
            this.ChkCboBoxShowRelease.Name = "ChkCboBoxShowRelease";
            this.ChkCboBoxShowRelease.Size = new System.Drawing.Size(172, 21);
            this.ChkCboBoxShowRelease.TabIndex = 17;
            this.ChkCboBoxShowRelease.ValueSeparator = ", ";
            // 
            // ChkBoxMuteRelease
            // 
            this.ChkBoxMuteRelease.AutoSize = true;
            this.ChkBoxMuteRelease.Location = new System.Drawing.Point(276, 29);
            this.ChkBoxMuteRelease.Name = "ChkBoxMuteRelease";
            this.ChkBoxMuteRelease.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChkBoxMuteRelease.Size = new System.Drawing.Size(50, 17);
            this.ChkBoxMuteRelease.TabIndex = 12;
            this.ChkBoxMuteRelease.Text = "Mute";
            this.ChkBoxMuteRelease.UseVisualStyleBackColor = true;
            this.ChkBoxMuteRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxShowSourceRelease
            // 
            this.ChkBoxShowSourceRelease.AutoSize = true;
            this.ChkBoxShowSourceRelease.Location = new System.Drawing.Point(6, 52);
            this.ChkBoxShowSourceRelease.Name = "ChkBoxShowSourceRelease";
            this.ChkBoxShowSourceRelease.Size = new System.Drawing.Size(90, 17);
            this.ChkBoxShowSourceRelease.TabIndex = 16;
            this.ChkBoxShowSourceRelease.Text = "Show Source";
            this.ChkBoxShowSourceRelease.UseVisualStyleBackColor = true;
            this.ChkBoxShowSourceRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxMuteRelease
            // 
            this.ChkCboBoxMuteRelease.CheckOnClick = true;
            this.ChkCboBoxMuteRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxMuteRelease.DropDownHeight = 1;
            this.ChkCboBoxMuteRelease.Enabled = false;
            this.ChkCboBoxMuteRelease.FormattingEnabled = true;
            this.ChkCboBoxMuteRelease.IntegralHeight = false;
            this.ChkCboBoxMuteRelease.Location = new System.Drawing.Point(363, 27);
            this.ChkCboBoxMuteRelease.Name = "ChkCboBoxMuteRelease";
            this.ChkCboBoxMuteRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxMuteRelease.TabIndex = 13;
            this.ChkCboBoxMuteRelease.ValueSeparator = ", ";
            // 
            // ChkCboBoxUnmuteRelease
            // 
            this.ChkCboBoxUnmuteRelease.CheckOnClick = true;
            this.ChkCboBoxUnmuteRelease.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxUnmuteRelease.DropDownHeight = 1;
            this.ChkCboBoxUnmuteRelease.Enabled = false;
            this.ChkCboBoxUnmuteRelease.FormattingEnabled = true;
            this.ChkCboBoxUnmuteRelease.IntegralHeight = false;
            this.ChkCboBoxUnmuteRelease.Location = new System.Drawing.Point(363, 50);
            this.ChkCboBoxUnmuteRelease.Name = "ChkCboBoxUnmuteRelease";
            this.ChkCboBoxUnmuteRelease.Size = new System.Drawing.Size(191, 21);
            this.ChkCboBoxUnmuteRelease.TabIndex = 15;
            this.ChkCboBoxUnmuteRelease.ValueSeparator = ", ";
            // 
            // ChkBoxUnmuteRelease
            // 
            this.ChkBoxUnmuteRelease.AutoSize = true;
            this.ChkBoxUnmuteRelease.Location = new System.Drawing.Point(276, 52);
            this.ChkBoxUnmuteRelease.Name = "ChkBoxUnmuteRelease";
            this.ChkBoxUnmuteRelease.Size = new System.Drawing.Size(64, 17);
            this.ChkBoxUnmuteRelease.TabIndex = 14;
            this.ChkBoxUnmuteRelease.Text = "UnMute";
            this.ChkBoxUnmuteRelease.UseVisualStyleBackColor = true;
            this.ChkBoxUnmuteRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // TabSoundRelease
            // 
            this.TabSoundRelease.Controls.Add(this.ChkBoxAudioStop);
            this.TabSoundRelease.Location = new System.Drawing.Point(4, 22);
            this.TabSoundRelease.Name = "TabSoundRelease";
            this.TabSoundRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabSoundRelease.Size = new System.Drawing.Size(560, 211);
            this.TabSoundRelease.TabIndex = 1;
            this.TabSoundRelease.Text = "SoundBoard";
            this.TabSoundRelease.UseVisualStyleBackColor = true;
            // 
            // ChkBoxAudioStop
            // 
            this.ChkBoxAudioStop.AutoSize = true;
            this.ChkBoxAudioStop.Enabled = false;
            this.ChkBoxAudioStop.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxAudioStop.Name = "ChkBoxAudioStop";
            this.ChkBoxAudioStop.Size = new System.Drawing.Size(159, 17);
            this.ChkBoxAudioStop.TabIndex = 0;
            this.ChkBoxAudioStop.Text = "Stop Sound when Released";
            this.ChkBoxAudioStop.UseVisualStyleBackColor = true;
            // 
            // TabMediaKeyRelease
            // 
            this.TabMediaKeyRelease.Controls.Add(this.ChkBoxMediaKeyPreviousRelease);
            this.TabMediaKeyRelease.Controls.Add(this.ChkBoxMediaKeyNextRelease);
            this.TabMediaKeyRelease.Controls.Add(this.ChkBoxMediaKeyPlayRelease);
            this.TabMediaKeyRelease.Location = new System.Drawing.Point(4, 22);
            this.TabMediaKeyRelease.Name = "TabMediaKeyRelease";
            this.TabMediaKeyRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabMediaKeyRelease.Size = new System.Drawing.Size(560, 211);
            this.TabMediaKeyRelease.TabIndex = 3;
            this.TabMediaKeyRelease.Text = "Media Keys";
            this.TabMediaKeyRelease.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyPreviousRelease
            // 
            this.ChkBoxMediaKeyPreviousRelease.AutoSize = true;
            this.ChkBoxMediaKeyPreviousRelease.Location = new System.Drawing.Point(6, 52);
            this.ChkBoxMediaKeyPreviousRelease.Name = "ChkBoxMediaKeyPreviousRelease";
            this.ChkBoxMediaKeyPreviousRelease.Size = new System.Drawing.Size(120, 17);
            this.ChkBoxMediaKeyPreviousRelease.TabIndex = 6;
            this.ChkBoxMediaKeyPreviousRelease.Text = "Previous Media Key";
            this.ChkBoxMediaKeyPreviousRelease.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyNextRelease
            // 
            this.ChkBoxMediaKeyNextRelease.AutoSize = true;
            this.ChkBoxMediaKeyNextRelease.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxMediaKeyNextRelease.Name = "ChkBoxMediaKeyNextRelease";
            this.ChkBoxMediaKeyNextRelease.Size = new System.Drawing.Size(101, 17);
            this.ChkBoxMediaKeyNextRelease.TabIndex = 5;
            this.ChkBoxMediaKeyNextRelease.Text = "Next Media Key";
            this.ChkBoxMediaKeyNextRelease.UseVisualStyleBackColor = true;
            // 
            // ChkBoxMediaKeyPlayRelease
            // 
            this.ChkBoxMediaKeyPlayRelease.AutoSize = true;
            this.ChkBoxMediaKeyPlayRelease.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxMediaKeyPlayRelease.Name = "ChkBoxMediaKeyPlayRelease";
            this.ChkBoxMediaKeyPlayRelease.Size = new System.Drawing.Size(140, 17);
            this.ChkBoxMediaKeyPlayRelease.TabIndex = 4;
            this.ChkBoxMediaKeyPlayRelease.Text = "Play / Pause Media Key";
            this.ChkBoxMediaKeyPlayRelease.UseVisualStyleBackColor = true;
            // 
            // TabTwitchRelease
            // 
            this.TabTwitchRelease.Controls.Add(this.LblTwitchMessageRelease);
            this.TabTwitchRelease.Controls.Add(this.TxtBoxTwitchMessageRelease);
            this.TabTwitchRelease.Controls.Add(this.TxtBoxTwitchChannelRelease);
            this.TabTwitchRelease.Controls.Add(this.LblChannelTwitchRelease);
            this.TabTwitchRelease.Location = new System.Drawing.Point(4, 22);
            this.TabTwitchRelease.Name = "TabTwitchRelease";
            this.TabTwitchRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabTwitchRelease.Size = new System.Drawing.Size(560, 211);
            this.TabTwitchRelease.TabIndex = 4;
            this.TabTwitchRelease.Text = "Twitch Chat";
            this.TabTwitchRelease.UseVisualStyleBackColor = true;
            // 
            // LblTwitchMessageRelease
            // 
            this.LblTwitchMessageRelease.AutoSize = true;
            this.LblTwitchMessageRelease.Location = new System.Drawing.Point(7, 26);
            this.LblTwitchMessageRelease.Name = "LblTwitchMessageRelease";
            this.LblTwitchMessageRelease.Size = new System.Drawing.Size(50, 13);
            this.LblTwitchMessageRelease.TabIndex = 7;
            this.LblTwitchMessageRelease.Text = "Message";
            // 
            // TxtBoxTwitchMessageRelease
            // 
            this.TxtBoxTwitchMessageRelease.Location = new System.Drawing.Point(6, 42);
            this.TxtBoxTwitchMessageRelease.Multiline = true;
            this.TxtBoxTwitchMessageRelease.Name = "TxtBoxTwitchMessageRelease";
            this.TxtBoxTwitchMessageRelease.Size = new System.Drawing.Size(548, 141);
            this.TxtBoxTwitchMessageRelease.TabIndex = 6;
            // 
            // TxtBoxTwitchChannelRelease
            // 
            this.TxtBoxTwitchChannelRelease.Location = new System.Drawing.Point(411, 6);
            this.TxtBoxTwitchChannelRelease.Name = "TxtBoxTwitchChannelRelease";
            this.TxtBoxTwitchChannelRelease.Size = new System.Drawing.Size(143, 20);
            this.TxtBoxTwitchChannelRelease.TabIndex = 5;
            // 
            // LblChannelTwitchRelease
            // 
            this.LblChannelTwitchRelease.AutoSize = true;
            this.LblChannelTwitchRelease.Location = new System.Drawing.Point(324, 9);
            this.LblChannelTwitchRelease.Name = "LblChannelTwitchRelease";
            this.LblChannelTwitchRelease.Size = new System.Drawing.Size(81, 13);
            this.LblChannelTwitchRelease.TabIndex = 4;
            this.LblChannelTwitchRelease.Text = "Twitch Channel";
            // 
            // TabMIDIControlRelease
            // 
            this.TabMIDIControlRelease.Controls.Add(this.CboBoxProfileRelease);
            this.TabMIDIControlRelease.Controls.Add(this.ChkBoxSwitchToProfileRelease);
            this.TabMIDIControlRelease.Controls.Add(this.ChkBoxStopAllSoundRelease);
            this.TabMIDIControlRelease.Location = new System.Drawing.Point(4, 22);
            this.TabMIDIControlRelease.Name = "TabMIDIControlRelease";
            this.TabMIDIControlRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabMIDIControlRelease.Size = new System.Drawing.Size(560, 211);
            this.TabMIDIControlRelease.TabIndex = 5;
            this.TabMIDIControlRelease.Text = "MIDIControl";
            this.TabMIDIControlRelease.UseVisualStyleBackColor = true;
            // 
            // CboBoxProfileRelease
            // 
            this.CboBoxProfileRelease.Enabled = false;
            this.CboBoxProfileRelease.FormattingEnabled = true;
            this.CboBoxProfileRelease.Location = new System.Drawing.Point(118, 25);
            this.CboBoxProfileRelease.Name = "CboBoxProfileRelease";
            this.CboBoxProfileRelease.Size = new System.Drawing.Size(166, 21);
            this.CboBoxProfileRelease.TabIndex = 7;
            // 
            // ChkBoxSwitchToProfileRelease
            // 
            this.ChkBoxSwitchToProfileRelease.AutoSize = true;
            this.ChkBoxSwitchToProfileRelease.Location = new System.Drawing.Point(6, 29);
            this.ChkBoxSwitchToProfileRelease.Name = "ChkBoxSwitchToProfileRelease";
            this.ChkBoxSwitchToProfileRelease.Size = new System.Drawing.Size(106, 17);
            this.ChkBoxSwitchToProfileRelease.TabIndex = 6;
            this.ChkBoxSwitchToProfileRelease.Text = "Switch To Profile";
            this.ChkBoxSwitchToProfileRelease.UseVisualStyleBackColor = true;
            this.ChkBoxSwitchToProfileRelease.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxStopAllSoundRelease
            // 
            this.ChkBoxStopAllSoundRelease.AutoSize = true;
            this.ChkBoxStopAllSoundRelease.Location = new System.Drawing.Point(6, 6);
            this.ChkBoxStopAllSoundRelease.Name = "ChkBoxStopAllSoundRelease";
            this.ChkBoxStopAllSoundRelease.Size = new System.Drawing.Size(101, 17);
            this.ChkBoxStopAllSoundRelease.TabIndex = 4;
            this.ChkBoxStopAllSoundRelease.Text = "Stop All Sounds";
            this.ChkBoxStopAllSoundRelease.UseVisualStyleBackColor = true;
            // 
            // TabGoXLRControlRelease
            // 
            this.TabGoXLRControlRelease.Controls.Add(this.LblXLROutputRelease);
            this.TabGoXLRControlRelease.Controls.Add(this.LblXLRInputRelease);
            this.TabGoXLRControlRelease.Controls.Add(this.PanelXLRRelease);
            this.TabGoXLRControlRelease.Controls.Add(this.CboBoxXLROutputRelease);
            this.TabGoXLRControlRelease.Controls.Add(this.CboBoxXLRInputRelease);
            this.TabGoXLRControlRelease.Location = new System.Drawing.Point(4, 22);
            this.TabGoXLRControlRelease.Name = "TabGoXLRControlRelease";
            this.TabGoXLRControlRelease.Padding = new System.Windows.Forms.Padding(3);
            this.TabGoXLRControlRelease.Size = new System.Drawing.Size(560, 211);
            this.TabGoXLRControlRelease.TabIndex = 6;
            this.TabGoXLRControlRelease.Text = "Go XLR";
            this.TabGoXLRControlRelease.UseVisualStyleBackColor = true;
            // 
            // LblXLROutputRelease
            // 
            this.LblXLROutputRelease.AutoSize = true;
            this.LblXLROutputRelease.Location = new System.Drawing.Point(95, 66);
            this.LblXLROutputRelease.Name = "LblXLROutputRelease";
            this.LblXLROutputRelease.Size = new System.Drawing.Size(39, 13);
            this.LblXLROutputRelease.TabIndex = 18;
            this.LblXLROutputRelease.Text = "Output";
            // 
            // LblXLRInputRelease
            // 
            this.LblXLRInputRelease.AutoSize = true;
            this.LblXLRInputRelease.Location = new System.Drawing.Point(103, 27);
            this.LblXLRInputRelease.Name = "LblXLRInputRelease";
            this.LblXLRInputRelease.Size = new System.Drawing.Size(31, 13);
            this.LblXLRInputRelease.TabIndex = 17;
            this.LblXLRInputRelease.Text = "Input";
            // 
            // PanelXLRRelease
            // 
            this.PanelXLRRelease.Controls.Add(this.RadioButtonUnMuteXLRRelease);
            this.PanelXLRRelease.Controls.Add(this.RadioButtonMuteXLRRelease);
            this.PanelXLRRelease.Controls.Add(this.RadioButtonToggleXLRRelease);
            this.PanelXLRRelease.Controls.Add(this.RadioButtonDisabledXLRRelease);
            this.PanelXLRRelease.Location = new System.Drawing.Point(6, 6);
            this.PanelXLRRelease.Name = "PanelXLRRelease";
            this.PanelXLRRelease.Size = new System.Drawing.Size(71, 97);
            this.PanelXLRRelease.TabIndex = 16;
            // 
            // RadioButtonUnMuteXLRRelease
            // 
            this.RadioButtonUnMuteXLRRelease.AutoSize = true;
            this.RadioButtonUnMuteXLRRelease.Location = new System.Drawing.Point(3, 72);
            this.RadioButtonUnMuteXLRRelease.Name = "RadioButtonUnMuteXLRRelease";
            this.RadioButtonUnMuteXLRRelease.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonUnMuteXLRRelease.TabIndex = 10;
            this.RadioButtonUnMuteXLRRelease.Text = "UnMute";
            this.RadioButtonUnMuteXLRRelease.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMuteXLRRelease
            // 
            this.RadioButtonMuteXLRRelease.AutoSize = true;
            this.RadioButtonMuteXLRRelease.Location = new System.Drawing.Point(3, 49);
            this.RadioButtonMuteXLRRelease.Name = "RadioButtonMuteXLRRelease";
            this.RadioButtonMuteXLRRelease.Size = new System.Drawing.Size(49, 17);
            this.RadioButtonMuteXLRRelease.TabIndex = 9;
            this.RadioButtonMuteXLRRelease.Text = "Mute";
            this.RadioButtonMuteXLRRelease.UseVisualStyleBackColor = true;
            // 
            // RadioButtonToggleXLRRelease
            // 
            this.RadioButtonToggleXLRRelease.AutoSize = true;
            this.RadioButtonToggleXLRRelease.Location = new System.Drawing.Point(3, 26);
            this.RadioButtonToggleXLRRelease.Name = "RadioButtonToggleXLRRelease";
            this.RadioButtonToggleXLRRelease.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonToggleXLRRelease.TabIndex = 8;
            this.RadioButtonToggleXLRRelease.Text = "Toggle";
            this.RadioButtonToggleXLRRelease.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDisabledXLRRelease
            // 
            this.RadioButtonDisabledXLRRelease.AutoSize = true;
            this.RadioButtonDisabledXLRRelease.Checked = true;
            this.RadioButtonDisabledXLRRelease.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonDisabledXLRRelease.Name = "RadioButtonDisabledXLRRelease";
            this.RadioButtonDisabledXLRRelease.Size = new System.Drawing.Size(66, 17);
            this.RadioButtonDisabledXLRRelease.TabIndex = 7;
            this.RadioButtonDisabledXLRRelease.TabStop = true;
            this.RadioButtonDisabledXLRRelease.Text = "Disabled";
            this.RadioButtonDisabledXLRRelease.UseVisualStyleBackColor = true;
            // 
            // CboBoxXLROutputRelease
            // 
            this.CboBoxXLROutputRelease.FormattingEnabled = true;
            this.CboBoxXLROutputRelease.Location = new System.Drawing.Point(140, 63);
            this.CboBoxXLROutputRelease.Name = "CboBoxXLROutputRelease";
            this.CboBoxXLROutputRelease.Size = new System.Drawing.Size(121, 21);
            this.CboBoxXLROutputRelease.TabIndex = 11;
            // 
            // CboBoxXLRInputRelease
            // 
            this.CboBoxXLRInputRelease.FormattingEnabled = true;
            this.CboBoxXLRInputRelease.Location = new System.Drawing.Point(140, 24);
            this.CboBoxXLRInputRelease.Name = "CboBoxXLRInputRelease";
            this.CboBoxXLRInputRelease.Size = new System.Drawing.Size(121, 21);
            this.CboBoxXLRInputRelease.TabIndex = 10;
            // 
            // tabLaunchProgramKeyRelease
            // 
            this.tabLaunchProgramKeyRelease.Controls.Add(this.ChkBoxHideProgramRelease);
            this.tabLaunchProgramKeyRelease.Controls.Add(this.lblArgsRelease);
            this.tabLaunchProgramKeyRelease.Controls.Add(this.TxtBoxArgsRelease);
            this.tabLaunchProgramKeyRelease.Controls.Add(this.lblFileRelease);
            this.tabLaunchProgramKeyRelease.Controls.Add(this.BtnProgramSelectRelease);
            this.tabLaunchProgramKeyRelease.Controls.Add(this.TxtBoxProgramRelease);
            this.tabLaunchProgramKeyRelease.Location = new System.Drawing.Point(4, 22);
            this.tabLaunchProgramKeyRelease.Name = "tabLaunchProgramKeyRelease";
            this.tabLaunchProgramKeyRelease.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaunchProgramKeyRelease.Size = new System.Drawing.Size(560, 211);
            this.tabLaunchProgramKeyRelease.TabIndex = 7;
            this.tabLaunchProgramKeyRelease.Text = "Launch Program";
            this.tabLaunchProgramKeyRelease.UseVisualStyleBackColor = true;
            // 
            // ChkBoxHideProgramRelease
            // 
            this.ChkBoxHideProgramRelease.AutoSize = true;
            this.ChkBoxHideProgramRelease.Location = new System.Drawing.Point(5, 58);
            this.ChkBoxHideProgramRelease.Name = "ChkBoxHideProgramRelease";
            this.ChkBoxHideProgramRelease.Size = new System.Drawing.Size(141, 17);
            this.ChkBoxHideProgramRelease.TabIndex = 11;
            this.ChkBoxHideProgramRelease.Text = "Hide Launched Program";
            this.ChkBoxHideProgramRelease.UseVisualStyleBackColor = true;
            // 
            // lblArgsRelease
            // 
            this.lblArgsRelease.AutoSize = true;
            this.lblArgsRelease.Location = new System.Drawing.Point(2, 35);
            this.lblArgsRelease.Name = "lblArgsRelease";
            this.lblArgsRelease.Size = new System.Drawing.Size(57, 13);
            this.lblArgsRelease.TabIndex = 10;
            this.lblArgsRelease.Text = "Arguments";
            // 
            // TxtBoxArgsRelease
            // 
            this.TxtBoxArgsRelease.Location = new System.Drawing.Point(65, 32);
            this.TxtBoxArgsRelease.Name = "TxtBoxArgsRelease";
            this.TxtBoxArgsRelease.Size = new System.Drawing.Size(218, 20);
            this.TxtBoxArgsRelease.TabIndex = 9;
            // 
            // lblFileRelease
            // 
            this.lblFileRelease.AutoSize = true;
            this.lblFileRelease.Location = new System.Drawing.Point(2, 9);
            this.lblFileRelease.Name = "lblFileRelease";
            this.lblFileRelease.Size = new System.Drawing.Size(23, 13);
            this.lblFileRelease.TabIndex = 8;
            this.lblFileRelease.Text = "File";
            // 
            // BtnProgramSelectRelease
            // 
            this.BtnProgramSelectRelease.Location = new System.Drawing.Point(478, 4);
            this.BtnProgramSelectRelease.Name = "BtnProgramSelectRelease";
            this.BtnProgramSelectRelease.Size = new System.Drawing.Size(75, 23);
            this.BtnProgramSelectRelease.TabIndex = 7;
            this.BtnProgramSelectRelease.Text = "Browse ...";
            this.BtnProgramSelectRelease.UseVisualStyleBackColor = true;
            this.BtnProgramSelectRelease.Click += new System.EventHandler(this.BtnProgramSelectRelease_Click);
            // 
            // TxtBoxProgramRelease
            // 
            this.TxtBoxProgramRelease.Location = new System.Drawing.Point(65, 6);
            this.TxtBoxProgramRelease.Name = "TxtBoxProgramRelease";
            this.TxtBoxProgramRelease.Size = new System.Drawing.Size(407, 20);
            this.TxtBoxProgramRelease.TabIndex = 6;
            // 
            // GrpBoxKeySlider
            // 
            this.GrpBoxKeySlider.Controls.Add(this.TabKeySlider);
            this.GrpBoxKeySlider.Location = new System.Drawing.Point(9, 577);
            this.GrpBoxKeySlider.Name = "GrpBoxKeySlider";
            this.GrpBoxKeySlider.Size = new System.Drawing.Size(579, 113);
            this.GrpBoxKeySlider.TabIndex = 13;
            this.GrpBoxKeySlider.TabStop = false;
            this.GrpBoxKeySlider.Text = "On Slider Change";
            // 
            // TabKeySlider
            // 
            this.TabKeySlider.Controls.Add(this.TabOBSSlider);
            this.TabKeySlider.Location = new System.Drawing.Point(6, 19);
            this.TabKeySlider.Name = "TabKeySlider";
            this.TabKeySlider.SelectedIndex = 0;
            this.TabKeySlider.Size = new System.Drawing.Size(563, 88);
            this.TabKeySlider.TabIndex = 2;
            // 
            // TabOBSSlider
            // 
            this.TabOBSSlider.Controls.Add(this.CboBoxFilterSettingSlider);
            this.TabOBSSlider.Controls.Add(this.CboBoxFilterNameSlider);
            this.TabOBSSlider.Controls.Add(this.ChkBoxAdjustFilter);
            this.TabOBSSlider.Controls.Add(this.ChkBoxSlideTransition);
            this.TabOBSSlider.Controls.Add(this.ChkBoxAdjustTransitionDuration);
            this.TabOBSSlider.Controls.Add(this.ChkBoxAdjustVolume);
            this.TabOBSSlider.Controls.Add(this.ChkCboBoxVolumeSlider);
            this.TabOBSSlider.Location = new System.Drawing.Point(4, 22);
            this.TabOBSSlider.Name = "TabOBSSlider";
            this.TabOBSSlider.Padding = new System.Windows.Forms.Padding(3);
            this.TabOBSSlider.Size = new System.Drawing.Size(555, 62);
            this.TabOBSSlider.TabIndex = 0;
            this.TabOBSSlider.Text = "OBS";
            this.TabOBSSlider.UseVisualStyleBackColor = true;
            // 
            // CboBoxFilterSettingSlider
            // 
            this.CboBoxFilterSettingSlider.Enabled = false;
            this.CboBoxFilterSettingSlider.FormattingEnabled = true;
            this.CboBoxFilterSettingSlider.IntegralHeight = false;
            this.CboBoxFilterSettingSlider.Location = new System.Drawing.Point(290, 35);
            this.CboBoxFilterSettingSlider.Name = "CboBoxFilterSettingSlider";
            this.CboBoxFilterSettingSlider.Size = new System.Drawing.Size(259, 21);
            this.CboBoxFilterSettingSlider.TabIndex = 41;
            // 
            // CboBoxFilterNameSlider
            // 
            this.CboBoxFilterNameSlider.Enabled = false;
            this.CboBoxFilterNameSlider.FormattingEnabled = true;
            this.CboBoxFilterNameSlider.Location = new System.Drawing.Point(98, 35);
            this.CboBoxFilterNameSlider.Name = "CboBoxFilterNameSlider";
            this.CboBoxFilterNameSlider.Size = new System.Drawing.Size(186, 21);
            this.CboBoxFilterNameSlider.TabIndex = 40;
            this.CboBoxFilterNameSlider.SelectionChangeCommitted += new System.EventHandler(this.CboBoxFilterNameSlider_SelectionChangeCommitted);
            // 
            // ChkBoxAdjustFilter
            // 
            this.ChkBoxAdjustFilter.AutoSize = true;
            this.ChkBoxAdjustFilter.Location = new System.Drawing.Point(6, 37);
            this.ChkBoxAdjustFilter.Name = "ChkBoxAdjustFilter";
            this.ChkBoxAdjustFilter.Size = new System.Drawing.Size(80, 17);
            this.ChkBoxAdjustFilter.TabIndex = 4;
            this.ChkBoxAdjustFilter.Text = "Adjust Filter";
            this.ChkBoxAdjustFilter.UseVisualStyleBackColor = true;
            this.ChkBoxAdjustFilter.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxSlideTransition
            // 
            this.ChkBoxSlideTransition.AutoSize = true;
            this.ChkBoxSlideTransition.Location = new System.Drawing.Point(417, 8);
            this.ChkBoxSlideTransition.Name = "ChkBoxSlideTransition";
            this.ChkBoxSlideTransition.Size = new System.Drawing.Size(135, 17);
            this.ChkBoxSlideTransition.TabIndex = 3;
            this.ChkBoxSlideTransition.Text = "Slide Current Transition";
            this.ChkBoxSlideTransition.UseVisualStyleBackColor = true;
            this.ChkBoxSlideTransition.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkBoxAdjustTransitionDuration
            // 
            this.ChkBoxAdjustTransitionDuration.AutoSize = true;
            this.ChkBoxAdjustTransitionDuration.Location = new System.Drawing.Point(273, 8);
            this.ChkBoxAdjustTransitionDuration.Name = "ChkBoxAdjustTransitionDuration";
            this.ChkBoxAdjustTransitionDuration.Size = new System.Drawing.Size(147, 17);
            this.ChkBoxAdjustTransitionDuration.TabIndex = 2;
            this.ChkBoxAdjustTransitionDuration.Text = "Adjust Transition Duration";
            this.ChkBoxAdjustTransitionDuration.UseVisualStyleBackColor = true;
            // 
            // ChkBoxAdjustVolume
            // 
            this.ChkBoxAdjustVolume.AutoSize = true;
            this.ChkBoxAdjustVolume.Location = new System.Drawing.Point(6, 8);
            this.ChkBoxAdjustVolume.Name = "ChkBoxAdjustVolume";
            this.ChkBoxAdjustVolume.Size = new System.Drawing.Size(93, 17);
            this.ChkBoxAdjustVolume.TabIndex = 0;
            this.ChkBoxAdjustVolume.Text = "Adjust Volume";
            this.ChkBoxAdjustVolume.UseVisualStyleBackColor = true;
            this.ChkBoxAdjustVolume.CheckedChanged += new System.EventHandler(this.ChkBox_State);
            // 
            // ChkCboBoxVolumeSlider
            // 
            this.ChkCboBoxVolumeSlider.CheckOnClick = true;
            this.ChkCboBoxVolumeSlider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ChkCboBoxVolumeSlider.DropDownHeight = 1;
            this.ChkCboBoxVolumeSlider.Enabled = false;
            this.ChkCboBoxVolumeSlider.FormattingEnabled = true;
            this.ChkCboBoxVolumeSlider.IntegralHeight = false;
            this.ChkCboBoxVolumeSlider.Location = new System.Drawing.Point(99, 6);
            this.ChkCboBoxVolumeSlider.Name = "ChkCboBoxVolumeSlider";
            this.ChkCboBoxVolumeSlider.Size = new System.Drawing.Size(168, 21);
            this.ChkCboBoxVolumeSlider.TabIndex = 1;
            this.ChkCboBoxVolumeSlider.ValueSeparator = ", ";
            // 
            // EntryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 731);
            this.Controls.Add(this.GrpBoxKeySlider);
            this.Controls.Add(this.GrpBoxKeyRelease);
            this.Controls.Add(this.GrpBoxKeyPress);
            this.Controls.Add(this.TxtBoxChannel);
            this.Controls.Add(this.LblChannel);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.TxtBoxDevice);
            this.Controls.Add(this.LblDevice);
            this.Controls.Add(this.TxtBoxNote);
            this.Controls.Add(this.LblNote);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.LblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryGUI";
            this.Text = "Add MIDI Keybind";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryGUI_FormClosing);
            this.GrpBoxKeyPress.ResumeLayout(false);
            this.TabKeyPress.ResumeLayout(false);
            this.TabOBSPress.ResumeLayout(false);
            this.TabOBSPress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTransitionPress)).EndInit();
            this.TabSoundPress.ResumeLayout(false);
            this.TabSoundPress.PerformLayout();
            this.TabMediaKeyPress.ResumeLayout(false);
            this.TabMediaKeyPress.PerformLayout();
            this.TabTwitchPress.ResumeLayout(false);
            this.TabTwitchPress.PerformLayout();
            this.TabMIDIControlPress.ResumeLayout(false);
            this.TabMIDIControlPress.PerformLayout();
            this.TabGoXLRControlPress.ResumeLayout(false);
            this.TabGoXLRControlPress.PerformLayout();
            this.PanelXLRPress.ResumeLayout(false);
            this.PanelXLRPress.PerformLayout();
            this.tabLaunchProgramKeyPress.ResumeLayout(false);
            this.tabLaunchProgramKeyPress.PerformLayout();
            this.GrpBoxKeyRelease.ResumeLayout(false);
            this.TabKeyRelease.ResumeLayout(false);
            this.TabOBSRelease.ResumeLayout(false);
            this.TabOBSRelease.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTransitionRelease)).EndInit();
            this.TabSoundRelease.ResumeLayout(false);
            this.TabSoundRelease.PerformLayout();
            this.TabMediaKeyRelease.ResumeLayout(false);
            this.TabMediaKeyRelease.PerformLayout();
            this.TabTwitchRelease.ResumeLayout(false);
            this.TabTwitchRelease.PerformLayout();
            this.TabMIDIControlRelease.ResumeLayout(false);
            this.TabMIDIControlRelease.PerformLayout();
            this.TabGoXLRControlRelease.ResumeLayout(false);
            this.TabGoXLRControlRelease.PerformLayout();
            this.PanelXLRRelease.ResumeLayout(false);
            this.PanelXLRRelease.PerformLayout();
            this.tabLaunchProgramKeyRelease.ResumeLayout(false);
            this.tabLaunchProgramKeyRelease.PerformLayout();
            this.GrpBoxKeySlider.ResumeLayout(false);
            this.TabKeySlider.ResumeLayout(false);
            this.TabOBSSlider.ResumeLayout(false);
            this.TabOBSSlider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label LblNote;
        public System.Windows.Forms.TextBox TxtBoxNote;
        public System.Windows.Forms.TextBox TxtBoxDevice;
        private System.Windows.Forms.Label LblDevice;
        private System.Windows.Forms.Button BtnAdd;
        public System.Windows.Forms.TextBox TxtBoxChannel;
        private System.Windows.Forms.Label LblChannel;
        private System.Windows.Forms.GroupBox GrpBoxKeyPress;
        private System.Windows.Forms.GroupBox GrpBoxKeyRelease;
        private System.Windows.Forms.TabControl TabKeyPress;
        private System.Windows.Forms.TabPage TabOBSPress;
        private System.Windows.Forms.TabPage TabSoundPress;
        private System.Windows.Forms.TabControl TabKeyRelease;
        private System.Windows.Forms.TabPage TabOBSRelease;
        private System.Windows.Forms.TabPage TabSoundRelease;
        private System.Windows.Forms.CheckBox ChkBoxSwitchScenePress;
        private System.Windows.Forms.ComboBox CboBoxSwitchScenePress;
        private System.Windows.Forms.CheckBox ChkBoxMutePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMutePress;
        private System.Windows.Forms.CheckBox ChkBoxUnmutePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxUnmutePress;
        private System.Windows.Forms.CheckBox ChkBoxHideSourcePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHidePress;
        private System.Windows.Forms.CheckBox ChkBoxShowSourcePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxShowPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHideRelease;
        private System.Windows.Forms.CheckBox ChkBoxSwitchSceneRelease;
        private System.Windows.Forms.CheckBox ChkBoxHideSourceRelease;
        private System.Windows.Forms.ComboBox CboBoxSwitchSceneRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxShowRelease;
        private System.Windows.Forms.CheckBox ChkBoxMuteRelease;
        private System.Windows.Forms.CheckBox ChkBoxShowSourceRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMuteRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxUnmuteRelease;
        private System.Windows.Forms.CheckBox ChkBoxUnmuteRelease;
        private System.Windows.Forms.Button BtnAudioSelect;
        private System.Windows.Forms.TextBox TxtBoxAudioFile;
        private System.Windows.Forms.CheckBox ChkBoxAudioStop;
        private System.Windows.Forms.CheckBox ChkBoxEnableAudio;
        private System.Windows.Forms.ComboBox CboBoxAudioDevice;
        private System.Windows.Forms.Label LblAudioDevice;
        private System.Windows.Forms.Label LblAudioFile;
        private System.Windows.Forms.CheckBox chkBoxLoop;
        private NAudio.Gui.VolumeSlider volumeSlider;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.NumericUpDown NumericTransitionPress;
        private System.Windows.Forms.ComboBox CboBoxTransitionPress;
        private System.Windows.Forms.CheckBox ChkBoxTransitionPress;
        private System.Windows.Forms.CheckBox ChkBoxTransitionRelease;
        private System.Windows.Forms.NumericUpDown NumericTransitionRelease;
        private System.Windows.Forms.ComboBox CboBoxTransitionRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleSourcePress;
        private System.Windows.Forms.CheckBox ChkBoxToggleSourcePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleMutePress;
        private System.Windows.Forms.CheckBox ChkBoxTogglemutePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleSourceRelease;
        private System.Windows.Forms.CheckBox ChkBoxToggleSourceRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleMuteRelease;
        private System.Windows.Forms.CheckBox ChkBoxTogglemuteRelease;
        private System.Windows.Forms.GroupBox GrpBoxKeySlider;
        private System.Windows.Forms.TabControl TabKeySlider;
        private System.Windows.Forms.TabPage TabOBSSlider;
        private System.Windows.Forms.CheckBox ChkBoxAdjustVolume;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxVolumeSlider;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleFilterPress;
        private System.Windows.Forms.CheckBox ChkBoxToggleFilterPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxShowFilterPress;
        private System.Windows.Forms.CheckBox ChkBoxShowFilterPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHideFilterPress;
        private System.Windows.Forms.CheckBox ChkBoxHideFilterPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxToggleFilterRelease;
        private System.Windows.Forms.CheckBox ChkBoxToggleFilterRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxShowFilterRelease;
        private System.Windows.Forms.CheckBox ChkBoxShowFilterRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHideFilterRelease;
        private System.Windows.Forms.CheckBox ChkBoxHideFilterRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMiscPress;
        private System.Windows.Forms.CheckBox ChkBoxMiscPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMiscRelease;
        private System.Windows.Forms.CheckBox ChkBoxMiscRelease;
        private System.Windows.Forms.CheckBox ChkBoxAdjustTransitionDuration;
        private System.Windows.Forms.CheckBox ChkBoxSlideTransition;
        private System.Windows.Forms.ComboBox CboBoxPreviewScenePress;
        private System.Windows.Forms.CheckBox ChkBoxPreviewScenePress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaStopPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaStopPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaRestartPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaRestartPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaPlayPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaPlayPress;
        private System.Windows.Forms.ComboBox CboBoxPreviewSceneRelease;
        private System.Windows.Forms.CheckBox ChkBoxPreviewSceneRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaStopRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaStopRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaRestartRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaRestartRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxMediaPlayRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaPlayRelease;
        private System.Windows.Forms.TabPage TabMediaKeyPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyPlayPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyPreviousPress;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyNextPress;
        private System.Windows.Forms.CheckBox ChkBoxAdjustFilter;
        private System.Windows.Forms.ComboBox CboBoxFilterSettingSlider;
        private System.Windows.Forms.ComboBox CboBoxFilterNameSlider;
        private System.Windows.Forms.TabPage TabMediaKeyRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyPreviousRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyNextRelease;
        private System.Windows.Forms.CheckBox ChkBoxMediaKeyPlayRelease;
        private System.Windows.Forms.TabPage TabTwitchPress;
        private System.Windows.Forms.TabPage TabTwitchRelease;
        private System.Windows.Forms.TextBox TxtBoxTwitchChannelPress;
        private System.Windows.Forms.Label LblChannelTwitchPress;
        private System.Windows.Forms.Label LblTwitchMessagePress;
        private System.Windows.Forms.TextBox TxtBoxTwitchMessagePress;
        private System.Windows.Forms.Label LblTwitchMessageRelease;
        private System.Windows.Forms.TextBox TxtBoxTwitchMessageRelease;
        private System.Windows.Forms.TextBox TxtBoxTwitchChannelRelease;
        private System.Windows.Forms.Label LblChannelTwitchRelease;
        private System.Windows.Forms.TabPage TabMIDIControlPress;
        private System.Windows.Forms.CheckBox ChkBoxStopAllSoundPress;
        private System.Windows.Forms.TabPage TabMIDIControlRelease;
        private System.Windows.Forms.CheckBox ChkBoxStopAllSoundRelease;
        private System.Windows.Forms.CheckBox ChkBoxSwitchToProfilePress;
        private System.Windows.Forms.CheckBox ChkBoxSwitchToProfileRelease;
        private System.Windows.Forms.ComboBox CboBoxProfilePress;
        private System.Windows.Forms.ComboBox CboBoxProfileRelease;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHotkeyPress;
        private System.Windows.Forms.CheckBox ChkBoxHotkeyPress;
        private CheckComboBoxTest.CheckedComboBox ChkCboBoxHotkeyRelease;
        private System.Windows.Forms.CheckBox ChkBoxHotkeyRelease;
        private System.Windows.Forms.TabPage TabGoXLRControlPress;
        private System.Windows.Forms.ComboBox CboBoxXLROutputPress;
        private System.Windows.Forms.ComboBox CboBoxXLRInputPress;
        private System.Windows.Forms.TabPage TabGoXLRControlRelease;
        private System.Windows.Forms.ComboBox CboBoxXLROutputRelease;
        private System.Windows.Forms.ComboBox CboBoxXLRInputRelease;
        private System.Windows.Forms.Panel PanelXLRPress;
        private System.Windows.Forms.RadioButton RadioButtonDisabledXLRPress;
        private System.Windows.Forms.RadioButton RadioButtonUnMuteXLRPress;
        private System.Windows.Forms.RadioButton RadioButtonMuteXLRPress;
        private System.Windows.Forms.RadioButton RadioButtonToggleXLRPress;
        private System.Windows.Forms.Panel PanelXLRRelease;
        private System.Windows.Forms.RadioButton RadioButtonUnMuteXLRRelease;
        private System.Windows.Forms.RadioButton RadioButtonMuteXLRRelease;
        private System.Windows.Forms.RadioButton RadioButtonToggleXLRRelease;
        private System.Windows.Forms.RadioButton RadioButtonDisabledXLRRelease;
        private System.Windows.Forms.Label LblXLROutputPress;
        private System.Windows.Forms.Label LblXLRInputPress;
        private System.Windows.Forms.Label LblXLROutputRelease;
        private System.Windows.Forms.Label LblXLRInputRelease;
		private System.Windows.Forms.CheckBox chkStopAllOthers;
        private System.Windows.Forms.TabPage tabLaunchProgramKeyPress;
        private System.Windows.Forms.TabPage tabLaunchProgramKeyRelease;
        private System.Windows.Forms.Label lblArgsPress;
        private System.Windows.Forms.TextBox TxtBoxArgsPress;
        private System.Windows.Forms.Label lblFilePress;
        private System.Windows.Forms.Button BtnProgramSelectPress;
        private System.Windows.Forms.TextBox TxtBoxProgramPress;
        private System.Windows.Forms.Label lblArgsRelease;
        private System.Windows.Forms.TextBox TxtBoxArgsRelease;
        private System.Windows.Forms.Label lblFileRelease;
        private System.Windows.Forms.Button BtnProgramSelectRelease;
        private System.Windows.Forms.TextBox TxtBoxProgramRelease;
        private System.Windows.Forms.CheckBox ChkBoxHideProgramRelease;
        private System.Windows.Forms.CheckBox ChkBoxHideProgramPress;
    }
}