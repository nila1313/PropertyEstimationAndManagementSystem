using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms;
using PropertyEstimationAndManagementSystem.GuiForms.Consultant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Consultants(new Login(new HomePage()),new Entites.Users()));
            Application.Run(new HomePage());
            //Application.Run(new Payment(new Property(),new Customer(),new Users()));

        }
    }
}
