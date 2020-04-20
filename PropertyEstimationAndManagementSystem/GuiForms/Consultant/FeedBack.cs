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

namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    public partial class FeedBack : Form
    {
        DataAccess da;
        Entites.FeedBack feedBack;
        Users user;
        Consultants consultant;

        public FeedBack(Users user,Consultants consultant)
        {
            InitializeComponent();
            da = new DataAccess();
            feedBack = new Entites.FeedBack();
            this.user=user;
            this.consultant = consultant;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            feedBack.EmployeeId = user.Id;
            feedBack.Description = richtxtDescription.Text;

            da.Insert<Entites.FeedBack>(feedBack,true);

            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Your Feedback has been recieved");

            }
            
        }

      
    }
}
