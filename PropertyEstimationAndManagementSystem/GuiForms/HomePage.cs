using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            UserPanel.Visible = false;
        }
        private void HideSubMenu()
        {
            if (UserPanel.Visible == true)
                UserPanel.Visible = false;

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
        private void OpenFormPanel(Form openform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = openform;
            openform.TopLevel = false;
            openform.FormBorderStyle = FormBorderStyle.None;
            openform.Dock = DockStyle.Fill;
            formPanel.Controls.Add(openform);
            formPanel.BringToFront();
            openform.Show();


        }

        

        private void Users_Click(object sender, EventArgs e)
        {
            ShowSubMenu(UserPanel);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Login());
        }
    }
}