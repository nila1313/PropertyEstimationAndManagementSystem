using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms;


namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{
    public partial class InsertEmployee : Form
    {

        DataAccess da;

        public InsertEmployee()
        {
            //this.users = users;
            //this.login = login;
            InitializeComponent();
            da = new DataAccess();
        }
      

        private void InsertEmployee_Load(object sender, EventArgs e)
        {
            ShowUsers.DataSource = da.Execute("select Employee.Id,FirstName,LastName,UserName,UserPassword from Employee inner join Users on Employee.Id=Users.Id;");
        }
    }
}
