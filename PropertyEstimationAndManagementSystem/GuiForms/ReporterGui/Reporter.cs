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
    public partial class Reporter: Form
    {
        Users user;
        Login login;
        public Reporter(Login login,Users user)
        {
            InitializeComponent();
            this.login = login;
            this.user = user;
        }

        private void btnEditReporter_Click(object sender, EventArgs e)
        {
            EditProperty property = new EditProperty();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Dispose();
        }
    }
}
