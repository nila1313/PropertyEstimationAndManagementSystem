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

namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    public partial class Owner : Form
    {
        Login login;
        Users user;
        public Owner(Login login,Users user)
        {
            InitializeComponent();
            this.login = login;
            this.user = user;
        }
    }
}
