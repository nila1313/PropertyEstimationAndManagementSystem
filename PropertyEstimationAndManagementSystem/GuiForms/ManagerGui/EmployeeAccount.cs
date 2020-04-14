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
        public EmployeeAccount()
        {
            InitializeComponent();
            da = new DataAccess();
            user = new Users();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            user.Id = 6;
            user.UserName = userName.Text;
            user.UserPassword = password.Text;
            da.Insert<Users>(user, false);
            MessageBox.Show("Save Successful");
        }
    }
}
