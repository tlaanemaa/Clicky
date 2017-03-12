namespace Clicky
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.commandBox = new System.Windows.Forms.RichTextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.settingsSaver = new System.Windows.Forms.Timer(this.components);
            this.keyWorker = new System.ComponentModel.BackgroundWorker();
            this.keyChecker = new System.Windows.Forms.Timer(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commandBox
            // 
            this.commandBox.AcceptsTab = true;
            this.commandBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandBox.BackColor = System.Drawing.Color.White;
            this.commandBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandBox.DetectUrls = false;
            this.commandBox.EnableAutoDragDrop = true;
            this.commandBox.Location = new System.Drawing.Point(12, 12);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(260, 208);
            this.commandBox.TabIndex = 0;
            this.commandBox.Text = "";
            this.commandBox.TextChanged += new System.EventHandler(this.commandBox_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Location = new System.Drawing.Point(12, 226);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(150, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(168, 226);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // settingsSaver
            // 
            this.settingsSaver.Enabled = true;
            this.settingsSaver.Interval = 1000;
            this.settingsSaver.Tick += new System.EventHandler(this.settingsSaver_Tick);
            // 
            // keyWorker
            // 
            this.keyWorker.WorkerSupportsCancellation = true;
            this.keyWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.keyWorker_DoWork);
            this.keyWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.keyWorker_RunWorkerCompleted);
            // 
            // keyChecker
            // 
            this.keyChecker.Interval = 50;
            this.keyChecker.Tick += new System.EventHandler(this.keyChecker_Tick);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BackgroundImage = global::Clicky.Properties.Resources.Settings23;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Location = new System.Drawing.Point(249, 226);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(23, 23);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.commandBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Clicky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.mainForm_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox commandBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Timer settingsSaver;
        private System.ComponentModel.BackgroundWorker keyWorker;
        private System.Windows.Forms.Timer keyChecker;
    }
}

