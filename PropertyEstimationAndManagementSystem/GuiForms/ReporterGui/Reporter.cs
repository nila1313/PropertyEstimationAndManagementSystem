using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms.Consultant;
using PropertyEstimationAndManagementSystem.GuiForms.ReporterGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FeedBack = PropertyEstimationAndManagementSystem.GuiForms.Consultant.FeedBack;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class Reporter: Form
    {
        Users user;
        Login login;
        public Reporter(Login login,Users user)
        {
            InitializeComponent();
            CustomizeDesign();
            this.login = login;
            this.user = user;
        }

        private void btnEditReporter_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelProperty);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }
    

        private void CustomizeDesign()
        {
           panelProperty.Visible = false;
            panelCustomer.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelProperty.Visible == true)
                panelProperty.Visible = false;

            if (panelCustomer.Visible == true)
                panelCustomer.Visible = false;

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

        private Form activeForm = null;
        public void OpenFormPanel(Form openform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = openform;
            openform.TopLevel = false;
            openform.FormBorderStyle = FormBorderStyle.None;
            openform.Dock = DockStyle.Fill;
            ReporterMainPanel.Controls.Add(openform);
            ReporterMainPanel.BringToFront();
            openform.Show();

        }

        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new ShowPropertyList(this));
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelCustomer);
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new EditCustomer(this));
        }

        private void btnAddDescription_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new PriceAccordingArea());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new FeedBack(user, this));
        }
    }
}
