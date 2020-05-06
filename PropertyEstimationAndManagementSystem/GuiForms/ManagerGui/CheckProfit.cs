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

namespace PropertyEstimationAndManagementSystem.GuiForms.ManagerGui
{
    public partial class CheckProfit : Form
    {
        DataAccess da;

        public CheckProfit()
        {
            InitializeComponent();
            da = new DataAccess();
            setPanel();
        }
        public void setPanel()
        {
            string prob = @"""Transaction""";
            string thisWeekSunday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Sunday).ToString("MM/dd/yyyy");
            string sql = @"select count(*) from " + prob + $" where convert(varchar, TransactionDateTime,101)>='{thisWeekSunday}'";
            DataTable dt = da.Execute(sql);
            TotalTransaction.Text = dt.Rows[0][0].ToString();
        }

        public void setChart()
        {
            Profit.Titles.Add("Profit Estimation");
            Profit.Series["s1"].Points.AddXY("#PERCENT Transaction", Convert.ToDouble(TotalTransaction.Text));
            Profit.Series["s1"].Points.AddXY("#PERCENT Profit", Convert.ToDouble(TotalProfit.Text));
            Profit.Series["s1"].Points.AddXY("#PERCENT Salary", Convert.ToDouble(TotalSalary.Text));
            Profit.Series["s1"].Points.AddXY("#PERCENT Net Profit", Convert.ToDouble(NetProfit.Text));
        }

    }
}
