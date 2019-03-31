using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alomero_Housing_Software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Anchor = AnchorStyles.Right;
        }
        int i = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnNewClients.Visible = false;
            BtnUpdateClientPayments.Visible = false;
            BtnNewEmployee.Visible = false;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 92);
            sidePanel.BringToFront();
            BtnNewClients.Visible = false;
            BtnUpdateClientPayments.Visible = false;
            BtnSystemSettings.Visible = true;
            BtnSecuritySettings.Visible = true;
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 149);
            sidePanel.BringToFront();
            i = i + 1;
            if (i % 2 == 0)
            {
                BtnNewEmployee.Visible = true;
                BtnClients.Visible = false;
                BtnNewClients.Visible = false;
                BtnUpdateClientPayments.Visible = false;
                BtnSystemSettings.Visible = true;
                BtnSecuritySettings.Visible = true;
            }
            else
            {
                BtnNewEmployee.Visible = false;
                BtnNewClients.Visible = false;
                BtnClients.Visible = true;
                BtnUpdateClientPayments.Visible = false;
                BtnSystemSettings.Visible = true;
                BtnSecuritySettings.Visible = true;
            }
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0,206);
            sidePanel.BringToFront();
            i = i + 1;
            if (i%2 == 0)
            {
                BtnNewClients.Visible = true;
                BtnUpdateClientPayments.Visible = true;
                BtnSystemSettings.Visible = false;
                BtnSecuritySettings.Visible = false;
            }
            else
            {
                BtnNewClients.Visible = false;
                BtnUpdateClientPayments.Visible = false;
                BtnSystemSettings.Visible = true;
                BtnSecuritySettings.Visible = true;
            }
        }

        private void BtnSystemSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 263);
            sidePanel.BringToFront();
        }

        private void BtnSecuritySettings_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 320);
            sidePanel.BringToFront();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 377);
            sidePanel.BringToFront();
            if (MessageBox.Show("Are you sure you want to quit?","Exiting",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes)
            {
                Application.Exit();
            }
            sidePanel.Location = new Point(0, 92);
            sidePanel.BringToFront();
        }

        private void BtnNewClients_Click(object sender, EventArgs e)
        {
            userNewClient.Visible = true;
            userNewClient.BringToFront();
        }

        private void BtnUpdateClientPayments_Click(object sender, EventArgs e)
        {
            userUpdatePayment.Visible = true;
            userUpdatePayment.BringToFront();
            userNewClient.Visible = false;
            userNewClient.BringToFront();
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            userEmployee.Visible = true;
            userEmployee.BringToFront();
        }
    }
}
