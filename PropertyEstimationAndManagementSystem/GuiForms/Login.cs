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
        DataAccess da;
        LoginInfo login;
        public Login()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            login = new LoginInfo();
            login.Id = 2;
            login.Username = "ARE";
            login.Password = "1234";
            da.Insert<LoginInfo>(login,true);
            MessageBox.Show(login.GetType().Name);
        }
    }
}
