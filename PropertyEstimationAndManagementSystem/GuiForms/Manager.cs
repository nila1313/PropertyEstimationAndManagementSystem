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
        public Manager()
        {
            InitializeComponent();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            EmployeeEdit ee = new EmployeeEdit();
            this.Hide();
            ee.Show();
        }
    }
}
