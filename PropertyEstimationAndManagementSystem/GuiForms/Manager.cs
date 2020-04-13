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
    public partial class Manager : Form
    {
        Login login { get;}
        Users user { get;}
        public Manager(Login login, Users user)
        {
            InitializeComponent();
            this.login = login;
            this.user = user;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
