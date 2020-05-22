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
         public CustomerInformation(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            this.showCustomer = null;
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtAddress.Text = customer.Address;
            txtEmail.Text = customer.Email;
            txtMobileNumber.Text = customer.MobileNumber;
            txtNid.Text = customer.Nid;
            da = new DataAccess();
            this.property = new Property();
            this.property.Status = "Null";
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
                if(showCustomer!=null)
                {
                    showCustomer.showList();
                    showCustomer.Show();
                }
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

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            var FirstName = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "$First NAme should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, "");
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            var LastName = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "$Last Name should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            var Address = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(Address))
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "$Address should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void txtMobileNumber_Validating(object sender, CancelEventArgs e)
        {
            var MobileNumber = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(MobileNumber))
            {
                e.Cancel = true;
                txtMobileNumber.Focus();
                errorProvider1.SetError(txtMobileNumber, "$Mobile Number should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMobileNumber, "");
            }
        }

        private void txtNid_Validating(object sender, CancelEventArgs e)
        {
            var Nid = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(Nid))
            {
                e.Cancel = true;
                txtNid.Focus();
                errorProvider1.SetError(txtNid, "$Nid should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNid, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var Email = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(Email))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "$Email should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPropertyId_Validating(object sender, CancelEventArgs e)
        {
            var propertyId = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(propertyId))
            {
                e.Cancel = true;
                txtPropertyId.Focus();
                errorProvider1.SetError(txtPropertyId, "$Property Id should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPropertyId, "");
            }
        }
    }
}
