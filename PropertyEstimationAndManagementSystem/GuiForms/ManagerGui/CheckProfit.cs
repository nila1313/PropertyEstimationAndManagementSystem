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
        double totalSale, totalBuy;
        public CheckProfit()
        {
            InitializeComponent();
            da = new DataAccess();
            setPanel();
        }
        public void setPanel()
        {
            string thisMonth;
            string prob = @"""Transaction""";
            if(DateTime.Now.Month<10)
            {
                thisMonth ="0"+ DateTime.Now.Month.ToString() + @"/01/" + DateTime.Now.Year.ToString();
            }
            else
            {
                thisMonth = DateTime.Now.Month.ToString() + @"/01/" + DateTime.Now.Year.ToString();
            }
            
            //TOTAL TRANSACTION
            string sql = $"select count(*) from {prob} where convert(varchar, TransactionDateTime,101)>='{thisMonth}'";
            DataTable dt = da.Execute(sql);
            TotalTransaction.Text = dt.Rows[0][0].ToString();
            
            //TOTAL SALARY
            sql = @"select SUM(Salary) from Employee";
            dt = da.Execute(sql);
            TotalSalary.Text= dt.Rows[0][0].ToString();

            //TOTAL PROFIT
            sql = @"select SUM(amount) from " + prob + $" where Trade='SOLD' and convert(varchar, TransactionDateTime,101)>='{thisMonth}'";
            dt = da.Execute(sql);
            this.totalSale = Convert.ToDouble(dt.Rows[0][0]);
            sql = @"select SUM(amount) from " + prob + $" where Trade='BOUGHT' and convert(varchar, TransactionDateTime,101)>='{thisMonth}'";
            dt = da.Execute(sql);
            this.totalBuy = Convert.ToDouble(dt.Rows[0][0]);
            double totalProfit = totalSale - totalBuy;
            if (totalProfit<0)
            {
                lblTotalProfit.Text = "Total Loss";
            }
            TotalProfit.Text = Math.Abs(totalProfit).ToString();

            //TOTAL NET PROFIT
            NetProfit.Text = (Convert.ToDouble(TotalProfit.Text) - Convert.ToDouble(TotalSalary.Text)).ToString();
        }


        private void CheckProfit_Load(object sender, EventArgs e)
        {
            setChart();
        }

      
        public void setChart()
        {
            Profit.Titles.Add("Total Transaction,salary,Profit estimation");
            //Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(TotalTransaction.Text));
            //Profit.Series["s1"].Points[0].LegendText = "Total Transaction";
            //Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(TotalProfit.Text));
            //Profit.Series["s1"].Points[0].LegendText = "Total Profit";
            Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(totalSale));
            Profit.Series["s1"].Points[0].LegendText = "Total Sale";
            Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(totalBuy));
            Profit.Series["s1"].Points[1].LegendText = "Total Buy";
            Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(TotalSalary.Text));
            Profit.Series["s1"].Points[2].LegendText = "Total Salary";
            Profit.Series["s1"].Points.AddXY("#PERCENT", Convert.ToDouble(NetProfit.Text));
            Profit.Series["s1"].Points[3].LegendText = "Net Profit";
        }
    }
}
