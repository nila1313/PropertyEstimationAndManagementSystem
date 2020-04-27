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

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class EmployeeEdit : Form
    {
        DataAccess da;
        public Employee employee { get; set; }
        Users user;
        Manager man;
        public EmployeeEdit(Users user, Manager man)
        {
            InitializeComponent();
            employee = new Employee();
            da = new DataAccess();
            this.user = user;
            this.man = man;
        }
        
        
        private void EmployeeEdit_Load(object sender, EventArgs e)
        {
            showEmployeeList();
        }
        public void showEmployeeList()
        {
            dataGridEmployee.DataSource = da.GetData<Employee>("");
            dataGridEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                employee.Id = Convert.ToInt32(row.Cells[7].Value.ToString());
                employee.FirstName = row.Cells[0].Value.ToString();
                employee.LastName = row.Cells[1].Value.ToString();
                employee.JoiningDate = row.Cells[2].Value.ToString();
                employee.Type = row.Cells[3].Value.ToString();
                employee.Salary = Convert.ToDouble(row.Cells[4].Value.ToString());
                employee.DateOfBirth =row.Cells[5].Value.ToString();
                employee.BloodGroup = row.Cells[6].Value.ToString();

               
            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }
        }
    }
}
