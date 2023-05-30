namespace RemoteServer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonClear = new System.Windows.Forms.Button();
            this.textDebug = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonHide = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.buttonSaveSettings = new System.Windows.Forms.Button();
            this.buttonCancelSettings = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFirewall = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.ImgWinbackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWinbackground)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(344, 10);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.MouseHover += new System.EventHandler(this.buttonClear_MouseHover);
            // 
            // textDebug
            // 
            this.textDebug.Location = new System.Drawing.Point(0, -2);
            this.textDebug.Margin = new System.Windows.Forms.Padding(2);
            this.textDebug.Multiline = true;
            this.textDebug.Name = "textDebug";
            this.textDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDebug.Size = new System.Drawing.Size(324, 344);
            this.textDebug.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(344, 47);
            this.buttonHide.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(56, 24);
            this.buttonHide.TabIndex = 2;
            this.buttonHide.Text = "Hide";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(344, 86);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(56, 24);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(156, 7);
            this.portBox.Margin = new System.Windows.Forms.Padding(2);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(82, 20);
            this.portBox.TabIndex = 4;
            this.portBox.Text = "4000";
            this.portBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "TCP Listen port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(156, 44);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(82, 20);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.Text = "letmein";
            this.passwordBox.Visible = false;
            // 
            // buttonSaveSettings
            // 
            this.buttonSaveSettings.Location = new System.Drawing.Point(23, 101);
            this.buttonSaveSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveSettings.Name = "buttonSaveSettings";
            this.buttonSaveSettings.Size = new System.Drawing.Size(104, 26);
            this.buttonSaveSettings.TabIndex = 8;
            this.buttonSaveSettings.Text = "Save Settings";
            this.buttonSaveSettings.UseVisualStyleBackColor = true;
            this.buttonSaveSettings.Visible = false;
            this.buttonSaveSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            this.buttonSaveSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSaveSettings_MouseClick);
            // 
            // buttonCancelSettings
            // 
            this.buttonCancelSettings.Location = new System.Drawing.Point(139, 101);
            this.buttonCancelSettings.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelSettings.Name = "buttonCancelSettings";
            this.buttonCancelSettings.Size = new System.Drawing.Size(99, 26);
            this.buttonCancelSettings.TabIndex = 9;
            this.buttonCancelSettings.Text = "Cancel";
            this.buttonCancelSettings.UseVisualStyleBackColor = true;
            this.buttonCancelSettings.Visible = false;
            this.buttonCancelSettings.Click += new System.EventHandler(this.buttonCancelSettings_Click);
            this.buttonCancelSettings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonCancelSettings_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 91);
            this.label3.TabIndex = 10;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // buttonFirewall
            // 
            this.buttonFirewall.Location = new System.Drawing.Point(22, 284);
            this.buttonFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirewall.Name = "buttonFirewall";
            this.buttonFirewall.Size = new System.Drawing.Size(92, 24);
            this.buttonFirewall.TabIndex = 14;
            this.buttonFirewall.Text = "Add firewall rule";
            this.buttonFirewall.UseVisualStyleBackColor = true;
            this.buttonFirewall.Click += new System.EventHandler(this.buttonFirewall_Click);
            this.buttonFirewall.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonFirewall_MouseClick);
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(118, 284);
            this.buttonTask.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(118, 24);
            this.buttonTask.TabIndex = 15;
            this.buttonTask.Text = "Auto Start at logon";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            this.buttonTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonTask_MouseClick);
            // 
            // ImgWinbackground
            // 
            this.ImgWinbackground.Image = global::RemoteServer.Properties.Resources.WinBackgrond1;
            this.ImgWinbackground.Location = new System.Drawing.Point(334, 175);
            this.ImgWinbackground.Margin = new System.Windows.Forms.Padding(2);
            this.ImgWinbackground.Name = "ImgWinbackground";
            this.ImgWinbackground.Size = new System.Drawing.Size(46, 102);
            this.ImgWinbackground.TabIndex = 12;
            this.ImgWinbackground.TabStop = false;
            this.ImgWinbackground.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 341);
            this.Controls.Add(this.ImgWinbackground);
            this.Controls.Add(this.textDebug);
            this.Controls.Add(this.buttonCancelSettings);
            this.Controls.Add(this.buttonSaveSettings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonFirewall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Remote Desktop Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgWinbackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textDebug;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button buttonSaveSettings;
        private System.Windows.Forms.Button buttonCancelSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ImgWinbackground;
        private System.Windows.Forms.Button buttonFirewall;
        private System.Windows.Forms.Button buttonTask;
    }
}

