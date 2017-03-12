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

using System.Diagnostics;

namespace Clicky
{
    public partial class mainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        public string[] commands;
        private Boolean settingsSaved = true;
        private int toggleKeyWait = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            Height = Properties.Settings.Default.height;
            Width = Properties.Settings.Default.width;
            commandBox.Text = Properties.Settings.Default.commandText;
            keyChecker.Enabled = Properties.Settings.Default.toggleKeyEnabled;
        }

        private void mainForm_ResizeEnd(object sender, EventArgs e)
        {
            settingsSaved = false;
        }

        private void commandBox_TextChanged(object sender, EventArgs e)
        {
            settingsSaved = false;
        }

        private void settingsSaver_Tick(object sender, EventArgs e)
        {
            if (!settingsSaved) saveSettings();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            runButton.Enabled = false;
            settingsButton.Enabled = false;
            stopButton.Enabled = true;
            stopButton.Focus();

            commands = commandBox.Text.Split(new string[] { "\n" }, StringSplitOptions.None);
            keyWorker.RunWorkerAsync();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            keyWorker.CancelAsync();
        }

        private void keyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker thisWorker = sender as BackgroundWorker;
            int i = 0;
            int sleepStep = 10;
            try
            {
                while (!thisWorker.CancellationPending)
                {
                    string cmd = commands[i].Trim();
                    if (cmd.StartsWith("*"))
                    {
                        // Sleep command
                        int sleepVal = Int32.Parse(cmd.Substring(1, cmd.Length - 1));
                        int sleepDone = 0;
                        while (sleepDone < sleepVal)
                        {
                            if (thisWorker.CancellationPending) return;
                            Thread.Sleep(sleepStep);
                            sleepDone += sleepStep;
                        }
                    }
                    else
                    {
                        // Regular command
                        if (cmd.StartsWith("\\")) cmd = cmd.Substring(1, cmd.Length - 1);
                        SendKeys.SendWait(cmd);
                    }

                    i++;
                    if (i > commands.Length - 1) i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSettings();
        }

        private void saveSettings()
        {
            Properties.Settings.Default.height = Height;
            Properties.Settings.Default.width = Width;
            Properties.Settings.Default.commandText = commandBox.Text;
            Properties.Settings.Default.Save();
            settingsSaved = true;
        }

        private void keyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            stopButton.Enabled = false;
            runButton.Enabled = true;
            settingsButton.Enabled = true;
            runButton.Focus();
        }

        private void keyChecker_Tick(object sender, EventArgs e)
        {
            if (commandBox.Focused) return;
            if (toggleKeyWait == 0)
            {
                short keyState = GetAsyncKeyState(Properties.Settings.Default.toggleKey);
                if (keyState == 1 || keyState == -32767)
                {
                    toggleKeyWait = 500 / keyChecker.Interval;
                    if (runButton.Enabled)
                    {
                        runButton.PerformClick();
                    }
                    else
                    {
                        stopButton.PerformClick();
                    }
                }
            }
            else
            {
                toggleKeyWait--;
            }
        }

        public void toggleKeyListener(Boolean value = true)
        {
            keyChecker.Enabled = value;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settingsForm frm = new settingsForm();
            frm.ShowDialog(this);
        }
    }
}
