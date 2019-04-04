namespace Alomero_Housing_Software
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnManageSystemUsers = new System.Windows.Forms.Button();
            this.BtnNewSystemUsers = new System.Windows.Forms.Button();
            this.BtnNewEmployee = new System.Windows.Forms.Button();
            this.BtnUpdateClientPayments = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.BtnNewClients = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnSecuritySettings = new System.Windows.Forms.Button();
            this.BtnSystemSettings = new System.Windows.Forms.Button();
            this.BtnClients = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnExchangeRate = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userExchangeRate = new Alomero_Housing_Software.UI.UserExchangeRate();
            this.userNewSystemUser = new Alomero_Housing_Software.UI.UserNewSystemUser();
            this.userSystemUsers = new Alomero_Housing_Software.UI.UserSystemUsers();
            this.userEmployee = new Alomero_Housing_Software.BLL.UserEmployeeBLL();
            this.userUpdatePayment = new Alomero_Housing_Software.UI.UserUpdatePayment();
            this.userNewClient = new Alomero_Housing_Software.UI.UserNewClient();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.BtnExchangeRate);
            this.panel1.Controls.Add(this.BtnAbout);
            this.panel1.Controls.Add(this.BtnManageSystemUsers);
            this.panel1.Controls.Add(this.BtnNewSystemUsers);
            this.panel1.Controls.Add(this.BtnNewEmployee);
            this.panel1.Controls.Add(this.BtnUpdateClientPayments);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.BtnNewClients);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.BtnSecuritySettings);
            this.panel1.Controls.Add(this.BtnSystemSettings);
            this.panel1.Controls.Add(this.BtnClients);
            this.panel1.Controls.Add(this.BtnEmployee);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 521);
            this.panel1.TabIndex = 0;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbout.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAbout.Location = new System.Drawing.Point(0, 377);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(200, 54);
            this.BtnAbout.TabIndex = 15;
            this.BtnAbout.Text = "ABOUT";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnManageSystemUsers
            // 
            this.BtnManageSystemUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnManageSystemUsers.FlatAppearance.BorderSize = 0;
            this.BtnManageSystemUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManageSystemUsers.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManageSystemUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnManageSystemUsers.Location = new System.Drawing.Point(59, 356);
            this.BtnManageSystemUsers.Name = "BtnManageSystemUsers";
            this.BtnManageSystemUsers.Size = new System.Drawing.Size(142, 33);
            this.BtnManageSystemUsers.TabIndex = 14;
            this.BtnManageSystemUsers.Text = "Manage System Users";
            this.BtnManageSystemUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnManageSystemUsers.UseVisualStyleBackColor = true;
            this.BtnManageSystemUsers.Click += new System.EventHandler(this.BtnManageSystemUsers_Click);
            // 
            // BtnNewSystemUsers
            // 
            this.BtnNewSystemUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewSystemUsers.FlatAppearance.BorderSize = 0;
            this.BtnNewSystemUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewSystemUsers.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewSystemUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewSystemUsers.Location = new System.Drawing.Point(59, 320);
            this.BtnNewSystemUsers.Name = "BtnNewSystemUsers";
            this.BtnNewSystemUsers.Size = new System.Drawing.Size(142, 33);
            this.BtnNewSystemUsers.TabIndex = 13;
            this.BtnNewSystemUsers.Text = "New System Users";
            this.BtnNewSystemUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNewSystemUsers.UseVisualStyleBackColor = true;
            this.BtnNewSystemUsers.Click += new System.EventHandler(this.BtnNewSystemUsers_Click);
            // 
            // BtnNewEmployee
            // 
            this.BtnNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewEmployee.FlatAppearance.BorderSize = 0;
            this.BtnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewEmployee.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewEmployee.Location = new System.Drawing.Point(59, 206);
            this.BtnNewEmployee.Name = "BtnNewEmployee";
            this.BtnNewEmployee.Size = new System.Drawing.Size(142, 39);
            this.BtnNewEmployee.TabIndex = 12;
            this.BtnNewEmployee.Text = "New";
            this.BtnNewEmployee.UseVisualStyleBackColor = true;
            this.BtnNewEmployee.Click += new System.EventHandler(this.BtnNewEmployee_Click);
            // 
            // BtnUpdateClientPayments
            // 
            this.BtnUpdateClientPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateClientPayments.FlatAppearance.BorderSize = 0;
            this.BtnUpdateClientPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateClientPayments.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateClientPayments.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdateClientPayments.Location = new System.Drawing.Point(58, 305);
            this.BtnUpdateClientPayments.Name = "BtnUpdateClientPayments";
            this.BtnUpdateClientPayments.Size = new System.Drawing.Size(142, 39);
            this.BtnUpdateClientPayments.TabIndex = 11;
            this.BtnUpdateClientPayments.Text = "Update Client Payments";
            this.BtnUpdateClientPayments.UseVisualStyleBackColor = true;
            this.BtnUpdateClientPayments.Click += new System.EventHandler(this.BtnUpdateClientPayments_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Wheat;
            this.sidePanel.Location = new System.Drawing.Point(0, 93);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 54);
            this.sidePanel.TabIndex = 10;
            // 
            // BtnNewClients
            // 
            this.BtnNewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewClients.FlatAppearance.BorderSize = 0;
            this.BtnNewClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewClients.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewClients.Location = new System.Drawing.Point(58, 263);
            this.BtnNewClients.Name = "BtnNewClients";
            this.BtnNewClients.Size = new System.Drawing.Size(142, 39);
            this.BtnNewClients.TabIndex = 9;
            this.BtnNewClients.Text = "New";
            this.BtnNewClients.UseVisualStyleBackColor = true;
            this.BtnNewClients.Click += new System.EventHandler(this.BtnNewClients_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExit.Location = new System.Drawing.Point(0, 434);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(200, 54);
            this.BtnExit.TabIndex = 8;
            this.BtnExit.Text = "EXIT";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnSecuritySettings
            // 
            this.BtnSecuritySettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSecuritySettings.FlatAppearance.BorderSize = 0;
            this.BtnSecuritySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSecuritySettings.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecuritySettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSecuritySettings.Location = new System.Drawing.Point(1, 320);
            this.BtnSecuritySettings.Name = "BtnSecuritySettings";
            this.BtnSecuritySettings.Size = new System.Drawing.Size(200, 54);
            this.BtnSecuritySettings.TabIndex = 7;
            this.BtnSecuritySettings.Text = "SECURITY SETTINGS";
            this.BtnSecuritySettings.UseVisualStyleBackColor = true;
            this.BtnSecuritySettings.Click += new System.EventHandler(this.BtnSecuritySettings_Click);
            // 
            // BtnSystemSettings
            // 
            this.BtnSystemSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSystemSettings.FlatAppearance.BorderSize = 0;
            this.BtnSystemSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystemSettings.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystemSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSystemSettings.Location = new System.Drawing.Point(1, 263);
            this.BtnSystemSettings.Name = "BtnSystemSettings";
            this.BtnSystemSettings.Size = new System.Drawing.Size(200, 54);
            this.BtnSystemSettings.TabIndex = 6;
            this.BtnSystemSettings.Text = "SYSTEM USERS";
            this.BtnSystemSettings.UseVisualStyleBackColor = true;
            this.BtnSystemSettings.Click += new System.EventHandler(this.BtnSystemSettings_Click);
            // 
            // BtnClients
            // 
            this.BtnClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClients.FlatAppearance.BorderSize = 0;
            this.BtnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClients.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClients.Location = new System.Drawing.Point(1, 206);
            this.BtnClients.Name = "BtnClients";
            this.BtnClients.Size = new System.Drawing.Size(200, 54);
            this.BtnClients.TabIndex = 5;
            this.BtnClients.Text = "CLIENTS";
            this.BtnClients.UseVisualStyleBackColor = true;
            this.BtnClients.Click += new System.EventHandler(this.BtnClients_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEmployee.Location = new System.Drawing.Point(1, 149);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(200, 54);
            this.BtnEmployee.TabIndex = 4;
            this.BtnEmployee.Text = "EMPLOYEES";
            this.BtnEmployee.UseVisualStyleBackColor = true;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDashboard.Location = new System.Drawing.Point(1, 92);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(200, 54);
            this.BtnDashboard.TabIndex = 0;
            this.BtnDashboard.Text = "DASHBOARD";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel4.Controls.Add(this.lblLoginStatus);
            this.panel4.Controls.Add(this.lblUserName);
            this.panel4.Controls.Add(this.picProfile);
            this.panel4.Location = new System.Drawing.Point(1, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 52);
            this.panel4.TabIndex = 3;
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoginStatus.Location = new System.Drawing.Point(61, 3);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(52, 18);
            this.lblLoginStatus.TabIndex = 2;
            this.lblLoginStatus.Text = "Signout";
            this.lblLoginStatus.Click += new System.EventHandler(this.lblLoginStatus_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(55, 2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 18);
            this.lblUserName.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(201, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 37);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(765, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Integrity.Consistency.Persistency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(736, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alomero Housing System";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.userExchangeRate);
            this.panel3.Controls.Add(this.userNewSystemUser);
            this.panel3.Controls.Add(this.userSystemUsers);
            this.panel3.Controls.Add(this.userEmployee);
            this.panel3.Controls.Add(this.userUpdatePayment);
            this.panel3.Controls.Add(this.userNewClient);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(201, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 484);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(-8, 460);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(952, 23);
            this.panel5.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(419, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Developed by Mambo Chami";
            // 
            // BtnExchangeRate
            // 
            this.BtnExchangeRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExchangeRate.FlatAppearance.BorderSize = 0;
            this.BtnExchangeRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExchangeRate.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExchangeRate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnExchangeRate.Location = new System.Drawing.Point(59, 344);
            this.BtnExchangeRate.Name = "BtnExchangeRate";
            this.BtnExchangeRate.Size = new System.Drawing.Size(142, 33);
            this.BtnExchangeRate.TabIndex = 16;
            this.BtnExchangeRate.Text = "Excahnge Rate";
            this.BtnExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExchangeRate.UseVisualStyleBackColor = true;
            this.BtnExchangeRate.Click += new System.EventHandler(this.BtnExchangeRate_Click);
            // 
            // picProfile
            // 
            this.picProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.picProfile.Image = global::Alomero_Housing_Software.Properties.Resources.Female_Profile_50px;
            this.picProfile.Location = new System.Drawing.Point(0, 0);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(55, 52);
            this.picProfile.TabIndex = 0;
            this.picProfile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Alomero_Housing_Software.Properties.Resources.swift_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userExchangeRate
            // 
            this.userExchangeRate.Location = new System.Drawing.Point(0, 76);
            this.userExchangeRate.Name = "userExchangeRate";
            this.userExchangeRate.Size = new System.Drawing.Size(695, 332);
            this.userExchangeRate.TabIndex = 6;
            // 
            // userNewSystemUser
            // 
            this.userNewSystemUser.Location = new System.Drawing.Point(0, 0);
            this.userNewSystemUser.Name = "userNewSystemUser";
            this.userNewSystemUser.Size = new System.Drawing.Size(938, 461);
            this.userNewSystemUser.TabIndex = 5;
            // 
            // userSystemUsers
            // 
            this.userSystemUsers.Location = new System.Drawing.Point(0, 0);
            this.userSystemUsers.Name = "userSystemUsers";
            this.userSystemUsers.Size = new System.Drawing.Size(936, 461);
            this.userSystemUsers.TabIndex = 4;
            // 
            // userEmployee
            // 
            this.userEmployee.Location = new System.Drawing.Point(0, 0);
            this.userEmployee.Name = "userEmployee";
            this.userEmployee.Size = new System.Drawing.Size(936, 461);
            this.userEmployee.TabIndex = 3;
            // 
            // userUpdatePayment
            // 
            this.userUpdatePayment.Location = new System.Drawing.Point(0, 0);
            this.userUpdatePayment.Name = "userUpdatePayment";
            this.userUpdatePayment.Size = new System.Drawing.Size(936, 461);
            this.userUpdatePayment.TabIndex = 2;
            // 
            // userNewClient
            // 
            this.userNewClient.Location = new System.Drawing.Point(0, 0);
            this.userNewClient.Name = "userNewClient";
            this.userNewClient.Size = new System.Drawing.Size(936, 461);
            this.userNewClient.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 521);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picProfile;
        private System.Windows.Forms.Label lblLoginStatus;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnEmployee;
        private System.Windows.Forms.Button BtnClients;
        private System.Windows.Forms.Button BtnSystemSettings;
        private System.Windows.Forms.Button BtnSecuritySettings;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private UI.UserNewClient userNewClient;
        private System.Windows.Forms.Button BtnNewClients;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button BtnUpdateClientPayments;
        private UI.UserUpdatePayment userUpdatePayment;
        private System.Windows.Forms.Button BtnNewEmployee;
        private BLL.UserEmployeeBLL userEmployee;
        private System.Windows.Forms.Button BtnNewSystemUsers;
        private System.Windows.Forms.Button BtnManageSystemUsers;
        private UI.UserSystemUsers userSystemUsers;
        private UI.UserNewSystemUser userNewSystemUser;
        public System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnExchangeRate;
        private UI.UserExchangeRate userExchangeRate;
    }
}

