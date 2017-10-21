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
    public partial class mainForm : Form
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        public string[] commands;
        private Boolean settingsSaved = true;
        private int toggleKeyWait = 0;
        private settingsForm settingsFrm = new settingsForm();

        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

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
                        // Special commands
                        if(cmd == "*end")
                        {
                            // End loop
                            return;
                        }
                        else
                        {
                            // Sleep
                            int sleepVal = Int32.Parse(cmd.Substring(1, cmd.Length - 1));
                            int sleepDone = 0;
                            while (sleepDone < sleepVal)
                            {
                                if (thisWorker.CancellationPending) return;
                                Thread.Sleep(sleepStep);
                                sleepDone += sleepStep;
                            }
                        }
                        
                    }
                    else
                    {
                        // Regular commands
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
        }

        private void keyChecker_Tick(object sender, EventArgs e)
        {
            if (this.ContainsFocus || settingsFrm.ContainsFocus) return;
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
            settingsFrm.ShowDialog(this);
        }

        private void mouseMove(int x, int y)
        {
            SetCursorPos(x, y);
        }

        private void mouseAction(string action, string key = "left", int? x = null, int? y = null)
        {
            uint mouseAction;
            uint xCoord;
            uint yCoord;

            // Decide which key and action we want to use
            if (key == "left" && action == "down")
            {
                mouseAction = MOUSEEVENTF_LEFTDOWN;
            }
            else if (key == "left" && action == "up")
            {
                mouseAction = MOUSEEVENTF_LEFTUP;
            }
            else if (key == "right" && action == "down")
            {
                mouseAction = MOUSEEVENTF_RIGHTDOWN;
            }
            else if (key == "right" && action == "up")
            {
                mouseAction = MOUSEEVENTF_RIGHTUP;
            }
            else
            {
                // Invalid key or action, ignore
                return;
            }

            // Get coordinates for mouse action
            if (x == null)
            {
                xCoord = (uint)Cursor.Position.X;
            } else
            {
                xCoord = (uint)x;
            }

            if (y == null)
            {
                yCoord = (uint)Cursor.Position.Y;
            } else
            {
                yCoord = (uint)y;
            }

            // Perform mouse action
            mouse_event(mouseAction, xCoord, yCoord, 0, 0);
        }
    }
}
