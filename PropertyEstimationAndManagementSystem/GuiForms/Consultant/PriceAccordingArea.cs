using PropertyEstimationAndManagementSystem.Data;
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
    public partial class PriceAccordingArea : Form
    {
        DataAccess da;
        public PriceAccordingArea()
        {

            InitializeComponent();
            da = new DataAccess();
        }

        private void PriceAccordingArea_Load(object sender, EventArgs e)
        {
            
            string sql = "select area, round(sum(price) / sum(size), 2) as 'Average Price per Square Feet' from property group by area";
            
            dataGridArea.DataSource= da.Execute(sql);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select area, round(sum(price) / sum(size), 2) as 'Average Price per Square Feet' from property where area like '%{0}%' group by area ", txtAreaName.Text);
            dataGridArea.DataSource = da.Execute(sql);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
