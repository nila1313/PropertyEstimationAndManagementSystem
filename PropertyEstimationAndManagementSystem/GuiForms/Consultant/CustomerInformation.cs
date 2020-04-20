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

namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    public partial class CustomerInformation : Form
    {
        Customer customer;
        ShowCustomer showCustomer;
        DataAccess da;
        Property property;
        public CustomerInformation(ShowCustomer showCustomer,Property property)
        {
            InitializeComponent();
            customer = new Customer();
            this.showCustomer = showCustomer;
            da = new DataAccess();
            this.property = property;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.Address = txtAddress.Text;
            customer.MobileNumber = txtMobileNumber.Text;
            customer.Email = txtEmail.Text;
            customer.Nid = txtNid.Text;
            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                da.Insert<Customer>(customer,true);
                showCustomer.showList();
                showCustomer.Show();
                this.Dispose();
            }

        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            lblPropertyId.Hide();
            txtPropertyId.Hide();
            if(property.Status.ToUpper()=="SOLD")
            {
                lblPropertyId.Show();
                txtPropertyId.Show();
                txtPropertyId.Text = property.Id.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            showCustomer.Show();
            this.Dispose();
        }
    }
}
