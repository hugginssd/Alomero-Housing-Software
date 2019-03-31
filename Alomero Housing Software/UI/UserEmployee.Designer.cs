namespace Alomero_Housing_Software.BLL
{
    partial class UserEmployeeBLL
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new Windows.Forms.HintTextBox(this.components);
            this.txtNationalID = new Windows.Forms.HintTextBox(this.components);
            this.txtFirstname = new Windows.Forms.HintTextBox(this.components);
            this.txtLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtDesignation = new Windows.Forms.HintTextBox(this.components);
            this.DtpDateEmployeed = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.txtID = new Windows.Forms.HintTextBox(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Windows.Forms.HintTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Enabled = false;
            this.txtEmployeeID.EnterToTab = false;
            this.txtEmployeeID.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.txtEmployeeID.HintColor = System.Drawing.Color.Gray;
            this.txtEmployeeID.HintValue = "Employee ID";
            this.txtEmployeeID.Location = new System.Drawing.Point(54, 104);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(244, 22);
            this.txtEmployeeID.TabIndex = 1;
            this.txtEmployeeID.Text = "Employee ID";
            this.txtEmployeeID.TextForeColor = System.Drawing.Color.Black;
            this.txtEmployeeID.Value = "";
            // 
            // txtNationalID
            // 
            this.txtNationalID.EnterToTab = false;
            this.txtNationalID.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalID.ForeColor = System.Drawing.Color.Gray;
            this.txtNationalID.HintColor = System.Drawing.Color.Gray;
            this.txtNationalID.HintValue = "National ID";
            this.txtNationalID.Location = new System.Drawing.Point(54, 260);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(244, 22);
            this.txtNationalID.TabIndex = 2;
            this.txtNationalID.Text = "National ID";
            this.txtNationalID.TextForeColor = System.Drawing.Color.Black;
            this.txtNationalID.Value = "";
            // 
            // txtFirstname
            // 
            this.txtFirstname.EnterToTab = false;
            this.txtFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintValue = "Firstname";
            this.txtFirstname.Location = new System.Drawing.Point(54, 156);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(244, 22);
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.Text = "Firstname";
            this.txtFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Value = "";
            // 
            // txtLastname
            // 
            this.txtLastname.EnterToTab = false;
            this.txtLastname.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtLastname.HintColor = System.Drawing.Color.Gray;
            this.txtLastname.HintValue = "Lastname";
            this.txtLastname.Location = new System.Drawing.Point(54, 208);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(244, 22);
            this.txtLastname.TabIndex = 3;
            this.txtLastname.Text = "Lastname";
            this.txtLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtLastname.Value = "";
            // 
            // txtDesignation
            // 
            this.txtDesignation.EnterToTab = false;
            this.txtDesignation.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.ForeColor = System.Drawing.Color.Gray;
            this.txtDesignation.HintColor = System.Drawing.Color.Gray;
            this.txtDesignation.HintValue = "Designation";
            this.txtDesignation.Location = new System.Drawing.Point(54, 312);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(244, 22);
            this.txtDesignation.TabIndex = 4;
            this.txtDesignation.Text = "Designation";
            this.txtDesignation.TextForeColor = System.Drawing.Color.Black;
            this.txtDesignation.Value = "";
            // 
            // DtpDateEmployeed
            // 
            this.DtpDateEmployeed.CalendarForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.DtpDateEmployeed.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DtpDateEmployeed.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateEmployeed.Location = new System.Drawing.Point(54, 360);
            this.DtpDateEmployeed.Name = "DtpDateEmployeed";
            this.DtpDateEmployeed.Size = new System.Drawing.Size(197, 23);
            this.DtpDateEmployeed.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(329, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 310);
            this.dataGridView1.TabIndex = 6;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCreate.Location = new System.Drawing.Point(54, 401);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(104, 32);
            this.BtnCreate.TabIndex = 7;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnReset.Location = new System.Drawing.Point(194, 401);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(104, 32);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.EnterToTab = false;
            this.txtID.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.HintColor = System.Drawing.Color.Gray;
            this.txtID.HintValue = "ID";
            this.txtID.Location = new System.Drawing.Point(54, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 22);
            this.txtID.TabIndex = 9;
            this.txtID.Text = "ID";
            this.txtID.TextForeColor = System.Drawing.Color.Black;
            this.txtID.Value = "";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSearch.Location = new System.Drawing.Point(830, 91);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(84, 26);
            this.BtnSearch.TabIndex = 10;
            this.BtnSearch.Text = "SEARCH";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.EnterToTab = false;
            this.txtSearch.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HintColor = System.Drawing.Color.Gray;
            this.txtSearch.HintValue = "Search here...";
            this.txtSearch.Location = new System.Drawing.Point(329, 95);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(495, 22);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.Text = "Search here...";
            this.txtSearch.TextForeColor = System.Drawing.Color.Black;
            this.txtSearch.Value = "";
            // 
            // UserEmployeeBLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DtpDateEmployeed);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label1);
            this.Name = "UserEmployeeBLL";
            this.Size = new System.Drawing.Size(936, 461);
            this.Load += new System.EventHandler(this.UserEmployeeBLL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtEmployeeID;
        private Windows.Forms.HintTextBox txtNationalID;
        private Windows.Forms.HintTextBox txtFirstname;
        private Windows.Forms.HintTextBox txtLastname;
        private Windows.Forms.HintTextBox txtDesignation;
        private System.Windows.Forms.DateTimePicker DtpDateEmployeed;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnReset;
        private Windows.Forms.HintTextBox txtID;
        private System.Windows.Forms.Button BtnSearch;
        private Windows.Forms.HintTextBox txtSearch;
    }
}
