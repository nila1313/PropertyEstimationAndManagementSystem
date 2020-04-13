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

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class Login : Form
    {
        private DataAccess da;
        Users users;

        public Login()
        {
            InitializeComponent();
            da = new DataAccess();
            users = new Users();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            users.UserName = txtUserName.Text;
            users.UserPassword = txtUserPassword.Text;
            try
            {
                string where = string.Format("where UserName='{0}' and UserPassword='{1}'", users.UserName, users.UserPassword);
                DataTable dt = da.GetData<Users>(where);
                MessageBox.Show("Login Success");
                if (dt.Rows[0][2].ToString().ToUpper() == "MANAGER")
                {
                    Manager man = new Manager(this, users);
                    man.Show();
                    this.Hide();
                }
                if (dt.Rows[0][2].ToString().ToUpper() == "REPORTER")
                {
                    Reporter rep = new Reporter(this, users);
                    rep.Show();
                    this.Hide();
                }
            }
            catch(Exception en)
            {
                MessageBox.Show("Login Failed");
            }
        }
        private void userLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager m = new Manager(this,users) ;
            m.Show();
        }
    }
}