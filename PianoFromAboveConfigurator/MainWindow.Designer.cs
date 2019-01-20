namespace PianoFromAboveConfigurator
{
    partial class MainWindow
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.settings = new System.Windows.Forms.TabPage();
            this.ScanMIDIDev = new System.Windows.Forms.Button();
            this.ForceSave = new System.Windows.Forms.Button();
            this.NoteSpeedValue = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.LibraryPanel = new System.Windows.Forms.CheckBox();
            this.NoteLabels = new System.Windows.Forms.CheckBox();
            this.ShowKeyboard = new System.Windows.Forms.CheckBox();
            this.MIDIDevicesListIN = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.MIDIDevicesListOUT = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.SpeedUpValue = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.AdvanceValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowFPS = new System.Windows.Forms.CheckBox();
            this.LockFPS = new System.Windows.Forms.CheckBox();
            this.FullScreenControls = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HLabel = new System.Windows.Forms.Label();
            this.HKey = new System.Windows.Forms.NumericUpDown();
            this.LLabel = new System.Windows.Forms.Label();
            this.LKey = new System.Windows.Forms.NumericUpDown();
            this.keysCustom = new System.Windows.Forms.RadioButton();
            this.keysSong = new System.Windows.Forms.RadioButton();
            this.keys88 = new System.Windows.Forms.RadioButton();
            this.keys128 = new System.Windows.Forms.RadioButton();
            this.colors = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.C16 = new System.Windows.Forms.Panel();
            this.C15 = new System.Windows.Forms.Panel();
            this.C14 = new System.Windows.Forms.Panel();
            this.C13 = new System.Windows.Forms.Panel();
            this.C12 = new System.Windows.Forms.Panel();
            this.C11 = new System.Windows.Forms.Panel();
            this.C10 = new System.Windows.Forms.Panel();
            this.C9 = new System.Windows.Forms.Panel();
            this.C8 = new System.Windows.Forms.Panel();
            this.C7 = new System.Windows.Forms.Panel();
            this.C6 = new System.Windows.Forms.Panel();
            this.C5 = new System.Windows.Forms.Panel();
            this.C4 = new System.Windows.Forms.Panel();
            this.C3 = new System.Windows.Forms.Panel();
            this.C2 = new System.Windows.Forms.Panel();
            this.C1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NoPFATimer = new System.Windows.Forms.Timer(this.components);
            this.SelectColor = new System.Windows.Forms.ColorDialog();
            this.ImportXML = new System.Windows.Forms.Button();
            this.ExportXML = new System.Windows.Forms.Button();
            this.ExportConfig = new System.Windows.Forms.SaveFileDialog();
            this.ImportConfig = new System.Windows.Forms.OpenFileDialog();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.RandomColorsButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteSpeedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceValue)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKey)).BeginInit();
            this.colors.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.settings);
            this.Tabs.Controls.Add(this.colors);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tabs.Location = new System.Drawing.Point(0, 65);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(555, 215);
            this.Tabs.TabIndex = 0;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.ScanMIDIDev);
            this.settings.Controls.Add(this.ForceSave);
            this.settings.Controls.Add(this.NoteSpeedValue);
            this.settings.Controls.Add(this.label30);
            this.settings.Controls.Add(this.LibraryPanel);
            this.settings.Controls.Add(this.NoteLabels);
            this.settings.Controls.Add(this.ShowKeyboard);
            this.settings.Controls.Add(this.MIDIDevicesListIN);
            this.settings.Controls.Add(this.label25);
            this.settings.Controls.Add(this.MIDIDevicesListOUT);
            this.settings.Controls.Add(this.label24);
            this.settings.Controls.Add(this.label22);
            this.settings.Controls.Add(this.SpeedUpValue);
            this.settings.Controls.Add(this.label23);
            this.settings.Controls.Add(this.label21);
            this.settings.Controls.Add(this.AdvanceValue);
            this.settings.Controls.Add(this.label1);
            this.settings.Controls.Add(this.ShowFPS);
            this.settings.Controls.Add(this.LockFPS);
            this.settings.Controls.Add(this.FullScreenControls);
            this.settings.Controls.Add(this.label3);
            this.settings.Controls.Add(this.panel1);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(547, 189);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // ScanMIDIDev
            // 
            this.ScanMIDIDev.Location = new System.Drawing.Point(340, 158);
            this.ScanMIDIDev.Name = "ScanMIDIDev";
            this.ScanMIDIDev.Size = new System.Drawing.Size(118, 23);
            this.ScanMIDIDev.TabIndex = 22;
            this.ScanMIDIDev.Text = "Rescan MIDI devices";
            this.ScanMIDIDev.UseVisualStyleBackColor = true;
            this.ScanMIDIDev.Click += new System.EventHandler(this.ScanMIDIDev_Click);
            // 
            // ForceSave
            // 
            this.ForceSave.Location = new System.Drawing.Point(464, 158);
            this.ForceSave.Name = "ForceSave";
            this.ForceSave.Size = new System.Drawing.Size(75, 23);
            this.ForceSave.TabIndex = 21;
            this.ForceSave.Text = "Force save";
            this.ForceSave.UseVisualStyleBackColor = true;
            this.ForceSave.Click += new System.EventHandler(this.ForceSave_Click);
            // 
            // NoteSpeedValue
            // 
            this.NoteSpeedValue.DecimalPlaces = 3;
            this.NoteSpeedValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.NoteSpeedValue.Location = new System.Drawing.Point(453, 80);
            this.NoteSpeedValue.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.NoteSpeedValue.Name = "NoteSpeedValue";
            this.NoteSpeedValue.Size = new System.Drawing.Size(86, 20);
            this.NoteSpeedValue.TabIndex = 20;
            this.NoteSpeedValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NoteSpeedValue.ValueChanged += new System.EventHandler(this.NoteSpeedValue_ValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(382, 82);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(65, 13);
            this.label30.TabIndex = 19;
            this.label30.Text = "Note speed:";
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.AutoSize = true;
            this.LibraryPanel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LibraryPanel.Location = new System.Drawing.Point(433, 57);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(86, 17);
            this.LibraryPanel.TabIndex = 17;
            this.LibraryPanel.Text = "Library panel";
            this.LibraryPanel.UseVisualStyleBackColor = true;
            this.LibraryPanel.CheckedChanged += new System.EventHandler(this.LibraryPanel_CheckedChanged);
            // 
            // NoteLabels
            // 
            this.NoteLabels.AutoSize = true;
            this.NoteLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NoteLabels.Location = new System.Drawing.Point(340, 57);
            this.NoteLabels.Name = "NoteLabels";
            this.NoteLabels.Size = new System.Drawing.Size(79, 17);
            this.NoteLabels.TabIndex = 16;
            this.NoteLabels.Text = "Note labels";
            this.NoteLabels.UseVisualStyleBackColor = true;
            this.NoteLabels.CheckedChanged += new System.EventHandler(this.NoteLabels_CheckedChanged);
            // 
            // ShowKeyboard
            // 
            this.ShowKeyboard.AutoSize = true;
            this.ShowKeyboard.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowKeyboard.Location = new System.Drawing.Point(227, 57);
            this.ShowKeyboard.Name = "ShowKeyboard";
            this.ShowKeyboard.Size = new System.Drawing.Size(100, 17);
            this.ShowKeyboard.TabIndex = 15;
            this.ShowKeyboard.Text = "Show keyboard";
            this.ShowKeyboard.UseVisualStyleBackColor = true;
            this.ShowKeyboard.CheckedChanged += new System.EventHandler(this.ShowKeyboard_CheckedChanged);
            // 
            // MIDIDevicesListIN
            // 
            this.MIDIDevicesListIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MIDIDevicesListIN.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MIDIDevicesListIN.FormattingEnabled = true;
            this.MIDIDevicesListIN.Items.AddRange(new object[] {
            "(Not implemented yet)"});
            this.MIDIDevicesListIN.Location = new System.Drawing.Point(86, 155);
            this.MIDIDevicesListIN.Name = "MIDIDevicesListIN";
            this.MIDIDevicesListIN.Size = new System.Drawing.Size(232, 21);
            this.MIDIDevicesListIN.TabIndex = 14;
            this.MIDIDevicesListIN.SelectedIndexChanged += new System.EventHandler(this.MIDIDevicesListIN_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(15, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "MIDI in port:";
            // 
            // MIDIDevicesListOUT
            // 
            this.MIDIDevicesListOUT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MIDIDevicesListOUT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MIDIDevicesListOUT.FormattingEnabled = true;
            this.MIDIDevicesListOUT.Location = new System.Drawing.Point(86, 133);
            this.MIDIDevicesListOUT.Name = "MIDIDevicesListOUT";
            this.MIDIDevicesListOUT.Size = new System.Drawing.Size(232, 21);
            this.MIDIDevicesListOUT.TabIndex = 12;
            this.MIDIDevicesListOUT.SelectedIndexChanged += new System.EventHandler(this.MIDIDevicesList_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 136);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "MIDI out port:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(271, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "percent";
            // 
            // SpeedUpValue
            // 
            this.SpeedUpValue.DecimalPlaces = 3;
            this.SpeedUpValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.SpeedUpValue.Location = new System.Drawing.Point(179, 103);
            this.SpeedUpValue.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.SpeedUpValue.Name = "SpeedUpValue";
            this.SpeedUpValue.Size = new System.Drawing.Size(86, 20);
            this.SpeedUpValue.TabIndex = 9;
            this.SpeedUpValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SpeedUpValue.ValueChanged += new System.EventHandler(this.SpeedUpValue_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 105);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(169, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Up and down arrows speed up by:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(271, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "seconds";
            // 
            // AdvanceValue
            // 
            this.AdvanceValue.DecimalPlaces = 3;
            this.AdvanceValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            196608});
            this.AdvanceValue.Location = new System.Drawing.Point(179, 80);
            this.AdvanceValue.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.AdvanceValue.Name = "AdvanceValue";
            this.AdvanceValue.Size = new System.Drawing.Size(86, 20);
            this.AdvanceValue.TabIndex = 6;
            this.AdvanceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdvanceValue.ValueChanged += new System.EventHandler(this.AdvanceValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Left and right arrows advance by:";
            // 
            // ShowFPS
            // 
            this.ShowFPS.AutoSize = true;
            this.ShowFPS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowFPS.Location = new System.Drawing.Point(115, 57);
            this.ShowFPS.Name = "ShowFPS";
            this.ShowFPS.Size = new System.Drawing.Size(100, 17);
            this.ShowFPS.TabIndex = 4;
            this.ShowFPS.Text = "Show framerate";
            this.ShowFPS.UseVisualStyleBackColor = true;
            this.ShowFPS.CheckedChanged += new System.EventHandler(this.ShowFPS_CheckedChanged);
            // 
            // LockFPS
            // 
            this.LockFPS.AutoSize = true;
            this.LockFPS.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LockFPS.Location = new System.Drawing.Point(7, 57);
            this.LockFPS.Name = "LockFPS";
            this.LockFPS.Size = new System.Drawing.Size(97, 17);
            this.LockFPS.TabIndex = 3;
            this.LockFPS.Text = "Lock framerate";
            this.LockFPS.UseVisualStyleBackColor = true;
            this.LockFPS.CheckedChanged += new System.EventHandler(this.LockFPS_CheckedChanged);
            // 
            // FullScreenControls
            // 
            this.FullScreenControls.AutoSize = true;
            this.FullScreenControls.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FullScreenControls.Location = new System.Drawing.Point(7, 9);
            this.FullScreenControls.Name = "FullScreenControls";
            this.FullScreenControls.Size = new System.Drawing.Size(218, 17);
            this.FullScreenControls.TabIndex = 2;
            this.FullScreenControls.Text = "Always show controls in fullscreen mode:";
            this.FullScreenControls.UseVisualStyleBackColor = true;
            this.FullScreenControls.CheckedChanged += new System.EventHandler(this.FullScreenControls_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Show keys:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HLabel);
            this.panel1.Controls.Add(this.HKey);
            this.panel1.Controls.Add(this.LLabel);
            this.panel1.Controls.Add(this.LKey);
            this.panel1.Controls.Add(this.keysCustom);
            this.panel1.Controls.Add(this.keysSong);
            this.panel1.Controls.Add(this.keys88);
            this.panel1.Controls.Add(this.keys128);
            this.panel1.Location = new System.Drawing.Point(76, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 23);
            this.panel1.TabIndex = 0;
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Enabled = false;
            this.HLabel.Location = new System.Drawing.Point(380, 4);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(15, 13);
            this.HLabel.TabIndex = 5;
            this.HLabel.Text = "H";
            // 
            // HKey
            // 
            this.HKey.Enabled = false;
            this.HKey.Location = new System.Drawing.Point(395, 2);
            this.HKey.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.HKey.Name = "HKey";
            this.HKey.Size = new System.Drawing.Size(40, 20);
            this.HKey.TabIndex = 6;
            this.HKey.ValueChanged += new System.EventHandler(this.HKey_ValueChanged);
            // 
            // LLabel
            // 
            this.LLabel.AutoSize = true;
            this.LLabel.Enabled = false;
            this.LLabel.Location = new System.Drawing.Point(319, 4);
            this.LLabel.Name = "LLabel";
            this.LLabel.Size = new System.Drawing.Size(13, 13);
            this.LLabel.TabIndex = 1;
            this.LLabel.Text = "L";
            // 
            // LKey
            // 
            this.LKey.Enabled = false;
            this.LKey.Location = new System.Drawing.Point(332, 2);
            this.LKey.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.LKey.Name = "LKey";
            this.LKey.Size = new System.Drawing.Size(40, 20);
            this.LKey.TabIndex = 4;
            this.LKey.ValueChanged += new System.EventHandler(this.LKey_ValueChanged);
            // 
            // keysCustom
            // 
            this.keysCustom.AutoSize = true;
            this.keysCustom.Location = new System.Drawing.Point(230, 2);
            this.keysCustom.Name = "keysCustom";
            this.keysCustom.Size = new System.Drawing.Size(88, 17);
            this.keysCustom.TabIndex = 3;
            this.keysCustom.TabStop = true;
            this.keysCustom.Text = "Custom keys:";
            this.keysCustom.UseVisualStyleBackColor = true;
            this.keysCustom.CheckedChanged += new System.EventHandler(this.keysCustom_CheckedChanged);
            // 
            // keysSong
            // 
            this.keysSong.AutoSize = true;
            this.keysSong.Location = new System.Drawing.Point(142, 2);
            this.keysSong.Name = "keysSong";
            this.keysSong.Size = new System.Drawing.Size(82, 17);
            this.keysSong.TabIndex = 2;
            this.keysSong.TabStop = true;
            this.keysSong.Text = "Song\'s keys";
            this.keysSong.UseVisualStyleBackColor = true;
            this.keysSong.CheckedChanged += new System.EventHandler(this.keysSong_CheckedChanged);
            // 
            // keys88
            // 
            this.keys88.AutoSize = true;
            this.keys88.Location = new System.Drawing.Point(74, 2);
            this.keys88.Name = "keys88";
            this.keys88.Size = new System.Drawing.Size(62, 17);
            this.keys88.TabIndex = 1;
            this.keys88.TabStop = true;
            this.keys88.Text = "88 keys";
            this.keys88.UseVisualStyleBackColor = true;
            this.keys88.CheckedChanged += new System.EventHandler(this.keys88_CheckedChanged);
            // 
            // keys128
            // 
            this.keys128.AutoSize = true;
            this.keys128.Location = new System.Drawing.Point(0, 2);
            this.keys128.Name = "keys128";
            this.keys128.Size = new System.Drawing.Size(68, 17);
            this.keys128.TabIndex = 0;
            this.keys128.TabStop = true;
            this.keys128.Text = "128 keys";
            this.keys128.UseVisualStyleBackColor = true;
            this.keys128.CheckedChanged += new System.EventHandler(this.keys128_CheckedChanged);
            // 
            // colors
            // 
            this.colors.Controls.Add(this.label19);
            this.colors.Controls.Add(this.label20);
            this.colors.Controls.Add(this.panel2);
            this.colors.Controls.Add(this.panel3);
            this.colors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colors.Location = new System.Drawing.Point(4, 22);
            this.colors.Name = "colors";
            this.colors.Padding = new System.Windows.Forms.Padding(3);
            this.colors.Size = new System.Drawing.Size(547, 189);
            this.colors.TabIndex = 1;
            this.colors.Text = "Colors";
            this.colors.UseVisualStyleBackColor = true;
            this.colors.Click += new System.EventHandler(this.colors_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label19.Location = new System.Drawing.Point(503, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 26);
            this.label19.TabIndex = 18;
            this.label19.Text = "BK";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label20.Location = new System.Drawing.Point(3, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 26);
            this.label20.TabIndex = 17;
            this.label20.Text = "BK";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.C16);
            this.panel2.Controls.Add(this.C15);
            this.panel2.Controls.Add(this.C14);
            this.panel2.Controls.Add(this.C13);
            this.panel2.Controls.Add(this.C12);
            this.panel2.Controls.Add(this.C11);
            this.panel2.Controls.Add(this.C10);
            this.panel2.Controls.Add(this.C9);
            this.panel2.Controls.Add(this.C8);
            this.panel2.Controls.Add(this.C7);
            this.panel2.Controls.Add(this.C6);
            this.panel2.Controls.Add(this.C5);
            this.panel2.Controls.Add(this.C4);
            this.panel2.Controls.Add(this.C3);
            this.panel2.Controls.Add(this.C2);
            this.panel2.Controls.Add(this.C1);
            this.panel2.Location = new System.Drawing.Point(49, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 156);
            this.panel2.TabIndex = 2;
            // 
            // C16
            // 
            this.C16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C16.Dock = System.Windows.Forms.DockStyle.Left;
            this.C16.Location = new System.Drawing.Point(420, 0);
            this.C16.Name = "C16";
            this.C16.Size = new System.Drawing.Size(28, 156);
            this.C16.TabIndex = 17;
            this.C16.Click += new System.EventHandler(this.C16_Click);
            // 
            // C15
            // 
            this.C15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C15.Dock = System.Windows.Forms.DockStyle.Left;
            this.C15.Location = new System.Drawing.Point(392, 0);
            this.C15.Name = "C15";
            this.C15.Size = new System.Drawing.Size(28, 156);
            this.C15.TabIndex = 16;
            this.C15.Click += new System.EventHandler(this.C15_Click);
            // 
            // C14
            // 
            this.C14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C14.Dock = System.Windows.Forms.DockStyle.Left;
            this.C14.Location = new System.Drawing.Point(364, 0);
            this.C14.Name = "C14";
            this.C14.Size = new System.Drawing.Size(28, 156);
            this.C14.TabIndex = 15;
            this.C14.Click += new System.EventHandler(this.C14_Click);
            // 
            // C13
            // 
            this.C13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C13.Dock = System.Windows.Forms.DockStyle.Left;
            this.C13.Location = new System.Drawing.Point(336, 0);
            this.C13.Name = "C13";
            this.C13.Size = new System.Drawing.Size(28, 156);
            this.C13.TabIndex = 14;
            this.C13.Click += new System.EventHandler(this.C13_Click);
            // 
            // C12
            // 
            this.C12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C12.Dock = System.Windows.Forms.DockStyle.Left;
            this.C12.Location = new System.Drawing.Point(308, 0);
            this.C12.Name = "C12";
            this.C12.Size = new System.Drawing.Size(28, 156);
            this.C12.TabIndex = 13;
            this.C12.Click += new System.EventHandler(this.C12_Click);
            // 
            // C11
            // 
            this.C11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C11.Dock = System.Windows.Forms.DockStyle.Left;
            this.C11.Location = new System.Drawing.Point(280, 0);
            this.C11.Name = "C11";
            this.C11.Size = new System.Drawing.Size(28, 156);
            this.C11.TabIndex = 12;
            this.C11.Click += new System.EventHandler(this.C11_Click);
            // 
            // C10
            // 
            this.C10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C10.Dock = System.Windows.Forms.DockStyle.Left;
            this.C10.Location = new System.Drawing.Point(252, 0);
            this.C10.Name = "C10";
            this.C10.Size = new System.Drawing.Size(28, 156);
            this.C10.TabIndex = 11;
            this.C10.Click += new System.EventHandler(this.C10_Click);
            // 
            // C9
            // 
            this.C9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C9.Dock = System.Windows.Forms.DockStyle.Left;
            this.C9.Location = new System.Drawing.Point(224, 0);
            this.C9.Name = "C9";
            this.C9.Size = new System.Drawing.Size(28, 156);
            this.C9.TabIndex = 10;
            this.C9.Click += new System.EventHandler(this.C9_Click);
            // 
            // C8
            // 
            this.C8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C8.Dock = System.Windows.Forms.DockStyle.Left;
            this.C8.Location = new System.Drawing.Point(196, 0);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(28, 156);
            this.C8.TabIndex = 9;
            this.C8.Click += new System.EventHandler(this.C8_Click);
            // 
            // C7
            // 
            this.C7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C7.Dock = System.Windows.Forms.DockStyle.Left;
            this.C7.Location = new System.Drawing.Point(168, 0);
            this.C7.Name = "C7";
            this.C7.Size = new System.Drawing.Size(28, 156);
            this.C7.TabIndex = 8;
            this.C7.Click += new System.EventHandler(this.C7_Click);
            // 
            // C6
            // 
            this.C6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C6.Dock = System.Windows.Forms.DockStyle.Left;
            this.C6.Location = new System.Drawing.Point(140, 0);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(28, 156);
            this.C6.TabIndex = 7;
            this.C6.Click += new System.EventHandler(this.C6_Click);
            // 
            // C5
            // 
            this.C5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C5.Dock = System.Windows.Forms.DockStyle.Left;
            this.C5.Location = new System.Drawing.Point(112, 0);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(28, 156);
            this.C5.TabIndex = 6;
            this.C5.Click += new System.EventHandler(this.C5_Click);
            // 
            // C4
            // 
            this.C4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C4.Dock = System.Windows.Forms.DockStyle.Left;
            this.C4.Location = new System.Drawing.Point(84, 0);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(28, 156);
            this.C4.TabIndex = 5;
            this.C4.Click += new System.EventHandler(this.C4_Click);
            // 
            // C3
            // 
            this.C3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C3.Dock = System.Windows.Forms.DockStyle.Left;
            this.C3.Location = new System.Drawing.Point(56, 0);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(28, 156);
            this.C3.TabIndex = 4;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // C2
            // 
            this.C2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C2.Dock = System.Windows.Forms.DockStyle.Left;
            this.C2.Location = new System.Drawing.Point(28, 0);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(28, 156);
            this.C2.TabIndex = 3;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C1
            // 
            this.C1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.C1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C1.Dock = System.Windows.Forms.DockStyle.Left;
            this.C1.Location = new System.Drawing.Point(0, 0);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(28, 156);
            this.C1.TabIndex = 2;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 26);
            this.panel3.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(466, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 23);
            this.label18.TabIndex = 15;
            this.label18.Text = "16";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(438, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 23);
            this.label17.TabIndex = 14;
            this.label17.Text = "15";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(410, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 23);
            this.label16.TabIndex = 13;
            this.label16.Text = "14";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(382, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "13";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(354, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "12";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(326, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "11";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(298, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "10";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(270, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "9";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(242, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "8";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(214, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "7";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(186, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "6";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(158, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "5";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(130, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(102, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(74, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoPFATimer
            // 
            this.NoPFATimer.Interval = 1;
            this.NoPFATimer.Tick += new System.EventHandler(this.NoPFATimer_Tick);
            // 
            // ImportXML
            // 
            this.ImportXML.Location = new System.Drawing.Point(458, 6);
            this.ImportXML.Name = "ImportXML";
            this.ImportXML.Size = new System.Drawing.Size(92, 23);
            this.ImportXML.TabIndex = 1;
            this.ImportXML.Text = "Import config";
            this.ImportXML.UseVisualStyleBackColor = true;
            this.ImportXML.Click += new System.EventHandler(this.ImportXML_Click);
            // 
            // ExportXML
            // 
            this.ExportXML.Location = new System.Drawing.Point(458, 30);
            this.ExportXML.Name = "ExportXML";
            this.ExportXML.Size = new System.Drawing.Size(92, 23);
            this.ExportXML.TabIndex = 2;
            this.ExportXML.Text = "Export config";
            this.ExportXML.UseVisualStyleBackColor = true;
            this.ExportXML.Click += new System.EventHandler(this.ExportXML_Click);
            // 
            // ExportConfig
            // 
            this.ExportConfig.CreatePrompt = true;
            this.ExportConfig.Filter = "XML configuration file|*.xml";
            this.ExportConfig.RestoreDirectory = true;
            this.ExportConfig.SupportMultiDottedExtensions = true;
            // 
            // ImportConfig
            // 
            this.ImportConfig.FileName = "openFileDialog1";
            this.ImportConfig.Filter = "XML configuration file|*.xml";
            this.ImportConfig.RestoreDirectory = true;
            this.ImportConfig.SupportMultiDottedExtensions = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 42);
            this.label26.TabIndex = 3;
            this.label26.Text = "PFA";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1, 42);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 17);
            this.label27.TabIndex = 4;
            this.label27.Text = "Configurator";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(100, 9);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(358, 69);
            this.label29.TabIndex = 5;
            this.label29.Text = "A remake of the original configurator by KaleidonKep99!\r\n\r\nNow with more function" +
    "s, and a color selector!!!";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RandomColorsButton
            // 
            this.RandomColorsButton.Location = new System.Drawing.Point(458, 54);
            this.RandomColorsButton.Name = "RandomColorsButton";
            this.RandomColorsButton.Size = new System.Drawing.Size(92, 23);
            this.RandomColorsButton.TabIndex = 6;
            this.RandomColorsButton.Text = "Random colors";
            this.RandomColorsButton.UseVisualStyleBackColor = true;
            this.RandomColorsButton.Click += new System.EventHandler(this.RandomColors_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 280);
            this.Controls.Add(this.RandomColorsButton);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.ExportXML);
            this.Controls.Add(this.ImportXML);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piano From Above: Configurator";
            this.Load += new System.EventHandler(this.LoadSys);
            this.Tabs.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteSpeedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKey)).EndInit();
            this.colors.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.NumericUpDown HKey;
        private System.Windows.Forms.Label LLabel;
        private System.Windows.Forms.NumericUpDown LKey;
        private System.Windows.Forms.RadioButton keysCustom;
        private System.Windows.Forms.RadioButton keysSong;
        private System.Windows.Forms.RadioButton keys88;
        private System.Windows.Forms.RadioButton keys128;
        private System.Windows.Forms.TabPage colors;
        private System.Windows.Forms.Timer NoPFATimer;
        private System.Windows.Forms.CheckBox FullScreenControls;
        private System.Windows.Forms.CheckBox ShowFPS;
        private System.Windows.Forms.CheckBox LockFPS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel C16;
        private System.Windows.Forms.Panel C15;
        private System.Windows.Forms.Panel C14;
        private System.Windows.Forms.Panel C13;
        private System.Windows.Forms.Panel C12;
        private System.Windows.Forms.Panel C11;
        private System.Windows.Forms.Panel C10;
        private System.Windows.Forms.Panel C9;
        private System.Windows.Forms.Panel C8;
        private System.Windows.Forms.Panel C7;
        private System.Windows.Forms.Panel C6;
        private System.Windows.Forms.Panel C5;
        private System.Windows.Forms.Panel C4;
        private System.Windows.Forms.Panel C3;
        private System.Windows.Forms.Panel C2;
        private System.Windows.Forms.Panel C1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColorDialog SelectColor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown SpeedUpValue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown AdvanceValue;
        private System.Windows.Forms.Button ImportXML;
        private System.Windows.Forms.Button ExportXML;
        private System.Windows.Forms.ComboBox MIDIDevicesListOUT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox MIDIDevicesListIN;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox LibraryPanel;
        private System.Windows.Forms.CheckBox NoteLabels;
        private System.Windows.Forms.CheckBox ShowKeyboard;
        private System.Windows.Forms.SaveFileDialog ExportConfig;
        private System.Windows.Forms.OpenFileDialog ImportConfig;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown NoteSpeedValue;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button RandomColorsButton;
        private System.Windows.Forms.Button ForceSave;
        private System.Windows.Forms.Button ScanMIDIDev;
    }
}

