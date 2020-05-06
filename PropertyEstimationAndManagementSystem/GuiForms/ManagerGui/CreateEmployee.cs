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


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (designation.Text.ToUpper() != "MANAGER")
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
                da.Insert<Employee>(employee, true);
                MessageBox.Show("Insert Successful!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Manager Cannot be Inserted");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(designation.Text.ToUpper()!="MANAGER")
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
                da.Insert<Employee>(employee, true);
                MessageBox.Show("Update Successful!");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Manager Cannot be Inserted");
            }
            
        }
    }
}
