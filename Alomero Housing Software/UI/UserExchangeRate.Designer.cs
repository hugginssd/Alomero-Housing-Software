namespace Alomero_Housing_Software.UI
{
    partial class UserExchangeRate
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
            this.txtLocalExchange = new Windows.Forms.HintTextBox(this.components);
            this.txtUsExchangeRate = new Windows.Forms.HintTextBox(this.components);
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exchange Rate";
            // 
            // txtLocalExchange
            // 
            this.txtLocalExchange.EnterToTab = false;
            this.txtLocalExchange.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalExchange.ForeColor = System.Drawing.Color.Gray;
            this.txtLocalExchange.HintColor = System.Drawing.Color.Gray;
            this.txtLocalExchange.HintValue = "New Exchange Rate (local)";
            this.txtLocalExchange.Location = new System.Drawing.Point(33, 188);
            this.txtLocalExchange.Name = "txtLocalExchange";
            this.txtLocalExchange.Size = new System.Drawing.Size(225, 23);
            this.txtLocalExchange.TabIndex = 1;
            this.txtLocalExchange.Text = "New Exchange Rate (local)";
            this.txtLocalExchange.TextForeColor = System.Drawing.Color.Black;
            this.txtLocalExchange.Value = "";
            // 
            // txtUsExchangeRate
            // 
            this.txtUsExchangeRate.EnterToTab = false;
            this.txtUsExchangeRate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsExchangeRate.ForeColor = System.Drawing.Color.Gray;
            this.txtUsExchangeRate.HintColor = System.Drawing.Color.Gray;
            this.txtUsExchangeRate.HintValue = "New Exchange Rate (US)";
            this.txtUsExchangeRate.Location = new System.Drawing.Point(33, 117);
            this.txtUsExchangeRate.Name = "txtUsExchangeRate";
            this.txtUsExchangeRate.Size = new System.Drawing.Size(225, 23);
            this.txtUsExchangeRate.TabIndex = 2;
            this.txtUsExchangeRate.Text = "1";
            this.txtUsExchangeRate.TextForeColor = System.Drawing.Color.Black;
            this.txtUsExchangeRate.Value = "1";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdate.Location = new System.Drawing.Point(33, 260);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(88, 32);
            this.BtnUpdate.TabIndex = 3;
            this.BtnUpdate.Text = "UPDATE";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BtnReset.FlatAppearance.BorderSize = 0;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReset.Location = new System.Drawing.Point(170, 260);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(88, 32);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "RESET";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(264, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 205);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Humanst521 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Gray;
            this.lblID.Location = new System.Drawing.Point(30, 70);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(14, 15);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "2";
            // 
            // UserExchangeRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtUsExchangeRate);
            this.Controls.Add(this.txtLocalExchange);
            this.Controls.Add(this.label1);
            this.Name = "UserExchangeRate";
            this.Size = new System.Drawing.Size(695, 332);
            this.Load += new System.EventHandler(this.UserExchangeRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox txtLocalExchange;
        private Windows.Forms.HintTextBox txtUsExchangeRate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
    }
}
