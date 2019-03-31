namespace Alomero_Housing_Software.UI
{
    partial class UserUpdatePayment
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
            this.txtDistributionNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtStandNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtAmount = new Windows.Forms.HintTextBox(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDateRegistered = new Windows.Forms.HintTextBox(this.components);
            this.txtTotalAmountToBePaid = new Windows.Forms.HintTextBox(this.components);
            this.txtAmountPaidInUS = new Windows.Forms.HintTextBox(this.components);
            this.txtResidentialArea = new Windows.Forms.HintTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNOKPhoneNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtNOKLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtNOKFirstname = new Windows.Forms.HintTextBox(this.components);
            this.txtContactNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtProffession = new Windows.Forms.HintTextBox(this.components);
            this.txtLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtFirstname = new Windows.Forms.HintTextBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.txtAmountInUS = new Windows.Forms.HintTextBox(this.components);
            this.txtSearch = new Windows.Forms.HintTextBox(this.components);
            this.BtnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Payments";
            // 
            // txtDistributionNumber
            // 
            this.txtDistributionNumber.Enabled = false;
            this.txtDistributionNumber.EnterToTab = false;
            this.txtDistributionNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistributionNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtDistributionNumber.HintColor = System.Drawing.Color.Gray;
            this.txtDistributionNumber.HintValue = "Distribution number";
            this.txtDistributionNumber.Location = new System.Drawing.Point(29, 86);
            this.txtDistributionNumber.Name = "txtDistributionNumber";
            this.txtDistributionNumber.Size = new System.Drawing.Size(240, 23);
            this.txtDistributionNumber.TabIndex = 1;
            this.txtDistributionNumber.Text = "Distribution number";
            this.txtDistributionNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtDistributionNumber.Value = "";
            // 
            // txtStandNumber
            // 
            this.txtStandNumber.Enabled = false;
            this.txtStandNumber.EnterToTab = false;
            this.txtStandNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStandNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtStandNumber.HintColor = System.Drawing.Color.Gray;
            this.txtStandNumber.HintValue = "Stand number";
            this.txtStandNumber.Location = new System.Drawing.Point(29, 143);
            this.txtStandNumber.Name = "txtStandNumber";
            this.txtStandNumber.Size = new System.Drawing.Size(240, 23);
            this.txtStandNumber.TabIndex = 2;
            this.txtStandNumber.Text = "Stand number";
            this.txtStandNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtStandNumber.Value = "";
            // 
            // txtAmount
            // 
            this.txtAmount.EnterToTab = false;
            this.txtAmount.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Gray;
            this.txtAmount.HintColor = System.Drawing.Color.Gray;
            this.txtAmount.HintValue = "Amount To Pay(local currency)";
            this.txtAmount.Location = new System.Drawing.Point(29, 205);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(240, 23);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "Amount To Pay(local currency)";
            this.txtAmount.TextForeColor = System.Drawing.Color.Black;
            this.txtAmount.Value = "";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            this.txtAmount.MouseLeave += new System.EventHandler(this.txtAmount_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(436, 293);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtContactNumber);
            this.panel1.Controls.Add(this.txtProffession);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(716, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 375);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDateRegistered);
            this.groupBox2.Controls.Add(this.txtTotalAmountToBePaid);
            this.groupBox2.Controls.Add(this.txtAmountPaidInUS);
            this.groupBox2.Controls.Add(this.txtResidentialArea);
            this.groupBox2.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(3, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 136);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stand Details";
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.Enabled = false;
            this.txtDateRegistered.EnterToTab = false;
            this.txtDateRegistered.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRegistered.ForeColor = System.Drawing.Color.Gray;
            this.txtDateRegistered.HintColor = System.Drawing.Color.Gray;
            this.txtDateRegistered.HintValue = "Date Registered";
            this.txtDateRegistered.Location = new System.Drawing.Point(15, 107);
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.Size = new System.Drawing.Size(188, 23);
            this.txtDateRegistered.TabIndex = 20;
            this.txtDateRegistered.Text = "Date Registered";
            this.txtDateRegistered.TextForeColor = System.Drawing.Color.Black;
            this.txtDateRegistered.Value = "";
            // 
            // txtTotalAmountToBePaid
            // 
            this.txtTotalAmountToBePaid.Enabled = false;
            this.txtTotalAmountToBePaid.EnterToTab = false;
            this.txtTotalAmountToBePaid.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountToBePaid.ForeColor = System.Drawing.Color.Gray;
            this.txtTotalAmountToBePaid.HintColor = System.Drawing.Color.Gray;
            this.txtTotalAmountToBePaid.HintValue = "Total Amount To Be Paid";
            this.txtTotalAmountToBePaid.Location = new System.Drawing.Point(16, 80);
            this.txtTotalAmountToBePaid.Name = "txtTotalAmountToBePaid";
            this.txtTotalAmountToBePaid.Size = new System.Drawing.Size(188, 23);
            this.txtTotalAmountToBePaid.TabIndex = 19;
            this.txtTotalAmountToBePaid.Text = "Total Amount To Be Paid";
            this.txtTotalAmountToBePaid.TextForeColor = System.Drawing.Color.Black;
            this.txtTotalAmountToBePaid.Value = "";
            // 
            // txtAmountPaidInUS
            // 
            this.txtAmountPaidInUS.Enabled = false;
            this.txtAmountPaidInUS.EnterToTab = false;
            this.txtAmountPaidInUS.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaidInUS.ForeColor = System.Drawing.Color.Gray;
            this.txtAmountPaidInUS.HintColor = System.Drawing.Color.Gray;
            this.txtAmountPaidInUS.HintValue = "Amount Paid In US";
            this.txtAmountPaidInUS.Location = new System.Drawing.Point(15, 50);
            this.txtAmountPaidInUS.Name = "txtAmountPaidInUS";
            this.txtAmountPaidInUS.Size = new System.Drawing.Size(188, 23);
            this.txtAmountPaidInUS.TabIndex = 18;
            this.txtAmountPaidInUS.Text = "Amount Paid In US";
            this.txtAmountPaidInUS.TextForeColor = System.Drawing.Color.Black;
            this.txtAmountPaidInUS.Value = "";
            // 
            // txtResidentialArea
            // 
            this.txtResidentialArea.Enabled = false;
            this.txtResidentialArea.EnterToTab = false;
            this.txtResidentialArea.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentialArea.ForeColor = System.Drawing.Color.Gray;
            this.txtResidentialArea.HintColor = System.Drawing.Color.Gray;
            this.txtResidentialArea.HintValue = "Residential area";
            this.txtResidentialArea.Location = new System.Drawing.Point(15, 21);
            this.txtResidentialArea.Name = "txtResidentialArea";
            this.txtResidentialArea.Size = new System.Drawing.Size(188, 23);
            this.txtResidentialArea.TabIndex = 17;
            this.txtResidentialArea.Text = "Residential area";
            this.txtResidentialArea.TextForeColor = System.Drawing.Color.Black;
            this.txtResidentialArea.Value = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNOKPhoneNumber);
            this.groupBox1.Controls.Add(this.txtNOKLastname);
            this.groupBox1.Controls.Add(this.txtNOKFirstname);
            this.groupBox1.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // txtNOKPhoneNumber
            // 
            this.txtNOKPhoneNumber.Enabled = false;
            this.txtNOKPhoneNumber.EnterToTab = false;
            this.txtNOKPhoneNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtNOKPhoneNumber.HintColor = System.Drawing.Color.Gray;
            this.txtNOKPhoneNumber.HintValue = "NOK Phone number";
            this.txtNOKPhoneNumber.Location = new System.Drawing.Point(15, 79);
            this.txtNOKPhoneNumber.Name = "txtNOKPhoneNumber";
            this.txtNOKPhoneNumber.Size = new System.Drawing.Size(188, 23);
            this.txtNOKPhoneNumber.TabIndex = 16;
            this.txtNOKPhoneNumber.Text = "NOK Phone number";
            this.txtNOKPhoneNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtNOKPhoneNumber.Value = "";
            // 
            // txtNOKLastname
            // 
            this.txtNOKLastname.Enabled = false;
            this.txtNOKLastname.EnterToTab = false;
            this.txtNOKLastname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtNOKLastname.HintColor = System.Drawing.Color.Gray;
            this.txtNOKLastname.HintValue = "NOK Lastname";
            this.txtNOKLastname.Location = new System.Drawing.Point(15, 50);
            this.txtNOKLastname.Name = "txtNOKLastname";
            this.txtNOKLastname.Size = new System.Drawing.Size(188, 23);
            this.txtNOKLastname.TabIndex = 15;
            this.txtNOKLastname.Text = "NOK Lastname";
            this.txtNOKLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtNOKLastname.Value = "";
            // 
            // txtNOKFirstname
            // 
            this.txtNOKFirstname.Enabled = false;
            this.txtNOKFirstname.EnterToTab = false;
            this.txtNOKFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtNOKFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtNOKFirstname.HintValue = "NOK Firstname";
            this.txtNOKFirstname.Location = new System.Drawing.Point(15, 21);
            this.txtNOKFirstname.Name = "txtNOKFirstname";
            this.txtNOKFirstname.Size = new System.Drawing.Size(188, 23);
            this.txtNOKFirstname.TabIndex = 14;
            this.txtNOKFirstname.Text = "NOK Firstname";
            this.txtNOKFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtNOKFirstname.Value = "";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Enabled = false;
            this.txtContactNumber.EnterToTab = false;
            this.txtContactNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtContactNumber.HintColor = System.Drawing.Color.Gray;
            this.txtContactNumber.HintValue = "Contact number";
            this.txtContactNumber.Location = new System.Drawing.Point(3, 95);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(209, 23);
            this.txtContactNumber.TabIndex = 12;
            this.txtContactNumber.Text = "Contact number";
            this.txtContactNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.Value = "";
            // 
            // txtProffession
            // 
            this.txtProffession.Enabled = false;
            this.txtProffession.EnterToTab = false;
            this.txtProffession.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProffession.ForeColor = System.Drawing.Color.Gray;
            this.txtProffession.HintColor = System.Drawing.Color.Gray;
            this.txtProffession.HintValue = "Proffession";
            this.txtProffession.Location = new System.Drawing.Point(3, 66);
            this.txtProffession.Name = "txtProffession";
            this.txtProffession.Size = new System.Drawing.Size(209, 23);
            this.txtProffession.TabIndex = 11;
            this.txtProffession.Text = "Proffession";
            this.txtProffession.TextForeColor = System.Drawing.Color.Black;
            this.txtProffession.Value = "";
            // 
            // txtLastname
            // 
            this.txtLastname.Enabled = false;
            this.txtLastname.EnterToTab = false;
            this.txtLastname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtLastname.HintColor = System.Drawing.Color.Gray;
            this.txtLastname.HintValue = "Lastname";
            this.txtLastname.Location = new System.Drawing.Point(106, 37);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(106, 23);
            this.txtLastname.TabIndex = 10;
            this.txtLastname.Text = "Lastname";
            this.txtLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtLastname.Value = "";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Enabled = false;
            this.txtFirstname.EnterToTab = false;
            this.txtFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintValue = "Firstname";
            this.txtFirstname.Location = new System.Drawing.Point(3, 37);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(97, 23);
            this.txtFirstname.TabIndex = 9;
            this.txtFirstname.Text = "Firstname";
            this.txtFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Value = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preview";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BtnReset);
            this.panel2.Controls.Add(this.BtnUpdate);
            this.panel2.Location = new System.Drawing.Point(29, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 47);
            this.panel2.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(149, 5);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(86, 35);
            this.BtnReset.TabIndex = 1;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(3, 5);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 35);
            this.BtnUpdate.TabIndex = 0;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtAmountInUS
            // 
            this.txtAmountInUS.Enabled = false;
            this.txtAmountInUS.EnterToTab = false;
            this.txtAmountInUS.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountInUS.ForeColor = System.Drawing.Color.Gray;
            this.txtAmountInUS.HintColor = System.Drawing.Color.Gray;
            this.txtAmountInUS.HintValue = "Amount In US$";
            this.txtAmountInUS.Location = new System.Drawing.Point(29, 265);
            this.txtAmountInUS.Name = "txtAmountInUS";
            this.txtAmountInUS.Size = new System.Drawing.Size(240, 23);
            this.txtAmountInUS.TabIndex = 7;
            this.txtAmountInUS.Text = "Amount In US$";
            this.txtAmountInUS.TextForeColor = System.Drawing.Color.Black;
            this.txtAmountInUS.Value = "";
            // 
            // txtSearch
            // 
            this.txtSearch.EnterToTab = false;
            this.txtSearch.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.HintColor = System.Drawing.Color.Gray;
            this.txtSearch.HintValue = "Search here...";
            this.txtSearch.Location = new System.Drawing.Point(275, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Search here...";
            this.txtSearch.TextForeColor = System.Drawing.Color.Black;
            this.txtSearch.Value = "";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnSearch.FlatAppearance.BorderSize = 0;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Humanst521 BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.Color.White;
            this.BtnSearch.Location = new System.Drawing.Point(639, 86);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(70, 23);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // UserUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtAmountInUS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtStandNumber);
            this.Controls.Add(this.txtDistributionNumber);
            this.Controls.Add(this.label1);
            this.Name = "UserUpdatePayment";
            this.Size = new System.Drawing.Size(936, 461);
            this.Load += new System.EventHandler(this.UserUpdatePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtDistributionNumber;
        private Windows.Forms.HintTextBox txtStandNumber;
        private Windows.Forms.HintTextBox txtAmount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnReset;
        private Windows.Forms.HintTextBox txtAmountInUS;
        private System.Windows.Forms.Label label2;
        private Windows.Forms.HintTextBox txtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private Windows.Forms.HintTextBox txtLastname;
        private Windows.Forms.HintTextBox txtFirstname;
        private Windows.Forms.HintTextBox txtProffession;
        private Windows.Forms.HintTextBox txtContactNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private Windows.Forms.HintTextBox txtNOKFirstname;
        private Windows.Forms.HintTextBox txtNOKLastname;
        private Windows.Forms.HintTextBox txtNOKPhoneNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private Windows.Forms.HintTextBox txtResidentialArea;
        private Windows.Forms.HintTextBox txtAmountPaidInUS;
        private Windows.Forms.HintTextBox txtTotalAmountToBePaid;
        private Windows.Forms.HintTextBox txtDateRegistered;
    }
}
