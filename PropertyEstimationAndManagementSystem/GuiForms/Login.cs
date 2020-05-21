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
using PropertyEstimationAndManagementSystem.GuiForms.Consultant;
using PropertyEstimationAndManagementSystem.GuiForms.OwnerGui;

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class Login : Form
    {
        private DataAccess da;
        Users users;
        HomePage home;
        public Login(HomePage home)
        {
            InitializeComponent();
            da = new DataAccess();
            users = new Users();
            this.home = home;
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            users.UserName = txtUserName.Text;
            users.UserPassword = txtUserPassword.Text;
            try
            {
                string where = string.Format("where UserName='{0}' and UserPassword='{1}'", users.UserName, users.UserPassword);
                DataTable dt = da.GetData<Users>(where);
                users.Id=Convert.ToInt32(dt.Rows[0][3].ToString());
                if (dt.Rows[0][2].ToString().ToUpper() == "MANAGER")
                {
                    Manager man = new Manager(this, users);
                    man.Show();
                    home.Hide();
                }
                if (dt.Rows[0][2].ToString().ToUpper() == "REPORTER")
                {
                    Reporter rep = new Reporter(this, users);
                    rep.Show();
                    home.Hide();
                }
                if (dt.Rows[0][2].ToString().ToUpper() == "CONSULTANT")
                {
                    Consultants con = new Consultants(this, users);
                    con.Show();
                    home.Hide();
                }
                if (dt.Rows[0][2].ToString().ToUpper() == "OWNER")
                {
                    Owners owns = new Owners(this, users);
                    owns.Show();
                    home.Hide();
                }
                MessageBox.Show("Login Success");
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}