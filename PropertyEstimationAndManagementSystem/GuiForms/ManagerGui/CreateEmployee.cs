using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms.OwnerGui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{

    public partial class CreateEmployee : Form
    {
        Employee employee;
        Form prevForm;
        string eventType;
        DataAccess da = new DataAccess();

        public CreateEmployee(Employee employee, Form prevForm, string eventType)
        {
            InitializeComponent();
            this.employee = employee;
            this.prevForm = prevForm;
            this.eventType = eventType;
        }

        private void CreateEmployee_Load(object sender, EventArgs e)
        {
            if (eventType.ToUpper() == "INSERT")
            {
                btnUpdate.Hide();
            }
            if (eventType.ToUpper() == "UPDATE")
            {
                btnInsert.Hide();
                //Id.Text = employee.Id.ToString();
                firstName.Text = employee.FirstName;
                lastName.Text = employee.LastName;
                joiningDate.Value = Convert.ToDateTime(employee.JoiningDate);
                designation.Text = employee.Designation;
                salary.Text = employee.Salary.ToString();
                phoneNumber.Text = employee.PhoneNumber;
                Address.Text = employee.Address;
                dateOfBirth.Value = Convert.ToDateTime(employee.DateOfBirth);
                bloodGroup.Text = employee.BloodGroup.ToString();
                for (int i = 0; i < bloodGroup.Items.Count; i++)
                {
                    if (bloodGroup.Text.ToUpper() == employee.BloodGroup.ToUpper())
                    {
                        bloodGroup.SelectedIndex = i - 1;
                        break;
                    }
                    bloodGroup.SelectedIndex = i;

                }
            }
            if(prevForm is Owners)
            {
                designation.Text = "MANAGER";
                designation.ReadOnly = true;
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            employee.FirstName = firstName.Text;
            employee.LastName = lastName.Text;
            employee.JoiningDate = joiningDate.Value.ToString();
            employee.Designation = designation.Text;
            employee.Salary = Convert.ToDouble(salary.Text);
            employee.PhoneNumber = phoneNumber.Text;
            employee.Address = Address.Text;
            employee.DateOfBirth = dateOfBirth.Value.ToString();
            employee.BloodGroup = bloodGroup.Text;
            if (prevForm is Owners)
            {
                da.Insert<Employee>(employee, true);
                MessageBox.Show("Insert Successful!");
                this.Dispose();
            }
            else
            {
                if (designation.Text.ToUpper() != "MANAGER")
                {
                    da.Insert<Employee>(employee, true);
                    MessageBox.Show("Insert Successful!");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Manager Cannot be Inserted");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employee.FirstName = firstName.Text;
            employee.LastName = lastName.Text;
            employee.JoiningDate = joiningDate.Value.ToString();
            employee.Designation = designation.Text.ToString();
            employee.Salary = Convert.ToDouble(salary.Text);
            employee.PhoneNumber = phoneNumber.Text.ToString();
            employee.Address = Address.Text.ToString();
            employee.DateOfBirth = dateOfBirth.Value.ToString();
            employee.BloodGroup = bloodGroup.Text;
            if (designation.Text.ToUpper()!="MANAGER")
            {
                da.Insert<Employee>(employee, true);
                MessageBox.Show("Update Successful!");
                this.Dispose();
            }
            else if(prevForm is Owners)
            {
                da.Insert<Employee>(employee, true);
                MessageBox.Show("Update Successful!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Manager Cannot be Inserted");
            }
            
        }

        private void firstName_Validating(object sender, CancelEventArgs e)
        {
            var txtFirstName = (sender as TextBox).Text;
            if(string.IsNullOrWhiteSpace(txtFirstName))
            {
                e.Cancel = true;
                firstName.Focus();
                errorProvider1.SetError(firstName, "$First Name should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(firstName, "");
           }
        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            var txtLastName = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtLastName))
            {
                e.Cancel = true;
                lastName.Focus();
                errorProvider1.SetError(lastName, "$Last Name should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lastName, "");
            }
        }

        private void designation_Validating(object sender, CancelEventArgs e)
        {
            var txtDesignation = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtDesignation))
            {
                e.Cancel = true;
                designation.Focus();
                errorProvider1.SetError(designation, "$Employee Designation should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(designation, "");
            }
        }

        private void salary_Validating(object sender, CancelEventArgs e)
        {
            var txtSalary = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtSalary))
            {
                e.Cancel = true;
                salary.Focus();
                errorProvider1.SetError(salary, "$Salary should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(salary, "");
            }
        }

        private void phoneNumber_Validating(object sender, CancelEventArgs e)
        {
            var txtPhoneNumber = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtPhoneNumber))
            {
                e.Cancel = true;
                phoneNumber.Focus();
                errorProvider1.SetError(phoneNumber, "$Phone Number should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(phoneNumber, "");
            }
        }

        private void Address_Validating(object sender, CancelEventArgs e)
        {
            var txtAddress = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtAddress))
            {
                e.Cancel = true;
                Address.Focus();
                errorProvider1.SetError(Address, "$Address must be required!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Address, "");
            }
        }

        /*private void bloodGroup_Validating(object sender, CancelEventArgs e)
        {
            var txtBloodGroup = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(txtBloodGroup))
            {
                e.Cancel = true;
                bloodGroup.Focus();
                errorProvider1.SetError(bloodGroup, "$Blood Group should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(bloodGroup, "");
            }
        }*/
    }
}
