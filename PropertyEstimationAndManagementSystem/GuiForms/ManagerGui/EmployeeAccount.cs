using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class EmployeeAccount : Form
    {
        DataAccess da;
        Users user;
        Employee employee;
        EmployeeEdit em;
        public EmployeeAccount(Employee employee)
        {
            InitializeComponent();
            da = new DataAccess();
            user = new Users();
            this.employee = employee;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                user.Id = employee.Id;
                user.UserName = userName.Text;
                user.UserPassword = password.Text;
                user.UserType = employee.Designation;
                da.Insert<Users>(user, false);
                MessageBox.Show("Save Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem");
            }
        }

        private void EmployeeAccount_Load(object sender, EventArgs e)
        {
            txttype.Text = employee.Designation.ToUpper();
            DataTable dt=da.GetData<Users>(string.Format("where Id={0}", employee.Id));
            if(dt.Rows.Count>0)
            {
                userName.Text = dt.Rows[0][0].ToString();
                password.Text = dt.Rows[0][1].ToString();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            em.Show();
            this.Dispose();
        }
    }

}

