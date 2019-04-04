using Alomero_Housing_Software.UI;
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
            BtnNewSystemUsers.Visible = false;
            BtnManageSystemUsers.Visible = false;
            userNewClient.Visible = true;
            userNewClient.BringToFront();
            BtnExchangeRate.Visible = false;
           
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 92);
            sidePanel.BringToFront();
            BtnNewClients.Visible = false;
            BtnUpdateClientPayments.Visible = false;
            BtnSystemSettings.Visible = true;
            BtnSecuritySettings.Visible = true;
            BtnExchangeRate.Visible = false;
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
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnExchangeRate.Visible = false;
            }
            else
            {
                BtnNewEmployee.Visible = false;
                BtnNewClients.Visible = false;
                BtnClients.Visible = true;
                BtnUpdateClientPayments.Visible = false;
                BtnSystemSettings.Visible = true;
                BtnSecuritySettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnExchangeRate.Visible = false;
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
                BtnExchangeRate.Visible = true;
                BtnSystemSettings.Visible = false;
                BtnSecuritySettings.Visible = false;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
            }
            else
            {
                BtnNewClients.Visible = false;
                BtnUpdateClientPayments.Visible = false;
                BtnSystemSettings.Visible = true;
                BtnSecuritySettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
                BtnExchangeRate.Visible = false;
            }
        }

        private void BtnSystemSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 263);
            sidePanel.BringToFront();
            i = i + 1;
            if (i % 2 == 0)
            {
                BtnSecuritySettings.Visible = false;
                BtnNewSystemUsers.Visible = true;
                BtnManageSystemUsers.Visible = true;
            }
            else
            {
                BtnSecuritySettings.Visible = true;
                BtnNewSystemUsers.Visible = false;
                BtnManageSystemUsers.Visible = false;
            }

        }

        private void BtnSecuritySettings_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 320);
            sidePanel.BringToFront();
            if (MessageBox.Show("Database backup and sytem configurations are reserved to the system developer for monthly backups and maintenance upgrades.", "System settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)==DialogResult.OK)
            {
                sidePanel.Location = new Point(0, 92);
                sidePanel.BringToFront();
            }
            else if (MessageBox.Show("Database backup and sytem configurations are reserved to the system developer for monthly backups and maintenance upgrades.", "System settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1) == DialogResult.Cancel)
            {
                sidePanel.Location = new Point(0, 92);
                sidePanel.BringToFront();
            }
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

        private void BtnManageSystemUsers_Click(object sender, EventArgs e)
        {
            userSystemUsers.Visible = true;
            userSystemUsers.BringToFront();
        }

        private void BtnNewSystemUsers_Click(object sender, EventArgs e)
        {
            userNewSystemUser.Visible = true;
            userNewSystemUser.BringToFront();
        }

        private void lblLoginStatus_Click(object sender, EventArgs e)
        {
            frmSignIn signIn = new frmSignIn();
            signIn.Show();
            this.Hide();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 377);
            sidePanel.BringToFront();
            FrmAboutBox frmAboutBox = new FrmAboutBox();
            frmAboutBox.Show();
        }

        private void BtnExchangeRate_Click(object sender, EventArgs e)
        {
            userExchangeRate.Visible = true;
            userExchangeRate.BringToFront();
            userNewClient.Visible = false;
            userNewSystemUser.Visible = false;
            userSystemUsers.Visible = false;
            userUpdatePayment.Visible = false;
            userEmployee.Visible = false;
        }
    }
}
