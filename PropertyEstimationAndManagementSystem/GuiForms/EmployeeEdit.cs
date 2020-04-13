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
    public partial class EmployeeEdit : Form
    {
        public EmployeeEdit()
        {
            InitializeComponent();
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            EmployeeAccount acc = new EmployeeAccount();
            acc.Show();
        }
    }
}
