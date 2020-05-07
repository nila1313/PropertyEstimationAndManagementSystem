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

using PropertyEstimationAndManagementSystem.GuiForms.ManagerGui;
using PropertyEstimationAndManagementSystem.GuiForms.OwnerGui;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class EmployeeEdit : Form
    {
        DataAccess da;
        public Employee employee { get; set; }
        Users user;
        Manager man;
        Form prevForm;
        public EmployeeEdit(Users user, Form prevForm)
        {
            InitializeComponent();
            employee = new Employee();
            da = new DataAccess();
            this.user = user;
            this.prevForm = prevForm;
        }
        
        
        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            //showEmployeeList();
            if(prevForm is Owners)
            {
                showEmployeeList();
            }
        }
        public void showEmployeeList()
        {
            if(prevForm is Manager)
            {
                dataGridEmployee.DataSource = da.GetData<Employee>("where Designation!='MANAGER'");
                dataGridEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            if (prevForm is Owners)
            {
                dataGridEmployee.DataSource = da.GetData<Employee>("where Designation ='MANAGER'");
                dataGridEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }




        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridEmployee.SelectedRows[0] as DataGridViewRow;
                employee.Id = Convert.ToInt32(row.Cells[9].Value.ToString());
                employee.FirstName = row.Cells[0].Value.ToString();
                employee.LastName = row.Cells[1].Value.ToString();
                employee.JoiningDate = row.Cells[2].Value.ToString();
                employee.Designation = row.Cells[3].Value.ToString();
                employee.Salary = Convert.ToDouble(row.Cells[4].Value.ToString());
                employee.PhoneNumber = row.Cells[5].Value.ToString();
                employee.Address = row.Cells[6].Value.ToString();
                employee.DateOfBirth =row.Cells[7].Value.ToString();
                employee.BloodGroup = row.Cells[8].Value.ToString();

               
            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void InsertEmployee_Click(object sender, EventArgs e)
        {
            if(prevForm is Manager)
            {
                Manager man = prevForm as Manager;
                man.OpenFormPanel(new CreateEmployee(new Employee(), prevForm, "Insert"));
            }

            if (prevForm is Owners)
            {
                Owners own = prevForm as Owners;
                own.OpenFormPanel(new CreateEmployee(new Employee(), prevForm, "Insert"));
            }

        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            if (employee.Id != 0)
            {
                if (prevForm is Manager)
                { 
                 man= prevForm as Manager;
                 man.OpenFormPanel(new CreateEmployee(employee, prevForm, "Update"));
                }
                if (prevForm is Owners)
                {
                    Owners own = prevForm as Owners;
                    own.OpenFormPanel(new CreateEmployee(employee, prevForm, "Update"));
                }
            }
            else
            {
                MessageBox.Show("Please select a row!!");
            }
        }

        private void RemoveEmployee_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employee.Id != 0)
                {
                    da.remove<Employee>(employee);
                    da.remove<Users>(string.Format("where Id={0}",employee.Id));
                    showEmployeeList();
                    MessageBox.Show("Remove successful!!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showEmployeeList();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (employee.Id != 0)
            {
                if (prevForm is Manager && (employee.Designation.ToUpper()=="CONSULTANT" || employee.Designation.ToUpper()=="REPORTER"))
                {
                    man = prevForm as Manager;
                    man.OpenFormPanel(new EmployeeAccount(employee));
                }
                else if(prevForm is Owners)
                {
                    Owners own = prevForm as Owners;
                    own.OpenFormPanel(new EmployeeAccount(employee));
                }
                else
                {
                    MessageBox.Show("Invalid user type");
                }
            }
            else
            {
                MessageBox.Show("Please select a row!!");
            }
        }
    }
}
