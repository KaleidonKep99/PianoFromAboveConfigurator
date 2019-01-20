using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;
using System.Diagnostics;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;

namespace PianoFromAboveConfigurator
{
    public partial class MainWindow : Form
    {
        public Random rnd = new Random();
        // P/Invoke constants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;

        // P/Invoke declarations
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);


        // ID for the About item on the system menu
        private int SYSMENU_ABOUT_ID = 0x1;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);
            AppendMenu(hSysMenu, MF_SEPARATOR, 0, string.Empty);
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, "&About the app…");
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                MessageBox.Show("Piano From Above: Configurator by KaleidonKep99\nCopyright © 2013-2017 KaleidonKep99\n\nPiano From Above is a program developed by Brian Pantano.\nCopyright © 2010 Brian Pantano", "About the app", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        public static class XMLDoc
        {
            public static XmlDocument xml = new XmlDocument();
            public static XmlNode PFAMain;
            public static XmlNode Visuals;
            public static XmlNode Audio;
            public static XmlNode Video;
            public static XmlNode Controls;
            public static XmlNode Colors;
            public static XmlNode BkgColor;
            public static XmlNode Playback;
            public static XmlNode View;
        }

        private void ScanForMIDIDevices()
        {
            MIDIDevicesListIN.Items.Clear();
            int DeviceCountIN = WinMM.midiInGetNumDevs();
            MIDIINCAPS CapsIN = new MIDIINCAPS();
            if (DeviceCountIN > 0)
            {
                for (uint i = 0; i < WinMM.midiInGetNumDevs(); i++)
                {
                    WinMM.midiInGetDevCaps(i, out CapsIN, (uint)Marshal.SizeOf(CapsIN));
                    MIDIDevicesListIN.Items.Add(CapsIN.szPname);
                }
            }
            else
            {
                label25.Enabled = false;
                MIDIDevicesListIN.Items.Add("None");
                MIDIDevicesListIN.Enabled = false;
            }

            MIDIDevicesListOUT.Items.Clear();
            int DeviceCountOUT = WinMM.midiOutGetNumDevs();
            MIDIOUTCAPS CapsOUT = new MIDIOUTCAPS();
            if (DeviceCountOUT > 0)
            {
                for (uint i = 0; i < WinMM.midiOutGetNumDevs(); i++)
                {
                    WinMM.midiOutGetDevCaps(i, out CapsOUT, (uint)Marshal.SizeOf(CapsOUT));
                    MIDIDevicesListOUT.Items.Add(CapsOUT.szPname);
                }
            }
            else
            {
                label24.Enabled = false;
                MIDIDevicesListOUT.Items.Add("None");
                MIDIDevicesListOUT.Enabled = false;
            }
        }

        private void LoadXMLIntoMemory()
        {
            try
            {
                XMLDoc.xml.Load(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
                XMLDoc.PFAMain = XMLDoc.xml.SelectSingleNode("PianoFromAbove");
                XMLDoc.Visuals = XMLDoc.PFAMain.SelectSingleNode("Visual");
                XMLDoc.Audio = XMLDoc.PFAMain.SelectSingleNode("Audio");
                XMLDoc.Video = XMLDoc.PFAMain.SelectSingleNode("Video");
                XMLDoc.Controls = XMLDoc.PFAMain.SelectSingleNode("Controls");
                XMLDoc.Colors = XMLDoc.Visuals.SelectSingleNode("Colors");
                XMLDoc.BkgColor = XMLDoc.Visuals.SelectSingleNode("BkgColor");
                XMLDoc.Playback = XMLDoc.PFAMain.SelectSingleNode("Playback");
                XMLDoc.View = XMLDoc.PFAMain.SelectSingleNode("View");
            }
            catch
            {
                Process[] PFAx86 = Process.GetProcessesByName("PFA-1.1.0-x86");
                Process[] PFAx64 = Process.GetProcessesByName("PFA-1.1.0-x86_64");
                if (PFAx86.Length != 0 || PFAx64.Length != 0)
                {
                    MessageBox.Show("Please close PFA before using this tool.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(5);
                }
                else
                {
                    if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\MetaData.pb")))
                    {
                        MessageBox.Show("The configuration file is damaged or missing.\n\nPlease start PFA at least one time, to restore it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(13876);
                    }
                    else
                    {
                        MessageBox.Show("Please run PFA at least one time before using this tool.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Environment.Exit(13876);
                    }
                }
            }
        }

        private void LoadValues()
        {
            try
            {
                // MIDI devices
                try { MIDIDevicesListIN.Text = XMLDoc.Audio.Attributes["MIDIInDevice"].Value; }
                catch { MIDIDevicesListIN.Text = "LoopBe Internal MIDI"; }
                try { MIDIDevicesListOUT.Text = XMLDoc.Audio.Attributes["MIDIOutDevice"].Value; }
                catch { MIDIDevicesListOUT.Text = "Microsoft GS Wavetable Synth"; }

                // Piano keys stuff
                if (XMLDoc.Visuals.Attributes["KeysShown"].Value == "0" && XMLDoc.Visuals.Attributes["FirstKey"].Value == "21" && XMLDoc.Visuals.Attributes["LastKey"].Value == "108")
                {
                    keys88.Checked = true;
                }
                else if (XMLDoc.Visuals.Attributes["KeysShown"].Value == "0" && XMLDoc.Visuals.Attributes["FirstKey"].Value == "0" && XMLDoc.Visuals.Attributes["LastKey"].Value == "127")
                {
                    keys128.Checked = true;
                }
                else if (XMLDoc.Visuals.Attributes["KeysShown"].Value == "1")
                {
                    keysSong.Checked = true;
                }
                else if (XMLDoc.Visuals.Attributes["KeysShown"].Value == "2")
                {
                    keysCustom.Checked = true;
                    LLabel.Enabled = true;
                    LKey.Enabled = true;
                    HLabel.Enabled = true;
                    HKey.Enabled = true;
                    LKey.Value = Convert.ToDecimal(XMLDoc.Visuals.Attributes["FirstKey"].Value);
                    HKey.Value = Convert.ToDecimal(XMLDoc.Visuals.Attributes["LastKey"].Value);
                }
                // Controls
                if (XMLDoc.Visuals.Attributes["AlwaysShowControls"].Value == "0") { FullScreenControls.Checked = false; }
                else { FullScreenControls.Checked = true; }
                if (XMLDoc.Video.Attributes["ShowFPS"].Value == "0") { ShowFPS.Checked = false; }
                else { ShowFPS.Checked = true; }
                if (XMLDoc.Video.Attributes["LimitFPS"].Value == "0") { LockFPS.Checked = false; }
                else { LockFPS.Checked = true; }
                if (XMLDoc.View.Attributes["Library"].Value == "0") { LibraryPanel.Checked = false; }
                else { LibraryPanel.Checked = true; }
                if (XMLDoc.View.Attributes["NoteLabels"].Value == "0") { NoteLabels.Checked = false; }
                else { NoteLabels.Checked = true; }
                if (XMLDoc.View.Attributes["Keyboard"].Value == "0") { ShowKeyboard.Checked = false; }
                else { ShowKeyboard.Checked = true; }
                try
                {
                    decimal AV = decimal.Parse(XMLDoc.Controls.Attributes["FwdBackSecs"].Value, CultureInfo.InvariantCulture);
                    decimal SUV = decimal.Parse(XMLDoc.Controls.Attributes["SpeedUpPct"].Value, CultureInfo.InvariantCulture);
                    decimal NSV = decimal.Parse(XMLDoc.Playback.Attributes["NoteSpeed"].Value, CultureInfo.InvariantCulture);
                    AdvanceValue.Value = AV;
                    SpeedUpValue.Value = SUV;
                    NoteSpeedValue.Value = NSV;
                }
                catch
                {
                    AdvanceValue.Value = 1;
                    SpeedUpValue.Value = 100;
                    NoteSpeedValue.Value = 1;
                }
                // Background color
                Color ImportedColor = new Color();
                ImportedColor = Color.FromArgb(Convert.ToInt32(XMLDoc.BkgColor.Attributes["R"].Value),
                    Convert.ToInt32(XMLDoc.BkgColor.Attributes["G"].Value),
                    Convert.ToInt32(XMLDoc.BkgColor.Attributes["B"].Value));
                colors.BackColor = ImportedColor;
                // Note colors
                ImportNoteColors();
                // Begin to kill PFA if running
                NoPFATimer.Enabled = true;
            }
            catch
            {
                LoadValues();
            }
        }

        private void LoadSys(object sender, EventArgs e)
        {
            Process[] PFAx86 = Process.GetProcessesByName("PFA-1.1.0-x86");
            Process[] PFAx64 = Process.GetProcessesByName("PFA-1.1.0-x86_64");

            Process[] PFAArray = new Process[PFAx86.Length + PFAx64.Length];
            Array.Copy(PFAx86, PFAArray, PFAx86.Length);
            Array.Copy(PFAx64, PFAArray, PFAx64.Length);

            ScanForMIDIDevices();

            if (PFAArray.Length != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Please close PFA before using this tool.\nDo you want to close it now?\n\nIf you click \"No\", the configurator will exit, and PFA will continue to run.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    foreach (Process proc in PFAArray)
                        proc.Kill();
                }
                else Environment.Exit(5);
            }

            LoadXMLIntoMemory();
            LoadValues();
        }

        private void ImportNoteColors()
        {
            Color[] Channels = new Color[] { Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.White };
            Channels[0] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[0].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[0].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[0].Attributes["B"].Value));
            Channels[1] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[1].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[1].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[1].Attributes["B"].Value));
            Channels[2] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[2].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[2].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[2].Attributes["B"].Value));
            Channels[3] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[3].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[3].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[3].Attributes["B"].Value));
            Channels[4] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[4].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[4].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[4].Attributes["B"].Value));
            Channels[5] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[5].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[5].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[5].Attributes["B"].Value));
            Channels[6] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[6].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[6].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[6].Attributes["B"].Value));
            Channels[7] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[7].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[7].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[7].Attributes["B"].Value));
            Channels[8] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[8].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[8].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[8].Attributes["B"].Value));
            Channels[9] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[9].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[9].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[9].Attributes["B"].Value));
            Channels[10] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[10].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[10].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[10].Attributes["B"].Value));
            Channels[11] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[11].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[11].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[11].Attributes["B"].Value));
            Channels[12] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[12].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[12].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[12].Attributes["B"].Value));
            Channels[13] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[13].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[13].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[13].Attributes["B"].Value));
            Channels[14] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[14].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[14].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[14].Attributes["B"].Value));
            Channels[15] = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[15].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[15].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[15].Attributes["B"].Value));

            C1.BackColor = Channels[0];
            C2.BackColor = Channels[1];
            C3.BackColor = Channels[2];
            C4.BackColor = Channels[3];
            C5.BackColor = Channels[4];
            C6.BackColor = Channels[5];
            C7.BackColor = Channels[6];
            C8.BackColor = Channels[7];
            C9.BackColor = Channels[8];
            C10.BackColor = Channels[9];
            C11.BackColor = Channels[10];
            C12.BackColor = Channels[11];
            C13.BackColor = Channels[12];
            C14.BackColor = Channels[13];
            C15.BackColor = Channels[14];
            C16.BackColor = Channels[15];
        }

        private void NoPFATimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Process[] PFAx86 = Process.GetProcessesByName("PFA-1.1.0-x86");
                Process[] PFAx64 = Process.GetProcessesByName("PFA-1.1.0-x86_64");

                Process[] PFAArray = new Process[PFAx86.Length + PFAx64.Length];
                Array.Copy(PFAx86, PFAArray, PFAx86.Length);
                Array.Copy(PFAx64, PFAArray, PFAx64.Length);

                if (PFAArray.Length != 0)
                {
                    foreach (Process proc in PFAArray)
                        proc.Kill();

                    MessageBox.Show("You have to close the configurator before running Piano From Above.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Thread.Sleep(1);
            }
            catch { }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            XMLDoc.xml.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
            Thread.Sleep(100);
            Application.ExitThread();
        }

        private void ImportXML_Click(object sender, EventArgs e)
        {
            try
            {
                ImportConfig.FileName = "";
                if (ImportConfig.ShowDialog() == DialogResult.OK)
                {
                    XMLDoc.xml.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
                    File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
                    File.Copy(ImportConfig.FileName, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
                    LoadXMLIntoMemory();
                    LoadValues();
                    MessageBox.Show("Configuration file imported successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ignored =>
                {
                    throw new Exception("crash.");
                }));
            }
        }

        private void ExportXML_Click(object sender, EventArgs e)
        {
            try
            {
                ExportConfig.FileName = "";
                if (ExportConfig.ShowDialog() == DialogResult.OK)
                {
                    XMLDoc.xml.Save(ExportConfig.FileName);
                    LoadXMLIntoMemory();
                    LoadValues();
                    MessageBox.Show("Configuration file saved successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ignored =>
                {
                    throw new Exception("crash.");
                }));
            }
        }

        private void keys128_CheckedChanged(object sender, EventArgs e)
        {
            LLabel.Enabled = false;
            LKey.Enabled = false;
            HLabel.Enabled = false;
            HKey.Enabled = false;
            LKey.Value = 0;
            HKey.Value = 127;
            XMLDoc.Visuals.Attributes["KeysShown"].Value = "0";
            XMLDoc.Visuals.Attributes["FirstKey"].Value = "0";
            XMLDoc.Visuals.Attributes["LastKey"].Value = "127";
        }

        private void keys88_CheckedChanged(object sender, EventArgs e)
        {
            LLabel.Enabled = false;
            LKey.Enabled = false;
            HLabel.Enabled = false;
            HKey.Enabled = false;
            LKey.Value = 21;
            HKey.Value = 108;
            LKey.Value = 21;
            XMLDoc.Visuals.Attributes["KeysShown"].Value = "0";
            XMLDoc.Visuals.Attributes["FirstKey"].Value = "21";
            XMLDoc.Visuals.Attributes["LastKey"].Value = "108";
        }

        private void keysSong_CheckedChanged(object sender, EventArgs e)
        {
            LLabel.Enabled = false;
            LKey.Enabled = false;
            HLabel.Enabled = false;
            HKey.Enabled = false;
            LKey.Value = 20;
            HKey.Value = 20;
            LKey.Value = 20;
            XMLDoc.Visuals.Attributes["KeysShown"].Value = "1";
            XMLDoc.Visuals.Attributes["FirstKey"].Value = "20";
            XMLDoc.Visuals.Attributes["LastKey"].Value = "20";
        }

        private void keysCustom_CheckedChanged(object sender, EventArgs e)
        {
            LLabel.Enabled = true;
            LKey.Enabled = true;
            HLabel.Enabled = true;
            HKey.Enabled = true;
            XMLDoc.Visuals.Attributes["KeysShown"].Value = "2";
        }

        private void LKey_ValueChanged(object sender, EventArgs e)
        {
            if (LKey.Value > HKey.Value) { LKey.Value = HKey.Value; }
            XMLDoc.Visuals.Attributes["FirstKey"].Value = LKey.Value.ToString();
        }

        private void HKey_ValueChanged(object sender, EventArgs e)
        {
            if (HKey.Value < LKey.Value) { HKey.Value = LKey.Value; }
            XMLDoc.Visuals.Attributes["LastKey"].Value = HKey.Value.ToString();
        }

        private void FullScreenControls_CheckedChanged(object sender, EventArgs e)
        {
            if (FullScreenControls.Checked == true) { XMLDoc.Visuals.Attributes["AlwaysShowControls"].Value = "1"; }
            else { XMLDoc.Visuals.Attributes["AlwaysShowControls"].Value = "0"; }
        }

        private void LockFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (LockFPS.Checked == true) { XMLDoc.Video.Attributes["LimitFPS"].Value = "1"; }
            else { XMLDoc.Video.Attributes["LimitFPS"].Value = "0"; }
        }

        private void ShowFPS_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowFPS.Checked == true) { XMLDoc.Video.Attributes["ShowFPS"].Value = "1"; }
            else { XMLDoc.Video.Attributes["ShowFPS"].Value = "0"; }
        }

        private void ShowKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowKeyboard.Checked == true) { XMLDoc.View.Attributes["Keyboard"].Value = "1"; }
            else { XMLDoc.View.Attributes["Keyboard"].Value = "0"; }
        }

        private void NoteLabels_CheckedChanged(object sender, EventArgs e)
        {
            if (NoteLabels.Checked == true) { XMLDoc.View.Attributes["NoteLabels"].Value = "1"; }
            else { XMLDoc.View.Attributes["NoteLabels"].Value = "0"; }
        }

        private void LibraryPanel_CheckedChanged(object sender, EventArgs e)
        {
            if (LibraryPanel.Checked == true) { XMLDoc.View.Attributes["Library"].Value = "1"; }
            else { XMLDoc.View.Attributes["Library"].Value = "0"; }
        }

        private void NoteColor(Panel panel, int whichone)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Paste the HTML color in the textbox down below.\n\n(Format: #xxxxxx)", "HTML color parser", "#FFFFFF", -1, -1);
                if (input.Length != 0)
                {
                    Color HTMLColor = System.Drawing.ColorTranslator.FromHtml(input);
                    panel.BackColor = HTMLColor;
                    XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["R"].Value = HTMLColor.R.ToString();
                    XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["G"].Value = HTMLColor.G.ToString();
                    XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["B"].Value = HTMLColor.B.ToString();
                }
            }
            else
            {
                Color previous = new Color();
                previous = Color.FromArgb(Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["R"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["G"].Value), Convert.ToInt32(XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["B"].Value));
                SelectColor.Color = previous;
                SelectColor.FullOpen = true;
                SelectColor.AllowFullOpen = true;
                if (SelectColor.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        panel.BackColor = SelectColor.Color;
                        XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["R"].Value = SelectColor.Color.R.ToString();
                        XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["G"].Value = SelectColor.Color.G.ToString();
                        XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["B"].Value = SelectColor.Color.B.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error.");
                    }
                }
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            NoteColor(C1, 1);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            NoteColor(C2, 2);
        }

        private void C3_Click(object sender, EventArgs e)
        {
            NoteColor(C3, 3);
        }

        private void C4_Click(object sender, EventArgs e)
        {
            NoteColor(C4, 4);
        }

        private void C5_Click(object sender, EventArgs e)
        {
            NoteColor(C5, 5);
        }

        private void C6_Click(object sender, EventArgs e)
        {
            NoteColor(C6, 6);
        }

        private void C7_Click(object sender, EventArgs e)
        {
            NoteColor(C7, 7);
        }

        private void C8_Click(object sender, EventArgs e)
        {
            NoteColor(C8, 8);
        }

        private void C9_Click(object sender, EventArgs e)
        {
            NoteColor(C9, 9);
        }

        private void C10_Click(object sender, EventArgs e)
        {
            NoteColor(C10, 10);
        }

        private void C11_Click(object sender, EventArgs e)
        {
            NoteColor(C11, 11);
        }

        private void C12_Click(object sender, EventArgs e)
        {
            NoteColor(C12, 12);
        }

        private void C13_Click(object sender, EventArgs e)
        {
            NoteColor(C13, 13);
        }

        private void C14_Click(object sender, EventArgs e)
        {
            NoteColor(C14, 14);
        }

        private void C15_Click(object sender, EventArgs e)
        {
            NoteColor(C15, 15);
        }

        private void C16_Click(object sender, EventArgs e)
        {
            NoteColor(C16, 16);
        }

        private void ForceSave_Click(object sender, EventArgs e)
        {
            XMLDoc.xml.Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Piano From Above\\Config.xml"));
            LoadXMLIntoMemory();
            LoadValues();
            MessageBox.Show("The configuration file has been saved!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void colors_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Paste the HTML color in the textbox down below.\n\n(Format: #xxxxxx)", "HTML color parser", "#FFFFFF", -1, -1);
                if (input.Length != 0)
                {
                    Color HTMLColor = System.Drawing.ColorTranslator.FromHtml(input);
                    colors.BackColor = HTMLColor;
                    XMLDoc.BkgColor.Attributes["R"].Value = HTMLColor.R.ToString();
                    XMLDoc.BkgColor.Attributes["G"].Value = HTMLColor.G.ToString();
                    XMLDoc.BkgColor.Attributes["B"].Value = HTMLColor.B.ToString();
                }
            }
            else
            {
                Color previous = new Color();
                previous = Color.FromArgb(Convert.ToInt32(XMLDoc.BkgColor.Attributes["R"].Value), Convert.ToInt32(XMLDoc.BkgColor.Attributes["G"].Value), Convert.ToInt32(XMLDoc.BkgColor.Attributes["G"].Value));
                SelectColor.Color = previous;
                SelectColor.FullOpen = true;
                SelectColor.AllowFullOpen = true;
                SelectColor.AllowFullOpen = true;
                if (SelectColor.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        colors.BackColor = SelectColor.Color;
                        XMLDoc.BkgColor.Attributes["R"].Value = SelectColor.Color.R.ToString();
                        XMLDoc.BkgColor.Attributes["G"].Value = SelectColor.Color.G.ToString();
                        XMLDoc.BkgColor.Attributes["B"].Value = SelectColor.Color.B.ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Error.");
                    }
                }
            }
        }

        private void RandomColorsSave(int r, int g, int b, int whichone)
        {
            XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["R"].Value = r.ToString();
            XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["G"].Value = g.ToString();
            XMLDoc.Colors.SelectNodes("Color")[whichone - 1].Attributes["B"].Value = b.ToString();
        }

        private void AdvanceValue_ValueChanged(object sender, EventArgs e)
        {
            XMLDoc.Controls.Attributes["FwdBackSecs"].Value = AdvanceValue.Value.ToString().Replace(",", ".");
        }

        private void SpeedUpValue_ValueChanged(object sender, EventArgs e)
        {
            XMLDoc.Controls.Attributes["SpeedUpPct"].Value = SpeedUpValue.Value.ToString().Replace(",", ".");
        }

        private void NoteSpeedValue_ValueChanged(object sender, EventArgs e)
        {
            XMLDoc.Playback.Attributes["NoteSpeed"].Value = NoteSpeedValue.Value.ToString().Replace(",", ".");
        }

        private void MIDIDevicesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                XMLDoc.Audio.Attributes["MIDIOutDevice"].Value = MIDIDevicesListOUT.Text;
            }
            catch
            {
                XmlDocument doc = XMLDoc.Audio.OwnerDocument;
                XmlAttribute attr = doc.CreateAttribute("MIDIOutDevice");
                attr.Value = MIDIDevicesListOUT.Text;     
                XMLDoc.Audio.Attributes.SetNamedItem(attr);
            }
        }

        private void MIDIDevicesListIN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { XMLDoc.Audio.Attributes["MIDIInDevice"].Value = MIDIDevicesListIN.Text;
            }
            catch
            {
                XmlDocument doc = XMLDoc.Audio.OwnerDocument;
                XmlAttribute attr = doc.CreateAttribute("MIDIInDevice");
                attr.Value = MIDIDevicesListOUT.Text;
                XMLDoc.Audio.Attributes.SetNamedItem(attr);
            }
        }

        private int[] RandomColors()
        {
            int[] RGBPalette = new int[3];
            RGBPalette[0] = rnd.Next(0, 255);
            RGBPalette[1] = rnd.Next(0, 255);
            RGBPalette[2] = rnd.Next(0, 255);   
            return RGBPalette;
        }

        private void RandomColors_Click(object sender, EventArgs e)
        {
            Tabs.SelectedIndex = 1;
            int[] RGBPalette = new int[3];
            Color Palette = new Color();
            // 1
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C1.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 1);
            // 2
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C2.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 2);
            // 3
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C3.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 3);
            // 4
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C4.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 4);
            // 5
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C5.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 5);
            // 6
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C6.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 6);
            // 7
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C7.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 7);
            // 8
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C8.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 8);
            // 9
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C9.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 9);
            // 10
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C10.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 10);
            // 11
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C11.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 11);
            // 12
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C12.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 12);
            // 13
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C13.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 13);
            // 14
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C14.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 14);
            // 15
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C15.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 15);
            // 16
            RGBPalette = RandomColors();
            Palette = Color.FromArgb(RGBPalette[0], RGBPalette[1], RGBPalette[2]);
            C16.BackColor = Palette;
            RandomColorsSave(RGBPalette[0], RGBPalette[1], RGBPalette[2], 16);
        }

        private void ScanMIDIDev_Click(object sender, EventArgs e)
        {
            ScanForMIDIDevices();
            try { MIDIDevicesListIN.Text = XMLDoc.Audio.Attributes["MIDIInDevice"].Value; }
            catch { MIDIDevicesListIN.Text = "LoopBe Internal MIDI"; }
            try { MIDIDevicesListOUT.Text = XMLDoc.Audio.Attributes["MIDIOutDevice"].Value; }
            catch { MIDIDevicesListOUT.Text = "Microsoft GS Wavetable Synth"; }
        }
    }

    internal static class WinMM
    {
        internal const int MMSYSERR_NOERROR = 0;

        [DllImport("winmm.dll")]
        internal static extern int midiInGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiOutGetNumDevs();

        [DllImport("winmm.dll")]
        internal static extern int midiInGetDevCaps(
            uint uDeviceID,
            out MIDIINCAPS caps,
            uint cbMidiInCaps);

        [DllImport("winmm.dll")]
        internal static extern int midiOutGetDevCaps(
            uint uDeviceID,
            out MIDIOUTCAPS caps,
            uint cbMidiOutCaps);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MIDIINCAPS
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;     // MMVERSION
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public uint dwSupport;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct MIDIOUTCAPS
    {
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string szPname;
        public ushort wTechnology;
        public ushort wVoices;
        public ushort wNotes;
        public ushort wChannelMask;
        public uint dwSupport;
    }
}