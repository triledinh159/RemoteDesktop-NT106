namespace RemoteClient
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
            this.TaskBar = new System.Windows.Forms.GroupBox();
            this.buttonMenu = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.PictureBox();
            this.buttonRestore = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TrackWidth = new System.Windows.Forms.HScrollBar();
            this.TrackHeight = new System.Windows.Forms.VScrollBar();
            this.checkLeftMenu = new System.Windows.Forms.CheckBox();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.buttonDisconect = new System.Windows.Forms.Button();
            this.TrackSpeed = new System.Windows.Forms.TrackBar();
            this.buttonMetro = new System.Windows.Forms.Button();
            this.buttonSendCtrlAltDel = new System.Windows.Forms.Button();
            this.buttonSendStart = new System.Windows.Forms.Button();
            this.checkEncrypted = new System.Windows.Forms.CheckBox();
            this.checkSendKeyboardAndMouse = new System.Windows.Forms.CheckBox();
            this.checkDebug = new System.Windows.Forms.CheckBox();
            this.checkResoloution = new System.Windows.Forms.CheckBox();
            this.checkScale = new System.Windows.Forms.CheckBox();
            this.checkLeftMenuConnect = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.checkBlackWallpaper = new System.Windows.Forms.CheckBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIPAddress = new System.Windows.Forms.TextBox();
            this.buttonMenuSmall = new System.Windows.Forms.Button();
            this.GroupConected = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupConnect = new System.Windows.Forms.GroupBox();
            this.buttonFirewall = new System.Windows.Forms.Button();
            this.ImgDefaultBackground = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.theImage = new System.Windows.Forms.PictureBox();
            this.TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).BeginInit();
            this.GroupConected.SuspendLayout();
            this.GroupConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDefaultBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.SlateGray;
            this.TaskBar.Controls.Add(this.buttonMenu);
            this.TaskBar.Controls.Add(this.buttonMinimize);
            this.TaskBar.Controls.Add(this.buttonRestore);
            this.TaskBar.Controls.Add(this.buttonClose);
            this.TaskBar.Controls.Add(this.LblTitle);
            this.TaskBar.Location = new System.Drawing.Point(28, 9);
            this.TaskBar.Margin = new System.Windows.Forms.Padding(2);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Padding = new System.Windows.Forms.Padding(2);
            this.TaskBar.Size = new System.Drawing.Size(345, 31);
            this.TaskBar.TabIndex = 1;
            this.TaskBar.TabStop = false;
            this.TaskBar.Visible = false;
            this.TaskBar.MouseHover += new System.EventHandler(this.TaskBar_MouseHover);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Image = global::RemoteClient.Properties.Resources.Menu;
            this.buttonMenu.Location = new System.Drawing.Point(4, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(23, 16);
            this.buttonMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMenu.TabIndex = 52;
            this.buttonMenu.TabStop = false;
            this.buttonMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMenu_MouseClick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Location = new System.Drawing.Point(262, 8);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(23, 16);
            this.buttonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonMinimize.TabIndex = 51;
            this.buttonMinimize.TabStop = false;
            this.toolTip.SetToolTip(this.buttonMinimize, "Minimize window");
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseHover += new System.EventHandler(this.buttonMinimize_MouseHover);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Image = global::RemoteClient.Properties.Resources.Restore;
            this.buttonRestore.Location = new System.Drawing.Point(290, 8);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(23, 16);
            this.buttonRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonRestore.TabIndex = 50;
            this.buttonRestore.TabStop = false;
            this.toolTip.SetToolTip(this.buttonRestore, "Restore window");
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            this.buttonRestore.MouseHover += new System.EventHandler(this.buttonRestore_MouseHover);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::RemoteClient.Properties.Resources.Max;
            this.buttonClose.Location = new System.Drawing.Point(317, 8);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 16);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonClose.TabIndex = 49;
            this.buttonClose.TabStop = false;
            this.toolTip.SetToolTip(this.buttonClose, "Close window");
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseHover += new System.EventHandler(this.buttonClose_MouseHover);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(141, 10);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(93, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "127.0.0.1:4000";
            // 
            // TrackWidth
            // 
            this.TrackWidth.Location = new System.Drawing.Point(27, 234);
            this.TrackWidth.Maximum = 2570;
            this.TrackWidth.Minimum = 800;
            this.TrackWidth.Name = "TrackWidth";
            this.TrackWidth.Size = new System.Drawing.Size(298, 10);
            this.TrackWidth.TabIndex = 57;
            this.toolTip.SetToolTip(this.TrackWidth, "Desktop width");
            this.TrackWidth.Value = 800;
            this.TrackWidth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackWidth_Scroll);
            // 
            // TrackHeight
            // 
            this.TrackHeight.Location = new System.Drawing.Point(329, 18);
            this.TrackHeight.Maximum = 2000;
            this.TrackHeight.Minimum = 600;
            this.TrackHeight.Name = "TrackHeight";
            this.TrackHeight.Size = new System.Drawing.Size(15, 198);
            this.TrackHeight.TabIndex = 56;
            this.toolTip.SetToolTip(this.TrackHeight, "Desktop Height");
            this.TrackHeight.Value = 690;
            this.TrackHeight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackHeight_Scroll);
            // 
            // checkLeftMenu
            // 
            this.checkLeftMenu.AutoSize = true;
            this.checkLeftMenu.BackColor = System.Drawing.Color.Transparent;
            this.checkLeftMenu.Location = new System.Drawing.Point(59, 94);
            this.checkLeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.checkLeftMenu.Name = "checkLeftMenu";
            this.checkLeftMenu.Size = new System.Drawing.Size(74, 17);
            this.checkLeftMenu.TabIndex = 54;
            this.checkLeftMenu.Text = "Left Menu";
            this.toolTip.SetToolTip(this.checkLeftMenu, "Move menu to the left");
            this.checkLeftMenu.UseVisualStyleBackColor = false;
            this.checkLeftMenu.CheckedChanged += new System.EventHandler(this.checkLeftMenu_CheckedChanged);
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.Location = new System.Drawing.Point(116, 180);
            this.buttonShutDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(69, 27);
            this.buttonShutDown.TabIndex = 48;
            this.buttonShutDown.Text = "Shut down";
            this.toolTip.SetToolTip(this.buttonShutDown, "Shut down remote server");
            this.buttonShutDown.UseVisualStyleBackColor = true;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // buttonDisconect
            // 
            this.buttonDisconect.Location = new System.Drawing.Point(40, 180);
            this.buttonDisconect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconect.Name = "buttonDisconect";
            this.buttonDisconect.Size = new System.Drawing.Size(72, 27);
            this.buttonDisconect.TabIndex = 46;
            this.buttonDisconect.Text = "Disconect";
            this.toolTip.SetToolTip(this.buttonDisconect, "Disconnect desktop");
            this.buttonDisconect.UseVisualStyleBackColor = true;
            this.buttonDisconect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonDisconect_MouseClick);
            // 
            // TrackSpeed
            // 
            this.TrackSpeed.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TrackSpeed.Location = new System.Drawing.Point(61, 130);
            this.TrackSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.TrackSpeed.Maximum = 10000;
            this.TrackSpeed.Minimum = 2;
            this.TrackSpeed.Name = "TrackSpeed";
            this.TrackSpeed.Size = new System.Drawing.Size(106, 45);
            this.TrackSpeed.TabIndex = 47;
            this.toolTip.SetToolTip(this.TrackSpeed, "Refresh Speed");
            this.TrackSpeed.Value = 2000;
            this.TrackSpeed.Scroll += new System.EventHandler(this.TrackSpeed_Scroll);
            // 
            // buttonMetro
            // 
            this.buttonMetro.Location = new System.Drawing.Point(184, 18);
            this.buttonMetro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMetro.Name = "buttonMetro";
            this.buttonMetro.Size = new System.Drawing.Size(69, 24);
            this.buttonMetro.TabIndex = 51;
            this.buttonMetro.Text = "Metro";
            this.toolTip.SetToolTip(this.buttonMetro, "Show Metro menu button on remote machine");
            this.buttonMetro.UseVisualStyleBackColor = true;
            this.buttonMetro.Click += new System.EventHandler(this.buttonMetro_Click);
            // 
            // buttonSendCtrlAltDel
            // 
            this.buttonSendCtrlAltDel.Location = new System.Drawing.Point(116, 18);
            this.buttonSendCtrlAltDel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendCtrlAltDel.Name = "buttonSendCtrlAltDel";
            this.buttonSendCtrlAltDel.Size = new System.Drawing.Size(64, 24);
            this.buttonSendCtrlAltDel.TabIndex = 50;
            this.buttonSendCtrlAltDel.Text = "Task man";
            this.toolTip.SetToolTip(this.buttonSendCtrlAltDel, "Show task-manger button on remote machine");
            this.buttonSendCtrlAltDel.UseVisualStyleBackColor = true;
            this.buttonSendCtrlAltDel.Click += new System.EventHandler(this.buttonSendCtrlAltDel_Click);
            // 
            // buttonSendStart
            // 
            this.buttonSendStart.Location = new System.Drawing.Point(40, 18);
            this.buttonSendStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSendStart.Name = "buttonSendStart";
            this.buttonSendStart.Size = new System.Drawing.Size(72, 24);
            this.buttonSendStart.TabIndex = 49;
            this.buttonSendStart.Text = "Start button";
            this.toolTip.SetToolTip(this.buttonSendStart, "Press start button on remote machine");
            this.buttonSendStart.UseVisualStyleBackColor = true;
            this.buttonSendStart.Click += new System.EventHandler(this.buttonSendStart_Click);
            // 
            // checkEncrypted
            // 
            this.checkEncrypted.AutoSize = true;
            this.checkEncrypted.BackColor = System.Drawing.Color.Transparent;
            this.checkEncrypted.Location = new System.Drawing.Point(151, 94);
            this.checkEncrypted.Margin = new System.Windows.Forms.Padding(2);
            this.checkEncrypted.Name = "checkEncrypted";
            this.checkEncrypted.Size = new System.Drawing.Size(74, 17);
            this.checkEncrypted.TabIndex = 45;
            this.checkEncrypted.Text = "Encrypted";
            this.toolTip.SetToolTip(this.checkEncrypted, "Encrypt remote desktop connection");
            this.checkEncrypted.UseVisualStyleBackColor = false;
            this.checkEncrypted.CheckedChanged += new System.EventHandler(this.checkEncrypted_CheckedChanged);
            // 
            // checkSendKeyboardAndMouse
            // 
            this.checkSendKeyboardAndMouse.AutoSize = true;
            this.checkSendKeyboardAndMouse.BackColor = System.Drawing.Color.Transparent;
            this.checkSendKeyboardAndMouse.Checked = true;
            this.checkSendKeyboardAndMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSendKeyboardAndMouse.Location = new System.Drawing.Point(151, 50);
            this.checkSendKeyboardAndMouse.Margin = new System.Windows.Forms.Padding(2);
            this.checkSendKeyboardAndMouse.Name = "checkSendKeyboardAndMouse";
            this.checkSendKeyboardAndMouse.Size = new System.Drawing.Size(107, 17);
            this.checkSendKeyboardAndMouse.TabIndex = 41;
            this.checkSendKeyboardAndMouse.Text = "Control Keyboard";
            this.toolTip.SetToolTip(this.checkSendKeyboardAndMouse, "Control the remote desktop");
            this.checkSendKeyboardAndMouse.UseVisualStyleBackColor = false;
            this.checkSendKeyboardAndMouse.CheckedChanged += new System.EventHandler(this.checkSendKeyboardAndMouse_CheckedChanged);
            // 
            // checkDebug
            // 
            this.checkDebug.AutoSize = true;
            this.checkDebug.BackColor = System.Drawing.Color.Transparent;
            this.checkDebug.Location = new System.Drawing.Point(59, 50);
            this.checkDebug.Margin = new System.Windows.Forms.Padding(2);
            this.checkDebug.Name = "checkDebug";
            this.checkDebug.Size = new System.Drawing.Size(58, 17);
            this.checkDebug.TabIndex = 40;
            this.checkDebug.Text = "Debug";
            this.toolTip.SetToolTip(this.checkDebug, "SShow debug on remote desktop");
            this.checkDebug.UseVisualStyleBackColor = false;
            this.checkDebug.CheckedChanged += new System.EventHandler(this.checkDebug_CheckedChanged);
            // 
            // checkResoloution
            // 
            this.checkResoloution.AutoSize = true;
            this.checkResoloution.BackColor = System.Drawing.Color.Transparent;
            this.checkResoloution.Location = new System.Drawing.Point(151, 72);
            this.checkResoloution.Margin = new System.Windows.Forms.Padding(2);
            this.checkResoloution.Name = "checkResoloution";
            this.checkResoloution.Size = new System.Drawing.Size(94, 17);
            this.checkResoloution.TabIndex = 39;
            this.checkResoloution.Text = "32 Bit desktop";
            this.toolTip.SetToolTip(this.checkResoloution, "Show 32bit desktop");
            this.checkResoloution.UseVisualStyleBackColor = false;
            this.checkResoloution.CheckedChanged += new System.EventHandler(this.checkResoloution_CheckedChanged);
            // 
            // checkScale
            // 
            this.checkScale.AutoSize = true;
            this.checkScale.BackColor = System.Drawing.Color.Transparent;
            this.checkScale.Location = new System.Drawing.Point(59, 72);
            this.checkScale.Margin = new System.Windows.Forms.Padding(2);
            this.checkScale.Name = "checkScale";
            this.checkScale.Size = new System.Drawing.Size(72, 17);
            this.checkScale.TabIndex = 38;
            this.checkScale.Text = "Compress";
            this.toolTip.SetToolTip(this.checkScale, "Compress data to speed up");
            this.checkScale.UseVisualStyleBackColor = false;
            this.checkScale.CheckedChanged += new System.EventHandler(this.checkScale_CheckedChanged);
            // 
            // checkLeftMenuConnect
            // 
            this.checkLeftMenuConnect.AutoSize = true;
            this.checkLeftMenuConnect.BackColor = System.Drawing.Color.Transparent;
            this.checkLeftMenuConnect.Location = new System.Drawing.Point(33, 107);
            this.checkLeftMenuConnect.Margin = new System.Windows.Forms.Padding(2);
            this.checkLeftMenuConnect.Name = "checkLeftMenuConnect";
            this.checkLeftMenuConnect.Size = new System.Drawing.Size(74, 17);
            this.checkLeftMenuConnect.TabIndex = 57;
            this.checkLeftMenuConnect.Text = "Left Menu";
            this.toolTip.SetToolTip(this.checkLeftMenuConnect, "Scale the remote desktop image down");
            this.checkLeftMenuConnect.UseVisualStyleBackColor = false;
            this.checkLeftMenuConnect.CheckedChanged += new System.EventHandler(this.checkLeftMenuConnect_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(112, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 23);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.Text = "letmein";
            this.toolTip.SetToolTip(this.txtPassword, "Remote desktop IP-Address");
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(27, 145);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(72, 24);
            this.buttonConnect.TabIndex = 46;
            this.buttonConnect.Text = "Connect";
            this.toolTip.SetToolTip(this.buttonConnect, "Connect to the remote desktop");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            this.buttonConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonConnect_MouseClick);
            // 
            // checkBlackWallpaper
            // 
            this.checkBlackWallpaper.AutoSize = true;
            this.checkBlackWallpaper.BackColor = System.Drawing.Color.Transparent;
            this.checkBlackWallpaper.Checked = true;
            this.checkBlackWallpaper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBlackWallpaper.Location = new System.Drawing.Point(112, 107);
            this.checkBlackWallpaper.Margin = new System.Windows.Forms.Padding(2);
            this.checkBlackWallpaper.Name = "checkBlackWallpaper";
            this.checkBlackWallpaper.Size = new System.Drawing.Size(104, 17);
            this.checkBlackWallpaper.TabIndex = 45;
            this.checkBlackWallpaper.Text = "Black Wallpaper";
            this.toolTip.SetToolTip(this.checkBlackWallpaper, "Use black remote desktop");
            this.checkBlackWallpaper.UseVisualStyleBackColor = false;
            this.checkBlackWallpaper.CheckedChanged += new System.EventHandler(this.checkBlackWallpaper_CheckedChanged_1);
            // 
            // TxtPort
            // 
            this.TxtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.ForeColor = System.Drawing.Color.Red;
            this.TxtPort.Location = new System.Drawing.Point(112, 45);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(131, 23);
            this.TxtPort.TabIndex = 7;
            this.TxtPort.Text = "4000";
            this.toolTip.SetToolTip(this.TxtPort, "Remote desktop port");
            this.TxtPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPort_KeyDown);
            // 
            // TxtIPAddress
            // 
            this.TxtIPAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIPAddress.ForeColor = System.Drawing.Color.Red;
            this.TxtIPAddress.Location = new System.Drawing.Point(112, 20);
            this.TxtIPAddress.Name = "TxtIPAddress";
            this.TxtIPAddress.Size = new System.Drawing.Size(131, 23);
            this.TxtIPAddress.TabIndex = 6;
            this.TxtIPAddress.Text = "10.10.10.25";
            this.toolTip.SetToolTip(this.TxtIPAddress, "Remote desktop IP-Address");
            this.TxtIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIPAddress_KeyDown);
            // 
            // buttonMenuSmall
            // 
            this.buttonMenuSmall.BackgroundImage = global::RemoteClient.Properties.Resources.Menu;
            this.buttonMenuSmall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuSmall.Location = new System.Drawing.Point(0, 5);
            this.buttonMenuSmall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMenuSmall.Name = "buttonMenuSmall";
            this.buttonMenuSmall.Size = new System.Drawing.Size(23, 17);
            this.buttonMenuSmall.TabIndex = 53;
            this.toolTip.SetToolTip(this.buttonMenuSmall, "Show/Hide Menu");
            this.buttonMenuSmall.UseVisualStyleBackColor = true;
            this.buttonMenuSmall.Visible = false;
            this.buttonMenuSmall.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMenuSmall_MouseDown);
            this.buttonMenuSmall.MouseHover += new System.EventHandler(this.buttonMenuSmall_MouseHover);
            // 
            // GroupConected
            // 
            this.GroupConected.BackgroundImage = global::RemoteClient.Properties.Resources.GroupBackground;
            this.GroupConected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupConected.Controls.Add(this.label6);
            this.GroupConected.Controls.Add(this.TrackWidth);
            this.GroupConected.Controls.Add(this.TrackHeight);
            this.GroupConected.Controls.Add(this.checkLeftMenu);
            this.GroupConected.Controls.Add(this.buttonShutDown);
            this.GroupConected.Controls.Add(this.buttonDisconect);
            this.GroupConected.Controls.Add(this.label4);
            this.GroupConected.Controls.Add(this.label5);
            this.GroupConected.Controls.Add(this.TrackSpeed);
            this.GroupConected.Controls.Add(this.buttonMetro);
            this.GroupConected.Controls.Add(this.buttonSendCtrlAltDel);
            this.GroupConected.Controls.Add(this.buttonSendStart);
            this.GroupConected.Controls.Add(this.checkEncrypted);
            this.GroupConected.Controls.Add(this.checkSendKeyboardAndMouse);
            this.GroupConected.Controls.Add(this.checkDebug);
            this.GroupConected.Controls.Add(this.checkResoloution);
            this.GroupConected.Controls.Add(this.checkScale);
            this.GroupConected.Location = new System.Drawing.Point(28, 45);
            this.GroupConected.Margin = new System.Windows.Forms.Padding(2);
            this.GroupConected.Name = "GroupConected";
            this.GroupConected.Padding = new System.Windows.Forms.Padding(2);
            this.GroupConected.Size = new System.Drawing.Size(345, 255);
            this.GroupConected.TabIndex = 2;
            this.GroupConected.TabStop = false;
            this.GroupConected.Visible = false;
            this.GroupConected.MouseHover += new System.EventHandler(this.GroupConected_MouseHover);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(57, 162);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "       Refresh Speed";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(58, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(153, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "+";
            // 
            // GroupConnect
            // 
            this.GroupConnect.BackgroundImage = global::RemoteClient.Properties.Resources.GroupBackground;
            this.GroupConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupConnect.Controls.Add(this.checkLeftMenuConnect);
            this.GroupConnect.Controls.Add(this.buttonFirewall);
            this.GroupConnect.Controls.Add(this.ImgDefaultBackground);
            this.GroupConnect.Controls.Add(this.txtPassword);
            this.GroupConnect.Controls.Add(this.label3);
            this.GroupConnect.Controls.Add(this.buttonConnect);
            this.GroupConnect.Controls.Add(this.checkBlackWallpaper);
            this.GroupConnect.Controls.Add(this.TxtPort);
            this.GroupConnect.Controls.Add(this.TxtIPAddress);
            this.GroupConnect.Controls.Add(this.label2);
            this.GroupConnect.Controls.Add(this.label1);
            this.GroupConnect.Location = new System.Drawing.Point(28, 197);
            this.GroupConnect.Margin = new System.Windows.Forms.Padding(2);
            this.GroupConnect.Name = "GroupConnect";
            this.GroupConnect.Padding = new System.Windows.Forms.Padding(2);
            this.GroupConnect.Size = new System.Drawing.Size(345, 188);
            this.GroupConnect.TabIndex = 3;
            this.GroupConnect.TabStop = false;
            // 
            // buttonFirewall
            // 
            this.buttonFirewall.Location = new System.Drawing.Point(112, 145);
            this.buttonFirewall.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFirewall.Name = "buttonFirewall";
            this.buttonFirewall.Size = new System.Drawing.Size(72, 24);
            this.buttonFirewall.TabIndex = 56;
            this.buttonFirewall.Text = "Firewall";
            this.buttonFirewall.UseVisualStyleBackColor = true;
            this.buttonFirewall.Click += new System.EventHandler(this.buttonFirewall_Click);
            // 
            // ImgDefaultBackground
            // 
            this.ImgDefaultBackground.Image = global::RemoteClient.Properties.Resources.DefaultBackground;
            this.ImgDefaultBackground.Location = new System.Drawing.Point(247, 22);
            this.ImgDefaultBackground.Margin = new System.Windows.Forms.Padding(2);
            this.ImgDefaultBackground.Name = "ImgDefaultBackground";
            this.ImgDefaultBackground.Size = new System.Drawing.Size(22, 102);
            this.ImgDefaultBackground.TabIndex = 55;
            this.ImgDefaultBackground.TabStop = false;
            this.ImgDefaultBackground.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // theImage
            // 
            this.theImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theImage.Image = global::RemoteClient.Properties.Resources.DefaultBackground;
            this.theImage.Location = new System.Drawing.Point(0, 0);
            this.theImage.Margin = new System.Windows.Forms.Padding(0);
            this.theImage.Name = "theImage";
            this.theImage.Size = new System.Drawing.Size(416, 407);
            this.theImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theImage.TabIndex = 54;
            this.theImage.TabStop = false;
            this.theImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseClick);
            this.theImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseDown);
            this.theImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseMove);
            this.theImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseUp);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 407);
            this.Controls.Add(this.GroupConected);
            this.Controls.Add(this.GroupConnect);
            this.Controls.Add(this.TaskBar);
            this.Controls.Add(this.buttonMenuSmall);
            this.Controls.Add(this.theImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Menu";
            this.Text = "Remote Client";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Menu_KeyUp);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.TaskBar.ResumeLayout(false);
            this.TaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackSpeed)).EndInit();
            this.GroupConected.ResumeLayout(false);
            this.GroupConected.PerformLayout();
            this.GroupConnect.ResumeLayout(false);
            this.GroupConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgDefaultBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TaskBar;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.GroupBox GroupConected;
        private System.Windows.Forms.CheckBox checkEncrypted;
        private System.Windows.Forms.CheckBox checkSendKeyboardAndMouse;
        private System.Windows.Forms.CheckBox checkDebug;
        private System.Windows.Forms.CheckBox checkResoloution;
        private System.Windows.Forms.CheckBox checkScale;
        private System.Windows.Forms.GroupBox GroupConnect;
        private System.Windows.Forms.Button buttonDisconect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.CheckBox checkBlackWallpaper;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TrackSpeed;
        private System.Windows.Forms.Button buttonShutDown;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.PictureBox buttonRestore;
        private System.Windows.Forms.PictureBox buttonMinimize;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonMenuSmall;
        private System.Windows.Forms.Button buttonSendCtrlAltDel;
        private System.Windows.Forms.Button buttonSendStart;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMetro;
        private System.Windows.Forms.PictureBox ImgDefaultBackground;
        private System.Windows.Forms.Button buttonFirewall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox theImage;
        private System.Windows.Forms.CheckBox checkLeftMenu;
        private System.Windows.Forms.CheckBox checkLeftMenuConnect;
        private System.Windows.Forms.PictureBox buttonMenu;
        private System.Windows.Forms.VScrollBar TrackHeight;
        private System.Windows.Forms.HScrollBar TrackWidth;
        private System.Windows.Forms.Label label6;
    }
}