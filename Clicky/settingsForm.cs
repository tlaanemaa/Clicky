using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Clicky
{
    public partial class settingsForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public settingsForm()
        {
            InitializeComponent();
        }

        private void toggleKeyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.toggleKeyEnabled = toggleKeyCheckbox.Checked;
            ((mainForm)this.Owner).toggleKeyListener(toggleKeyCheckbox.Checked);
            Properties.Settings.Default.Save();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            toggleKeyCheckbox.Text = "Enable toggle key (" + ((Keys)Properties.Settings.Default.toggleKey).ToString() + ")";
            toggleKeyCheckbox.Checked = Properties.Settings.Default.toggleKeyEnabled;
        }

        private void changeKeyBtn_Click(object sender, EventArgs e)
        {
            changeKeyBtn.Enabled = false;
            changeKeyBtn.Text = "Press new key...";
            newKeyTimer.Enabled = true;
        }

        private void newKeyTimer_Tick(object sender, EventArgs e)
        {
            for (Int32 i = 3; i < 255; i++)
            {
                int keyState = GetAsyncKeyState(i);
                if (keyState == 1 || keyState == -32767)
                {
                    newKeyTimer.Enabled = false;
                    changeKeyBtn.Text = "Change toggle key";
                    changeKeyBtn.Enabled = true;
                    Properties.Settings.Default.toggleKey = i;
                    Properties.Settings.Default.Save();
                    toggleKeyCheckbox.Text = "Enable toggle key (" + ((Keys)i).ToString() + ")";
                    return;
                }
            }
        }

        private void settingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            newKeyTimer.Enabled = false;
        }

        private void msURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(msURL.Text);
        }
    }
}
