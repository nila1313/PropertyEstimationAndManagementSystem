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

namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    public partial class Sales : Form
    {
        DataAccess da;
        int estimatedSale, estimatedBuy;
        const double alpha = 0.5;
        public Sales()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            setLabel();
            estimatedSale = Convert.ToInt32(lblSaleEstimationTomorrowValue.Text);
            estimatedBuy = Convert.ToInt32(lblEstimatedBuyTomorrowValue.Text);
            setChart();
        }       

        public void setLabel()
        {
            lblSaleEstimationTomorrowValue.Text = getSaleTomorrow("Sold").ToString();
            lblEstimatedBuyTomorrowValue.Text = getSaleTomorrow("bought").ToString();

            string today = DateTime.Now.ToString("MM/dd/yyyy");
            lblTotalBuyTodayValue.Text = getSale("bought",today).ToString();
            lblTotalSaleTodayValue.Text = getSale("sold",today).ToString();

            string weekStart= DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Sunday).ToString("MM/dd/yyyy");
            lblTotalSaleWeekValue.Text= getSale("sold", weekStart).ToString();
            lblTotalBuyWeekValue.Text= getSale("bought", weekStart).ToString();
        }
        public void setChart()
        {
            chartBuySell.Titles.Add("Buy-Sale Estimation Tomorrow");
            chartBuySell.Series["s1"].Points.AddXY("#PERCENT SELL",estimatedSale);
            chartBuySell.Series["s1"].Points.AddXY("#PERCENT Buy",estimatedBuy);
        }
        public int getSale(string type,string today)
        {
            string prob = @"""Transaction""";
            string sql = @"select count(*) from " + prob + $" where Trade like'{type.ToUpper()}' and convert(varchar, TransactionDateTime,101)>='{today}'";
            DataTable dt = da.Execute(sql);
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public int getSaleTomorrow(string type)
        {
            int[] sevenDayTotal = new int[7];
            
            for (int i = 6,j=0; i >= 0; i--,j++)
            {
                string prob = @"""Transaction""";
                string today = DateTime.Now.AddDays(-i).ToString("MM/dd/yyyy");
                string sql = @"select count(*) from " + prob + $" where Trade like'{type.ToUpper()}' and convert(varchar, TransactionDateTime,101)='{today}'";
                DataTable dt = da.Execute(sql);
                sevenDayTotal[j]=Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            int[] sevenDayForcast = new int[8];
            sevenDayForcast[0] = sevenDayTotal[0];
            for (int i = 1; i < 8; i++)
            {
                sevenDayForcast[i] = (int)Math.Ceiling(sevenDayForcast[i - 1] + alpha * (sevenDayTotal[i - 1] - sevenDayForcast[i - 1]));
            }
            return sevenDayForcast[7];
        }

    }
}
