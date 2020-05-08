﻿using PropertyEstimationAndManagementSystem.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.GuiForms.ManagerGui;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class Manager : Form
    {
        Login login { get; }
        Users user { get; }
        public Manager(Login login, Users user)
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            EditEmployeePanel.Visible = false;
        }
        private void HideSubMenu()
        {
            if (EditEmployeePanel.Visible == true)
                EditEmployeePanel.Visible = false;

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

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            ShowSubMenu(EditEmployeePanel);
            //EmployeeEdit ee = new EmployeeEdit();
            //this.Hide();
            //ee.Show();
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
            EmployeePanel.Controls.Add(openform);
            EmployeePanel.BringToFront();
            openform.Show();

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new EmployeeEdit(user,this));
            //EmployeeEdit mm = new EmployeeEdit();
            //mm.Show();
        }

        private void showUsers_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new InsertEmployee());
        }

       

        private void Delete_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new DeleteEmployee());
        }

        private void CheckProfit_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new CheckProfit());
        }

        private void ShowProperty_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new ShowProperty());
        }
    }
}
