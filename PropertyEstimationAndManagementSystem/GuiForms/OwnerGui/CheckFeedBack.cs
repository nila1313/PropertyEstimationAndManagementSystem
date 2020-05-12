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
    public partial class CheckFeedBack : Form
    {
        DataAccess da;
        public CheckFeedBack()
        {
            InitializeComponent();
            da = new DataAccess();
        }

        private void dataGridShowFeedBack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridShowFeedBack.SelectedRows[0];
            lblDescriptionValue.Text = row.Cells[4].Value.ToString();
        }

        private void CheckFeedBack_Load(object sender, EventArgs e)
        {
            lblDescriptionValue.Text = "";
            dataGridShowFeedBack.DataSource = da.Execute("select EmployeeId,FirstName,LastName,Designation,Description from Employee inner join FeedBack on Employee.Id=FeedBack.EmployeeId");
            dataGridShowFeedBack.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
    
}
