namespace ElevatorControl_sem3
{
    partial class Elevator
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
            this.tmrLiftdown = new System.Windows.Forms.Timer(this.components);
            this.tmrLiftup = new System.Windows.Forms.Timer(this.components);
            this.tmr_Open_door1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_Open_Door0 = new System.Windows.Forms.Timer(this.components);
            this.tmr_Close_Door1 = new System.Windows.Forms.Timer(this.components);
            this.tmr_Close_Door0 = new System.Windows.Forms.Timer(this.components);
            this.pnlWhole = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.Log_lstBox = new System.Windows.Forms.ListBox();
            this.lblControlpanel = new System.Windows.Forms.Label();
            this.groundFloor_txtBox = new System.Windows.Forms.TextBox();
            this.firstfloor_txtBox = new System.Windows.Forms.TextBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.Database_lstBox = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearSaved = new System.Windows.Forms.Button();
            this.btnDisplayDBLog = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnGround = new System.Windows.Forms.Button();
            this.btnAlert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlCavity = new System.Windows.Forms.Panel();
            this.pnlLiftmove = new System.Windows.Forms.Panel();
            this.picleftdoorat1 = new System.Windows.Forms.PictureBox();
            this.picrightdoorat1 = new System.Windows.Forms.PictureBox();
            this.picrightdoorat0 = new System.Windows.Forms.PictureBox();
            this.picbuttomat1 = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picleftdoorat0 = new System.Windows.Forms.PictureBox();
            this.pnlLift = new System.Windows.Forms.Panel();
            this.picButtom = new System.Windows.Forms.PictureBox();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblUnsaved = new System.Windows.Forms.Label();
            this.lblSaved = new System.Windows.Forms.Label();
            this.pnlWhole.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.pnlCavity.SuspendLayout();
            this.pnlLiftmove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picleftdoorat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightdoorat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightdoorat0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuttomat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picleftdoorat0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtom)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrLiftdown
            // 
            this.tmrLiftdown.Interval = 5;
            this.tmrLiftdown.Tick += new System.EventHandler(this.tmrLiftdown_Tick);
            // 
            // tmrLiftup
            // 
            this.tmrLiftup.Interval = 5;
            this.tmrLiftup.Tick += new System.EventHandler(this.tmrLiftup_Tick);
            // 
            // tmr_Open_door1
            // 
            this.tmr_Open_door1.Interval = 10;
            this.tmr_Open_door1.Tick += new System.EventHandler(this.tmr_Open_door1_Tick);
            // 
            // tmr_Open_Door0
            // 
            this.tmr_Open_Door0.Interval = 10;
            this.tmr_Open_Door0.Tick += new System.EventHandler(this.tmr_Open_Door0_Tick);
            // 
            // tmr_Close_Door1
            // 
            this.tmr_Close_Door1.Interval = 10;
            this.tmr_Close_Door1.Tick += new System.EventHandler(this.tmr_Close_Door1_Tick);
            // 
            // tmr_Close_Door0
            // 
            this.tmr_Close_Door0.Interval = 10;
            this.tmr_Close_Door0.Tick += new System.EventHandler(this.tmr_Close_Door0_Tick_1);
            // 
            // pnlWhole
            // 
            this.pnlWhole.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.wall_images;
            this.pnlWhole.Controls.Add(this.lblSaved);
            this.pnlWhole.Controls.Add(this.lblUnsaved);
            this.pnlWhole.Controls.Add(this.lblActions);
            this.pnlWhole.Controls.Add(this.lblTimes);
            this.pnlWhole.Controls.Add(this.lblDates);
            this.pnlWhole.Controls.Add(this.BtnClear);
            this.pnlWhole.Controls.Add(this.btnSaveLog);
            this.pnlWhole.Controls.Add(this.Log_lstBox);
            this.pnlWhole.Controls.Add(this.lblControlpanel);
            this.pnlWhole.Controls.Add(this.groundFloor_txtBox);
            this.pnlWhole.Controls.Add(this.firstfloor_txtBox);
            this.pnlWhole.Controls.Add(this.lblAction);
            this.pnlWhole.Controls.Add(this.lblDate);
            this.pnlWhole.Controls.Add(this.lblTime);
            this.pnlWhole.Controls.Add(this.lblId);
            this.pnlWhole.Controls.Add(this.Database_lstBox);
            this.pnlWhole.Controls.Add(this.btnExit);
            this.pnlWhole.Controls.Add(this.btnClearSaved);
            this.pnlWhole.Controls.Add(this.btnDisplayDBLog);
            this.pnlWhole.Controls.Add(this.btnDown);
            this.pnlWhole.Controls.Add(this.btnUp);
            this.pnlWhole.Controls.Add(this.pnlControl);
            this.pnlWhole.Controls.Add(this.pnlCavity);
            this.pnlWhole.Controls.Add(this.pnlMiddle);
            this.pnlWhole.Location = new System.Drawing.Point(1, 0);
            this.pnlWhole.Name = "pnlWhole";
            this.pnlWhole.Size = new System.Drawing.Size(1493, 838);
            this.pnlWhole.TabIndex = 0;
            this.pnlWhole.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlWhole_Paint);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(904, 312);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(112, 43);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "Clear Log";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLog.Location = new System.Drawing.Point(777, 312);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(112, 43);
            this.btnSaveLog.TabIndex = 18;
            this.btnSaveLog.Text = "Save  Logs";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // Log_lstBox
            // 
            this.Log_lstBox.FormattingEnabled = true;
            this.Log_lstBox.ItemHeight = 16;
            this.Log_lstBox.Location = new System.Drawing.Point(777, 62);
            this.Log_lstBox.Name = "Log_lstBox";
            this.Log_lstBox.Size = new System.Drawing.Size(668, 244);
            this.Log_lstBox.TabIndex = 17;
            // 
            // lblControlpanel
            // 
            this.lblControlpanel.AutoSize = true;
            this.lblControlpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlpanel.Location = new System.Drawing.Point(545, 93);
            this.lblControlpanel.Name = "lblControlpanel";
            this.lblControlpanel.Size = new System.Drawing.Size(179, 17);
            this.lblControlpanel.TabIndex = 16;
            this.lblControlpanel.Text = "Elevator Panel Controls";
            // 
            // groundFloor_txtBox
            // 
            this.groundFloor_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groundFloor_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundFloor_txtBox.ForeColor = System.Drawing.Color.Black;
            this.groundFloor_txtBox.Location = new System.Drawing.Point(7, 486);
            this.groundFloor_txtBox.Name = "groundFloor_txtBox";
            this.groundFloor_txtBox.Size = new System.Drawing.Size(152, 30);
            this.groundFloor_txtBox.TabIndex = 15;
            this.groundFloor_txtBox.Text = "Ground Floor";
            this.groundFloor_txtBox.TextChanged += new System.EventHandler(this.groundFloor_txtBox_TextChanged);
            // 
            // firstfloor_txtBox
            // 
            this.firstfloor_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.firstfloor_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstfloor_txtBox.ForeColor = System.Drawing.Color.Black;
            this.firstfloor_txtBox.Location = new System.Drawing.Point(13, 40);
            this.firstfloor_txtBox.Name = "firstfloor_txtBox";
            this.firstfloor_txtBox.Size = new System.Drawing.Size(132, 30);
            this.firstfloor_txtBox.TabIndex = 14;
            this.firstfloor_txtBox.Text = "First Floor\r\n\r\n";
            this.firstfloor_txtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.Location = new System.Drawing.Point(1231, 413);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(67, 25);
            this.lblAction.TabIndex = 13;
            this.lblAction.Text = "Action";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(852, 413);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1042, 411);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(56, 25);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "Time";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(790, 413);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 24);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // Database_lstBox
            // 
            this.Database_lstBox.FormattingEnabled = true;
            this.Database_lstBox.ItemHeight = 16;
            this.Database_lstBox.Location = new System.Drawing.Point(781, 440);
            this.Database_lstBox.Name = "Database_lstBox";
            this.Database_lstBox.Size = new System.Drawing.Size(668, 356);
            this.Database_lstBox.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1335, 802);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 43);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearSaved
            // 
            this.btnClearSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSaved.Location = new System.Drawing.Point(935, 802);
            this.btnClearSaved.Name = "btnClearSaved";
            this.btnClearSaved.Size = new System.Drawing.Size(112, 43);
            this.btnClearSaved.TabIndex = 7;
            this.btnClearSaved.Text = "Clear Saved Log";
            this.btnClearSaved.UseVisualStyleBackColor = true;
            // 
            // btnDisplayDBLog
            // 
            this.btnDisplayDBLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayDBLog.Location = new System.Drawing.Point(786, 802);
            this.btnDisplayDBLog.Name = "btnDisplayDBLog";
            this.btnDisplayDBLog.Size = new System.Drawing.Size(112, 43);
            this.btnDisplayDBLog.TabIndex = 6;
            this.btnDisplayDBLog.Text = "Display Saved Logs";
            this.btnDisplayDBLog.UseVisualStyleBackColor = true;
            this.btnDisplayDBLog.Click += new System.EventHandler(this.btnDisplayDBLog_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Control;
            this.btnDown.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.down_button;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.Location = new System.Drawing.Point(429, 158);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(65, 65);
            this.btnDown.TabIndex = 2;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.up_button;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(429, 576);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(65, 65);
            this.btnUp.TabIndex = 3;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlControl.Controls.Add(this.picDisplay);
            this.pnlControl.Controls.Add(this.btnFirst);
            this.pnlControl.Controls.Add(this.btnGround);
            this.pnlControl.Controls.Add(this.btnAlert);
            this.pnlControl.Controls.Add(this.btnClose);
            this.pnlControl.Controls.Add(this.btnOpen);
            this.pnlControl.Location = new System.Drawing.Point(532, 110);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(205, 490);
            this.pnlControl.TabIndex = 4;
            // 
            // picDisplay
            // 
            this.picDisplay.Image = global::ElevatorControl_sem3.Properties.Resources.one_image;
            this.picDisplay.InitialImage = null;
            this.picDisplay.Location = new System.Drawing.Point(53, 15);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(105, 74);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 5;
            this.picDisplay.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.one_image;
            this.btnFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFirst.Location = new System.Drawing.Point(71, 134);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(65, 65);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnGround
            // 
            this.btnGround.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.ground_button;
            this.btnGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGround.Location = new System.Drawing.Point(71, 221);
            this.btnGround.Name = "btnGround";
            this.btnGround.Size = new System.Drawing.Size(65, 65);
            this.btnGround.TabIndex = 3;
            this.btnGround.UseVisualStyleBackColor = true;
            this.btnGround.Click += new System.EventHandler(this.btnGround_Click);
            // 
            // btnAlert
            // 
            this.btnAlert.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.alert_bell_image;
            this.btnAlert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlert.Location = new System.Drawing.Point(71, 403);
            this.btnAlert.Name = "btnAlert";
            this.btnAlert.Size = new System.Drawing.Size(65, 65);
            this.btnAlert.TabIndex = 2;
            this.btnAlert.UseVisualStyleBackColor = true;
            this.btnAlert.Click += new System.EventHandler(this.btnAlert_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.closebutton;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(125, 295);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 65);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.open_button;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Location = new System.Drawing.Point(22, 295);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(65, 65);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlCavity
            // 
            this.pnlCavity.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.door_frame;
            this.pnlCavity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCavity.Controls.Add(this.pnlLiftmove);
            this.pnlCavity.Controls.Add(this.picButtom);
            this.pnlCavity.Location = new System.Drawing.Point(165, 11);
            this.pnlCavity.Name = "pnlCavity";
            this.pnlCavity.Size = new System.Drawing.Size(258, 750);
            this.pnlCavity.TabIndex = 0;
            // 
            // pnlLiftmove
            // 
            this.pnlLiftmove.Controls.Add(this.picleftdoorat1);
            this.pnlLiftmove.Controls.Add(this.picrightdoorat1);
            this.pnlLiftmove.Controls.Add(this.picrightdoorat0);
            this.pnlLiftmove.Controls.Add(this.picbuttomat1);
            this.pnlLiftmove.Controls.Add(this.picTop);
            this.pnlLiftmove.Controls.Add(this.picleftdoorat0);
            this.pnlLiftmove.Controls.Add(this.pnlLift);
            this.pnlLiftmove.Location = new System.Drawing.Point(43, 41);
            this.pnlLiftmove.Name = "pnlLiftmove";
            this.pnlLiftmove.Size = new System.Drawing.Size(177, 690);
            this.pnlLiftmove.TabIndex = 0;
            // 
            // picleftdoorat1
            // 
            this.picleftdoorat1.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.door;
            this.picleftdoorat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picleftdoorat1.Location = new System.Drawing.Point(0, 0);
            this.picleftdoorat1.Name = "picleftdoorat1";
            this.picleftdoorat1.Size = new System.Drawing.Size(91, 293);
            this.picleftdoorat1.TabIndex = 6;
            this.picleftdoorat1.TabStop = false;
            // 
            // picrightdoorat1
            // 
            this.picrightdoorat1.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.door;
            this.picrightdoorat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picrightdoorat1.Location = new System.Drawing.Point(88, 0);
            this.picrightdoorat1.Name = "picrightdoorat1";
            this.picrightdoorat1.Size = new System.Drawing.Size(92, 293);
            this.picrightdoorat1.TabIndex = 7;
            this.picrightdoorat1.TabStop = false;
            // 
            // picrightdoorat0
            // 
            this.picrightdoorat0.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.door;
            this.picrightdoorat0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picrightdoorat0.Location = new System.Drawing.Point(88, 395);
            this.picrightdoorat0.Name = "picrightdoorat0";
            this.picrightdoorat0.Size = new System.Drawing.Size(92, 297);
            this.picrightdoorat0.TabIndex = 4;
            this.picrightdoorat0.TabStop = false;
            // 
            // picbuttomat1
            // 
            this.picbuttomat1.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.button;
            this.picbuttomat1.Location = new System.Drawing.Point(-1, 287);
            this.picbuttomat1.Name = "picbuttomat1";
            this.picbuttomat1.Size = new System.Drawing.Size(181, 22);
            this.picbuttomat1.TabIndex = 5;
            this.picbuttomat1.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.Top;
            this.picTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTop.Location = new System.Drawing.Point(0, 361);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(181, 36);
            this.picTop.TabIndex = 1;
            this.picTop.TabStop = false;
            // 
            // picleftdoorat0
            // 
            this.picleftdoorat0.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.door;
            this.picleftdoorat0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picleftdoorat0.Location = new System.Drawing.Point(0, 395);
            this.picleftdoorat0.Name = "picleftdoorat0";
            this.picleftdoorat0.Size = new System.Drawing.Size(91, 297);
            this.picleftdoorat0.TabIndex = 2;
            this.picleftdoorat0.TabStop = false;
            // 
            // pnlLift
            // 
            this.pnlLift.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.lift_image;
            this.pnlLift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLift.Location = new System.Drawing.Point(0, 0);
            this.pnlLift.Name = "pnlLift";
            this.pnlLift.Size = new System.Drawing.Size(180, 298);
            this.pnlLift.TabIndex = 0;
            // 
            // picButtom
            // 
            this.picButtom.BackgroundImage = global::ElevatorControl_sem3.Properties.Resources.button;
            this.picButtom.Location = new System.Drawing.Point(39, 728);
            this.picButtom.Name = "picButtom";
            this.picButtom.Size = new System.Drawing.Size(181, 22);
            this.picButtom.TabIndex = 3;
            this.picButtom.TabStop = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Location = new System.Drawing.Point(107, 364);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(370, 50);
            this.pnlMiddle.TabIndex = 1;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDates.Location = new System.Drawing.Point(779, 34);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(53, 25);
            this.lblDates.TabIndex = 20;
            this.lblDates.Text = "Date";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(980, 34);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(56, 25);
            this.lblTimes.TabIndex = 21;
            this.lblTimes.Text = "Time";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(1121, 34);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(67, 25);
            this.lblActions.TabIndex = 22;
            this.lblActions.Text = "Action";
            // 
            // lblUnsaved
            // 
            this.lblUnsaved.AutoSize = true;
            this.lblUnsaved.BackColor = System.Drawing.Color.Yellow;
            this.lblUnsaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnsaved.Location = new System.Drawing.Point(1029, 4);
            this.lblUnsaved.Name = "lblUnsaved";
            this.lblUnsaved.Size = new System.Drawing.Size(128, 25);
            this.lblUnsaved.TabIndex = 23;
            this.lblUnsaved.Text = "Unsaved Log";
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.BackColor = System.Drawing.Color.Yellow;
            this.lblSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.Location = new System.Drawing.Point(1029, 371);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(107, 25);
            this.lblSaved.TabIndex = 24;
            this.lblSaved.Text = "Saved Log";
            // 
            // Elevator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 861);
            this.Controls.Add(this.pnlWhole);
            this.Name = "Elevator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Control";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlWhole.ResumeLayout(false);
            this.pnlWhole.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.pnlCavity.ResumeLayout(false);
            this.pnlLiftmove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picleftdoorat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightdoorat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picrightdoorat0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbuttomat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picleftdoorat0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWhole;
        private System.Windows.Forms.Panel pnlCavity;
        private System.Windows.Forms.Panel pnlLiftmove;
        private System.Windows.Forms.Panel pnlLift;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picleftdoorat0;
        private System.Windows.Forms.PictureBox picButtom;
        private System.Windows.Forms.PictureBox picrightdoorat0;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.PictureBox picbuttomat1;
        private System.Windows.Forms.PictureBox picrightdoorat1;
        private System.Windows.Forms.PictureBox picleftdoorat1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAlert;
        private System.Windows.Forms.Button btnGround;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Timer tmrLiftdown;
        private System.Windows.Forms.Timer tmrLiftup;
        private System.Windows.Forms.Timer tmr_Open_door1;
        private System.Windows.Forms.Timer tmr_Open_Door0;
        private System.Windows.Forms.Timer tmr_Close_Door1;
        private System.Windows.Forms.Timer tmr_Close_Door0;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button btnClearSaved;
        private System.Windows.Forms.Button btnDisplayDBLog;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox firstfloor_txtBox;
        private System.Windows.Forms.ListBox Database_lstBox;
        private System.Windows.Forms.TextBox groundFloor_txtBox;
        private System.Windows.Forms.Label lblControlpanel;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button btnSaveLog;
        private System.Windows.Forms.ListBox Log_lstBox;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblDates;
        private System.Windows.Forms.Label lblUnsaved;
        private System.Windows.Forms.Label lblSaved;
    }
}

