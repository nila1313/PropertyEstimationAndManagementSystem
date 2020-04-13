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
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReporter_Click(object sender, EventArgs e)
        {
            Reporter repoter = new Reporter();

        }

        private void userLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager m = new Manager();
            m.Show();
        }
    }
}