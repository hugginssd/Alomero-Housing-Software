namespace Alomero_Housing_Software.UI
{
    partial class UserNewClient
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
            this.txtID = new Windows.Forms.HintTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDistributionNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtFirstname = new Windows.Forms.HintTextBox(this.components);
            this.txtLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtIDNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtProffession = new Windows.Forms.HintTextBox(this.components);
            this.txtPhoneNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtCurrentAddress = new Windows.Forms.HintTextBox(this.components);
            this.txtNOKFirstname = new Windows.Forms.HintTextBox(this.components);
            this.txtNextOFKinLastname = new Windows.Forms.HintTextBox(this.components);
            this.txtNOKPhonNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtStandNumber = new Windows.Forms.HintTextBox(this.components);
            this.txtResidentialArea = new Windows.Forms.HintTextBox(this.components);
            this.txtAmountPaidInLocalCurrency = new Windows.Forms.HintTextBox(this.components);
            this.txtAmoundPaidInUS = new Windows.Forms.HintTextBox(this.components);
            this.DtpDateOfRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtTotalAmountToBePaid = new Windows.Forms.HintTextBox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(17, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Client";
            // 
            // txtID
            // 
            this.txtID.EnterToTab = false;
            this.txtID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Gray;
            this.txtID.HintColor = System.Drawing.Color.Gray;
            this.txtID.HintValue = "ID";
            this.txtID.Location = new System.Drawing.Point(34, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID";
            this.txtID.TextForeColor = System.Drawing.Color.Black;
            this.txtID.Value = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProffession);
            this.groupBox1.Controls.Add(this.txtIDNumber);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.txtDistributionNumber);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 356);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNOKPhonNumber);
            this.groupBox2.Controls.Add(this.txtNextOFKinLastname);
            this.groupBox2.Controls.Add(this.txtNOKFirstname);
            this.groupBox2.Controls.Add(this.txtCurrentAddress);
            this.groupBox2.Controls.Add(this.txtPhoneNumber);
            this.groupBox2.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(330, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 356);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalAmountToBePaid);
            this.groupBox3.Controls.Add(this.DtpDateOfRegistration);
            this.groupBox3.Controls.Add(this.txtAmoundPaidInUS);
            this.groupBox3.Controls.Add(this.txtAmountPaidInLocalCurrency);
            this.groupBox3.Controls.Add(this.txtResidentialArea);
            this.groupBox3.Controls.Add(this.txtStandNumber);
            this.groupBox3.Font = new System.Drawing.Font("Humanst521 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(626, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 356);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stand Details";
            // 
            // txtDistributionNumber
            // 
            this.txtDistributionNumber.EnterToTab = false;
            this.txtDistributionNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistributionNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtDistributionNumber.HintColor = System.Drawing.Color.Gray;
            this.txtDistributionNumber.HintValue = "Distribution number";
            this.txtDistributionNumber.Location = new System.Drawing.Point(34, 82);
            this.txtDistributionNumber.Name = "txtDistributionNumber";
            this.txtDistributionNumber.Size = new System.Drawing.Size(237, 23);
            this.txtDistributionNumber.TabIndex = 2;
            this.txtDistributionNumber.Text = "Distribution number";
            this.txtDistributionNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtDistributionNumber.Value = "";
            // 
            // txtFirstname
            // 
            this.txtFirstname.EnterToTab = false;
            this.txtFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtFirstname.HintValue = "Firstname ";
            this.txtFirstname.Location = new System.Drawing.Point(34, 130);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(237, 23);
            this.txtFirstname.TabIndex = 3;
            this.txtFirstname.Text = "Firstname ";
            this.txtFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtFirstname.Value = "";
            // 
            // txtLastname
            // 
            this.txtLastname.EnterToTab = false;
            this.txtLastname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtLastname.HintColor = System.Drawing.Color.Gray;
            this.txtLastname.HintValue = "Lastname ";
            this.txtLastname.Location = new System.Drawing.Point(34, 178);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(237, 23);
            this.txtLastname.TabIndex = 4;
            this.txtLastname.Text = "Lastname ";
            this.txtLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtLastname.Value = "";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.EnterToTab = false;
            this.txtIDNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtIDNumber.HintColor = System.Drawing.Color.Gray;
            this.txtIDNumber.HintValue = "ID Number";
            this.txtIDNumber.Location = new System.Drawing.Point(34, 226);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(237, 23);
            this.txtIDNumber.TabIndex = 5;
            this.txtIDNumber.Text = "ID Number";
            this.txtIDNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtIDNumber.Value = "";
            // 
            // txtProffession
            // 
            this.txtProffession.EnterToTab = false;
            this.txtProffession.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProffession.ForeColor = System.Drawing.Color.Gray;
            this.txtProffession.HintColor = System.Drawing.Color.Gray;
            this.txtProffession.HintValue = "Proffession";
            this.txtProffession.Location = new System.Drawing.Point(34, 274);
            this.txtProffession.Name = "txtProffession";
            this.txtProffession.Size = new System.Drawing.Size(237, 23);
            this.txtProffession.TabIndex = 6;
            this.txtProffession.Text = "Proffession";
            this.txtProffession.TextForeColor = System.Drawing.Color.Black;
            this.txtProffession.Value = "";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.EnterToTab = false;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.HintColor = System.Drawing.Color.Gray;
            this.txtPhoneNumber.HintValue = "Phone number";
            this.txtPhoneNumber.Location = new System.Drawing.Point(34, 37);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(237, 23);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.Text = "Phone number";
            this.txtPhoneNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Value = "";
            // 
            // txtCurrentAddress
            // 
            this.txtCurrentAddress.EnterToTab = false;
            this.txtCurrentAddress.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentAddress.ForeColor = System.Drawing.Color.Gray;
            this.txtCurrentAddress.HintColor = System.Drawing.Color.Gray;
            this.txtCurrentAddress.HintValue = "Current Address";
            this.txtCurrentAddress.Location = new System.Drawing.Point(34, 82);
            this.txtCurrentAddress.Multiline = true;
            this.txtCurrentAddress.Name = "txtCurrentAddress";
            this.txtCurrentAddress.Size = new System.Drawing.Size(237, 71);
            this.txtCurrentAddress.TabIndex = 8;
            this.txtCurrentAddress.Text = "Current Address";
            this.txtCurrentAddress.TextForeColor = System.Drawing.Color.Black;
            this.txtCurrentAddress.Value = "";
            // 
            // txtNOKFirstname
            // 
            this.txtNOKFirstname.EnterToTab = false;
            this.txtNOKFirstname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKFirstname.ForeColor = System.Drawing.Color.Gray;
            this.txtNOKFirstname.HintColor = System.Drawing.Color.Gray;
            this.txtNOKFirstname.HintValue = "Next Of Kin Firstname : optional";
            this.txtNOKFirstname.Location = new System.Drawing.Point(34, 178);
            this.txtNOKFirstname.Name = "txtNOKFirstname";
            this.txtNOKFirstname.Size = new System.Drawing.Size(237, 23);
            this.txtNOKFirstname.TabIndex = 9;
            this.txtNOKFirstname.Text = "Next Of Kin Firstname : optional";
            this.txtNOKFirstname.TextForeColor = System.Drawing.Color.Black;
            this.txtNOKFirstname.Value = "";
            // 
            // txtNextOFKinLastname
            // 
            this.txtNextOFKinLastname.EnterToTab = false;
            this.txtNextOFKinLastname.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNextOFKinLastname.ForeColor = System.Drawing.Color.Gray;
            this.txtNextOFKinLastname.HintColor = System.Drawing.Color.Gray;
            this.txtNextOFKinLastname.HintValue = "Next Of Kin Lastname : optional";
            this.txtNextOFKinLastname.Location = new System.Drawing.Point(34, 226);
            this.txtNextOFKinLastname.Name = "txtNextOFKinLastname";
            this.txtNextOFKinLastname.Size = new System.Drawing.Size(237, 23);
            this.txtNextOFKinLastname.TabIndex = 10;
            this.txtNextOFKinLastname.Text = "Next Of Kin Lastname : optional";
            this.txtNextOFKinLastname.TextForeColor = System.Drawing.Color.Black;
            this.txtNextOFKinLastname.Value = "";
            // 
            // txtNOKPhonNumber
            // 
            this.txtNOKPhonNumber.EnterToTab = false;
            this.txtNOKPhonNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKPhonNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtNOKPhonNumber.HintColor = System.Drawing.Color.Gray;
            this.txtNOKPhonNumber.HintValue = "Next Of Kin Phone number : optional";
            this.txtNOKPhonNumber.Location = new System.Drawing.Point(34, 274);
            this.txtNOKPhonNumber.Name = "txtNOKPhonNumber";
            this.txtNOKPhonNumber.Size = new System.Drawing.Size(237, 23);
            this.txtNOKPhonNumber.TabIndex = 11;
            this.txtNOKPhonNumber.Text = "Next Of Kin Phone number : optional";
            this.txtNOKPhonNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtNOKPhonNumber.Value = "";
            // 
            // txtStandNumber
            // 
            this.txtStandNumber.EnterToTab = false;
            this.txtStandNumber.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStandNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtStandNumber.HintColor = System.Drawing.Color.Gray;
            this.txtStandNumber.HintValue = "Stand number";
            this.txtStandNumber.Location = new System.Drawing.Point(31, 37);
            this.txtStandNumber.Name = "txtStandNumber";
            this.txtStandNumber.Size = new System.Drawing.Size(258, 23);
            this.txtStandNumber.TabIndex = 12;
            this.txtStandNumber.Text = "Stand number";
            this.txtStandNumber.TextForeColor = System.Drawing.Color.Black;
            this.txtStandNumber.Value = "";
            this.txtStandNumber.TextChanged += new System.EventHandler(this.txtStandNumber_TextChanged);
            // 
            // txtResidentialArea
            // 
            this.txtResidentialArea.EnterToTab = false;
            this.txtResidentialArea.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidentialArea.ForeColor = System.Drawing.Color.Gray;
            this.txtResidentialArea.HintColor = System.Drawing.Color.Gray;
            this.txtResidentialArea.HintValue = "Residential area";
            this.txtResidentialArea.Location = new System.Drawing.Point(31, 82);
            this.txtResidentialArea.Name = "txtResidentialArea";
            this.txtResidentialArea.Size = new System.Drawing.Size(258, 23);
            this.txtResidentialArea.TabIndex = 13;
            this.txtResidentialArea.Text = "Residential area";
            this.txtResidentialArea.TextForeColor = System.Drawing.Color.Black;
            this.txtResidentialArea.Value = "";
            // 
            // txtAmountPaidInLocalCurrency
            // 
            this.txtAmountPaidInLocalCurrency.EnterToTab = false;
            this.txtAmountPaidInLocalCurrency.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaidInLocalCurrency.ForeColor = System.Drawing.Color.Gray;
            this.txtAmountPaidInLocalCurrency.HintColor = System.Drawing.Color.Gray;
            this.txtAmountPaidInLocalCurrency.HintValue = "Amount Paid(local currency)";
            this.txtAmountPaidInLocalCurrency.Location = new System.Drawing.Point(31, 130);
            this.txtAmountPaidInLocalCurrency.Name = "txtAmountPaidInLocalCurrency";
            this.txtAmountPaidInLocalCurrency.Size = new System.Drawing.Size(258, 23);
            this.txtAmountPaidInLocalCurrency.TabIndex = 14;
            this.txtAmountPaidInLocalCurrency.Text = "Amount Paid(local currency)";
            this.txtAmountPaidInLocalCurrency.TextForeColor = System.Drawing.Color.Black;
            this.txtAmountPaidInLocalCurrency.Value = "";
            this.txtAmountPaidInLocalCurrency.TextChanged += new System.EventHandler(this.txtAmountPaidInLocalCurrency_TextChanged);
            this.txtAmountPaidInLocalCurrency.MouseLeave += new System.EventHandler(this.txtAmountPaidInLocalCurrency_MouseLeave);
            // 
            // txtAmoundPaidInUS
            // 
            this.txtAmoundPaidInUS.Enabled = false;
            this.txtAmoundPaidInUS.EnterToTab = false;
            this.txtAmoundPaidInUS.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmoundPaidInUS.ForeColor = System.Drawing.Color.Gray;
            this.txtAmoundPaidInUS.HintColor = System.Drawing.Color.Gray;
            this.txtAmoundPaidInUS.HintValue = "Amount Paid In US ";
            this.txtAmoundPaidInUS.Location = new System.Drawing.Point(31, 178);
            this.txtAmoundPaidInUS.Name = "txtAmoundPaidInUS";
            this.txtAmoundPaidInUS.Size = new System.Drawing.Size(258, 23);
            this.txtAmoundPaidInUS.TabIndex = 15;
            this.txtAmoundPaidInUS.Text = "Amount Paid In US ";
            this.txtAmoundPaidInUS.TextForeColor = System.Drawing.Color.Black;
            this.txtAmoundPaidInUS.Value = "";
            // 
            // DtpDateOfRegistration
            // 
            this.DtpDateOfRegistration.Location = new System.Drawing.Point(31, 226);
            this.DtpDateOfRegistration.Name = "DtpDateOfRegistration";
            this.DtpDateOfRegistration.Size = new System.Drawing.Size(199, 22);
            this.DtpDateOfRegistration.TabIndex = 16;
            // 
            // txtTotalAmountToBePaid
            // 
            this.txtTotalAmountToBePaid.EnterToTab = false;
            this.txtTotalAmountToBePaid.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmountToBePaid.ForeColor = System.Drawing.Color.Gray;
            this.txtTotalAmountToBePaid.HintColor = System.Drawing.Color.Gray;
            this.txtTotalAmountToBePaid.HintValue = "Total Amount";
            this.txtTotalAmountToBePaid.Location = new System.Drawing.Point(31, 274);
            this.txtTotalAmountToBePaid.Name = "txtTotalAmountToBePaid";
            this.txtTotalAmountToBePaid.Size = new System.Drawing.Size(258, 23);
            this.txtTotalAmountToBePaid.TabIndex = 17;
            this.txtTotalAmountToBePaid.Text = "Total Amount";
            this.txtTotalAmountToBePaid.TextForeColor = System.Drawing.Color.Black;
            this.txtTotalAmountToBePaid.Value = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Location = new System.Drawing.Point(34, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 41);
            this.panel1.TabIndex = 5;
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCreate.FlatAppearance.BorderSize = 0;
            this.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreate.Font = new System.Drawing.Font("Humanst521 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCreate.Location = new System.Drawing.Point(33, 3);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(110, 33);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "CREATE";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Humanst521 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(427, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(110, 33);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "RESET";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // UserNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserNewClient";
            this.Size = new System.Drawing.Size(936, 451);
            this.Load += new System.EventHandler(this.UserNewClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Windows.Forms.HintTextBox txtProffession;
        private Windows.Forms.HintTextBox txtIDNumber;
        private Windows.Forms.HintTextBox txtLastname;
        private Windows.Forms.HintTextBox txtFirstname;
        private Windows.Forms.HintTextBox txtDistributionNumber;
        private Windows.Forms.HintTextBox txtPhoneNumber;
        private Windows.Forms.HintTextBox txtCurrentAddress;
        private Windows.Forms.HintTextBox txtNOKFirstname;
        private Windows.Forms.HintTextBox txtNextOFKinLastname;
        private Windows.Forms.HintTextBox txtNOKPhonNumber;
        private Windows.Forms.HintTextBox txtStandNumber;
        private Windows.Forms.HintTextBox txtResidentialArea;
        private Windows.Forms.HintTextBox txtAmountPaidInLocalCurrency;
        private Windows.Forms.HintTextBox txtAmoundPaidInUS;
        private System.Windows.Forms.DateTimePicker DtpDateOfRegistration;
        private Windows.Forms.HintTextBox txtTotalAmountToBePaid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnCancel;
    }
}
