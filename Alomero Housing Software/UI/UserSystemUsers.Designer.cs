namespace Alomero_Housing_Software.UI
{
    partial class UserSystemUsers
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
            this.hintTextBox1 = new Windows.Forms.HintTextBox(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Humanst521 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage System Users";
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.EnterToTab = false;
            this.hintTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintColor = System.Drawing.Color.Gray;
            this.hintTextBox1.HintValue = "Hint Value";
            this.hintTextBox1.Location = new System.Drawing.Point(32, 73);
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(264, 20);
            this.hintTextBox1.TabIndex = 1;
            this.hintTextBox1.TextForeColor = System.Drawing.Color.Black;
            this.hintTextBox1.Value = "";
            // 
            // UserSystemUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hintTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserSystemUsers";
            this.Size = new System.Drawing.Size(936, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Windows.Forms.HintTextBox hintTextBox1;
    }
}
