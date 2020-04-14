using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyEstimationAndManagementSystem.Entites;

namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    public partial class Consultants : Form
    {
        Login login;
        Users users;
        public Consultants(Login login, Users users)
        {
            this.login = login;
            this.users = users;
            InitializeComponent();
        }

       
    }
}
