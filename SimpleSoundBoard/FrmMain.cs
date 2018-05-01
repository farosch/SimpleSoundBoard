using System;
using WMPLib;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace SimpleSoundBoard
{
    public partial class FrmMain : Form
    {
        Hotkey[] hotkeys = new Hotkey[12];
        WindowsMediaPlayer wmp = new WindowsMediaPlayer();

        public FrmMain()
        {
            InitializeComponent();
            
            toolTip.SetToolTip(this.btF1, Properties.Settings.Default.file1);
            toolTip.SetToolTip(this.btF2, Properties.Settings.Default.file2);
            toolTip.SetToolTip(this.btF3, Properties.Settings.Default.file3);
            toolTip.SetToolTip(this.btF4, Properties.Settings.Default.file4);
            toolTip.SetToolTip(this.btF5, Properties.Settings.Default.file5);
            toolTip.SetToolTip(this.btF6, Properties.Settings.Default.file6);
            toolTip.SetToolTip(this.btF7, Properties.Settings.Default.file7);
            toolTip.SetToolTip(this.btF8, Properties.Settings.Default.file8);
            toolTip.SetToolTip(this.btF9, Properties.Settings.Default.file9);
            toolTip.SetToolTip(this.btF10, Properties.Settings.Default.file10);
            toolTip.SetToolTip(this.btF11, Properties.Settings.Default.file11);
            toolTip.SetToolTip(this.btF12, Properties.Settings.Default.file12);
            
            hotkeys[0] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F1, this);
            hotkeys[1] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F2, this);
            hotkeys[2] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F3, this);
            hotkeys[3] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F4, this);
            hotkeys[4] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F5, this);
            hotkeys[5] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F6, this);
            hotkeys[6] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F7, this);
            hotkeys[7] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F8, this);
            hotkeys[8] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F9, this);
            hotkeys[9] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F10, this);
            hotkeys[10] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F11, this);
            hotkeys[11] = new Hotkey(Constants.CTRL + Constants.SHIFT, Keys.F12, this);
            
            foreach (Hotkey h in hotkeys)
            {
                try
                {
                    h.Register();
                } catch { }
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.Show();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID)
            {
                switch (GetKey(m.LParam))
                {
                    case Keys.F1:
                        wmp.URL = Properties.Settings.Default.file1;
                        break;
                    case Keys.F2:
                        wmp.URL = Properties.Settings.Default.file2;
                        break;
                    case Keys.F3:
                        wmp.URL = Properties.Settings.Default.file3;
                        break;
                    case Keys.F4:
                        wmp.URL = Properties.Settings.Default.file4;
                        break;
                    case Keys.F5:
                        wmp.URL = Properties.Settings.Default.file5;
                        break;
                    case Keys.F6:
                        wmp.URL = Properties.Settings.Default.file6;
                        break;
                    case Keys.F7:
                        wmp.URL = Properties.Settings.Default.file7;
                        break;
                    case Keys.F8:
                        wmp.URL = Properties.Settings.Default.file8;
                        break;
                    case Keys.F9:
                        wmp.URL = Properties.Settings.Default.file9;
                        break;
                    case Keys.F10:
                        wmp.URL = Properties.Settings.Default.file10;
                        break;
                    case Keys.F11:
                        wmp.URL = Properties.Settings.Default.file11;
                        break;
                    case Keys.F12:
                        wmp.URL = Properties.Settings.Default.file12;
                        break;
                }
                try
                {
                    wmp.controls.play();
                } catch { }
            }
            base.WndProc(ref m);
        }

        private Keys GetKey(IntPtr LParam)
        {
            return (Keys)(LParam.ToInt32() >> 16);
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            foreach (Hotkey h in hotkeys)
            {
                try
                {
                    h.Unregister();
                }
                catch { }
            }

            notifyIcon.Visible = false;
            
            Properties.Settings.Default.Save();

            Environment.Exit(0);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                switch (((Button)sender).Name.ToString())
                {
                    case "btF1":
                        Properties.Settings.Default.file1 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF1, openFileDialog.FileName);
                        break;
                    case "btF2":
                        Properties.Settings.Default.file2 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF2, openFileDialog.FileName);
                        break;
                    case "btF3":
                        Properties.Settings.Default.file3 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF3, openFileDialog.FileName);
                        break;
                    case "btF4":
                        Properties.Settings.Default.file4 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF4, openFileDialog.FileName);
                        break;
                    case "btF5":
                        Properties.Settings.Default.file5 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF5, openFileDialog.FileName);
                        break;
                    case "btF6":
                        Properties.Settings.Default.file6 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF6, openFileDialog.FileName);
                        break;
                    case "btF7":
                        Properties.Settings.Default.file7 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF7, openFileDialog.FileName);
                        break;
                    case "btF8":
                        Properties.Settings.Default.file8 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF8, openFileDialog.FileName);
                        break;
                    case "btF9":
                        Properties.Settings.Default.file9 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF9, openFileDialog.FileName);
                        break;
                    case "btF10":
                        Properties.Settings.Default.file10 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF10, openFileDialog.FileName);
                        break;
                    case "btF11":
                        Properties.Settings.Default.file11 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF11, openFileDialog.FileName);
                        break;
                    case "btF12":
                        Properties.Settings.Default.file12 = openFileDialog.FileName;
                        toolTip.SetToolTip(this.btF12, openFileDialog.FileName);
                        break;
                }
            }
        }

        private void TsmiShow_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void TsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Version:\n\t" + Application.ProductVersion + 
                "\nCopyright:\n\t" + "Faryan Rezagholi, 2018" +
                "\nLicence:\n\tGNU GENERAL PUBLIC LICENSE Version 3" +
                "\nSource Code:\n\thttps://github.com/farosch/SimpleSoundBoard", "About " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
