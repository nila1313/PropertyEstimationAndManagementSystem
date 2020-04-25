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

namespace PropertyEstimationAndManagementSystem.GuiForms.OwnerGui
{
    public partial class TransactionDetails : Form
    {
        DataAccess da;
        string tradeType;
        public TransactionDetails()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void TransactionDetails_Load(object sender, EventArgs e)
        {
            radioButtonBought.Checked = true;
            tradeType = "bought";
            dataGrid.AutoGenerateColumns = false;
            showList();
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void showList()
        {
            dataGrid.DataSource = da.GetData<Transaction>($"where Trade like'{tradeType.ToUpper()}'");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            dataGrid.DataSource = da.GetData<Transaction>($"where Trade like'{"bought".ToUpper()}' and convert(varchar, TransactionDateTime,101)='{today}'");
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            string thisWeekFriday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Friday).ToString("MM/dd/yyyy");
            dataGrid.DataSource = da.GetData<Transaction>($"where Trade like'{tradeType.ToUpper()}' and convert(varchar, TransactionDateTime,101)>='{thisWeekFriday}'");

        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            string thisYearFirstDate = "01/01/" + DateTime.Now.Year.ToString();
            dataGrid.DataSource = da.GetData<Transaction>($"where Trade like'{tradeType.ToUpper()}' and convert(varchar, TransactionDateTime,101)>='{thisYearFirstDate}'");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedDate=dateTimePicker.Value.ToString("MM/dd/yyyy");
            dataGrid.DataSource = da.GetData<Transaction>($"where Trade like'{tradeType.ToUpper()}' and convert(varchar, TransactionDateTime,101)='{selectedDate}'");
        }

        private void radioButtonBought_CheckedChanged(object sender, EventArgs e)
        {
            tradeType = "bought";
            showList();
        }

        private void radioButtonSold_CheckedChanged(object sender, EventArgs e)
        {
            tradeType = "sold";
            showList();
        }
    }
}
