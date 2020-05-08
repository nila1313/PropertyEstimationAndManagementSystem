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
            setChart();
            dataGridArea.DataSource = da.Execute(sql);
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

        public void setChart()
        {
            DataTable dt=da.Execute("select Area,Count(*) as 'Total' from Property group by Area order by Total desc");
            chartArea.Titles.Add("Area Highest Price");
            for(int i=0;i<dt.Rows.Count;i++)
            {
                chartArea.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(dt.Rows[i][1]));
                chartArea.Series["s1"].Points[i].LegendText = dt.Rows[i][0].ToString();
            }
        }
    }
}
