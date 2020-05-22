using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.Entites;

namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    public partial class Consultants : Form
    {
        HomePage login;
        Users users;
        public Consultants(HomePage login, Users users)
        {
            this.login = login;
            this.users = users;
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            panelProperty.Visible = false;
            panelShowCustomer.Visible = false;
            panelPayment.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelProperty.Visible == true)
                panelProperty.Visible = false;
            if (panelShowCustomer.Visible == true)
                panelShowCustomer.Visible = false;
            if (panelPayment.Visible == true)
                panelPayment.Visible = false;

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
    

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Search(users,this));
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
            panelConsultant.Controls.Add(openform);
            panelConsultant.BringToFront();
            openform.Show();

        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelProperty);
        }
        private void btnShowCustomer_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new ShowCustomer(new Property()
            {
                Status = "NULL"
            }, users, this));
        }

        private void btnBookedProperty_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new ShowBookedProperty(users,this));
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new FeedBack(users, this));
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new UnsoldPropertyList(users,this));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new FeedBack(users, this));
        }

        private void btnCustomerInformation_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelShowCustomer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPayment);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }

        private void Consultants_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
