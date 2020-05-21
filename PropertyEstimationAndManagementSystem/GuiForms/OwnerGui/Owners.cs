using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    public partial class Owners : Form
    {
        Login login;
        Users user;
        public Owners(Login login,Users user)
        {
            InitializeComponent();
            panelTransaction.Visible = false;
            this.login = login;
            this.user = user;
            
        }
        private void HideSubMenu()
        {
            if (panelTransaction.Visible == true)
                panelTransaction.Visible = false;

        }
        private void ShowSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelTransaction);
        }

        private Form activeForm = null;
        public void OpenFormPanel(Form openform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = openform;
            openform.TopLevel = false;
            openform.FormBorderStyle = FormBorderStyle.None;
            openform.Dock = DockStyle.Fill;
            panelOwner.Controls.Add(openform);
            panelOwner.BringToFront();
            openform.Show();

        }

        private void btnTransactionList_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new TransactionDetails());
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Sales());
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new EmployeeEdit(new Users(),this));
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new OwnerGui.Account());
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new CheckFeedBack());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            login.Show();
            this.Dispose();
        }

        
    }
 }

