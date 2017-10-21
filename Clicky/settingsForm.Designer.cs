namespace Clicky
{
    partial class settingsForm
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
            this.toggleKeyCheckbox = new System.Windows.Forms.CheckBox();
            this.changeKeyBtn = new System.Windows.Forms.Button();
            this.newKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.tipsGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msURL = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tipsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // toggleKeyCheckbox
            // 
            this.toggleKeyCheckbox.AutoSize = true;
            this.toggleKeyCheckbox.Location = new System.Drawing.Point(12, 12);
            this.toggleKeyCheckbox.Name = "toggleKeyCheckbox";
            this.toggleKeyCheckbox.Size = new System.Drawing.Size(111, 17);
            this.toggleKeyCheckbox.TabIndex = 0;
            this.toggleKeyCheckbox.Text = "Enable toggle key";
            this.toggleKeyCheckbox.UseVisualStyleBackColor = true;
            this.toggleKeyCheckbox.CheckedChanged += new System.EventHandler(this.toggleKeyCheckbox_CheckedChanged);
            // 
            // changeKeyBtn
            // 
            this.changeKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.changeKeyBtn.Location = new System.Drawing.Point(12, 35);
            this.changeKeyBtn.Name = "changeKeyBtn";
            this.changeKeyBtn.Size = new System.Drawing.Size(397, 23);
            this.changeKeyBtn.TabIndex = 2;
            this.changeKeyBtn.Text = "Change toggle key";
            this.changeKeyBtn.UseVisualStyleBackColor = true;
            this.changeKeyBtn.Click += new System.EventHandler(this.changeKeyBtn_Click);
            // 
            // newKeyTimer
            // 
            this.newKeyTimer.Interval = 50;
            this.newKeyTimer.Tick += new System.EventHandler(this.newKeyTimer_Tick);
            // 
            // tipsGroup
            // 
            this.tipsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tipsGroup.Controls.Add(this.label9);
            this.tipsGroup.Controls.Add(this.label8);
            this.tipsGroup.Controls.Add(this.label7);
            this.tipsGroup.Controls.Add(this.label6);
            this.tipsGroup.Controls.Add(this.label5);
            this.tipsGroup.Controls.Add(this.label4);
            this.tipsGroup.Controls.Add(this.msURL);
            this.tipsGroup.Controls.Add(this.label3);
            this.tipsGroup.Controls.Add(this.label2);
            this.tipsGroup.Controls.Add(this.label1);
            this.tipsGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tipsGroup.Location = new System.Drawing.Point(12, 79);
            this.tipsGroup.Name = "tipsGroup";
            this.tipsGroup.Size = new System.Drawing.Size(397, 210);
            this.tipsGroup.TabIndex = 3;
            this.tipsGroup.TabStop = false;
            this.tipsGroup.Text = "Tips";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "- Write *end to end execution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "- This uses System.Windows.Forms.SendKeys class and user32.dll";
            // 
            // msURL
            // 
            this.msURL.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msURL.AutoEllipsis = true;
            this.msURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.msURL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msURL.Location = new System.Drawing.Point(6, 185);
            this.msURL.Name = "msURL";
            this.msURL.Size = new System.Drawing.Size(383, 18);
            this.msURL.TabIndex = 3;
            this.msURL.TabStop = true;
            this.msURL.Text = "https://msdn.microsoft.com/en-us/library/system.windows.forms.sendkeys";
            this.msURL.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.msURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.msURL_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "- The toggle key can be used to toggle the script on/off";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Use \\ to escape the * sign (\\*300 will type out \"*300\")";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "- Special commands start with *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "- Write *sleep 300 to sleep for 300ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "- Write *mouse move 500 300 to move mouse to position x=500 y=300";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "- Write *mouse click down 500 300 to set mouse left button down at x=500 y=300";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(367, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "- Write *mouse click up 500 300 to release mouse left button at x=500 y=300";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 301);
            this.Controls.Add(this.tipsGroup);
            this.Controls.Add(this.changeKeyBtn);
            this.Controls.Add(this.toggleKeyCheckbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 250);
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.tipsGroup.ResumeLayout(false);
            this.tipsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox toggleKeyCheckbox;
        private System.Windows.Forms.Button changeKeyBtn;
        private System.Windows.Forms.Timer newKeyTimer;
        private System.Windows.Forms.GroupBox tipsGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel msURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}