using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms.ReporterGui;
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
    public partial class ShowProperty : Form
    {
        DataAccess da;
        Property property;

        public ShowProperty()
        {
            InitializeComponent();
            da = new DataAccess();
            property = new Property();
        }

        private void ShowProperty_Load(object sender, EventArgs e)
        {
            refreshList();
            this.dataGridProperty.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataGridProperty.DefaultCellStyle.BackColor = Color.FromArgb(36, 36, 36);
        }

        private void refreshList()
        {
            dataGridProperty.DataSource = da.GetData<Property>("");
            dataGridProperty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridProperty.SelectedRows[0] as DataGridViewRow;
                property.Id = Convert.ToInt32(row.Cells[5].Value.ToString());
                property.Name = row.Cells[0].Value.ToString();
                property.Status = row.Cells[1].Value.ToString();
                property.Area = row.Cells[2].Value.ToString();
                property.Price = Convert.ToDouble(row.Cells[3].Value.ToString());
                property.Size = Convert.ToDouble(row.Cells[4].Value.ToString());
            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }

            try
            {
                PropertyHome ph = new PropertyHome(property, "Null");
                ph.Show();
            }
            catch (Exception exe)
            {
                MessageBox.Show("NO DESCRIPTION AVAILABLE");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //select* from property where Price <= 10 and Area like '%%' and Size <= 9000
            try
            {
                if (txtPrice.Text == "")
                {
                    txtPrice.Text = "0";
                }
                if (txtSize.Text == "")
                {
                    txtSize.Text = "0";
                }
                Convert.ToInt32(txtPrice.Text);
                Convert.ToInt32(txtSize.Text);
                string whereClause = string.Format("where Price >= {0} and Area like '%{1}%' and Size >= {2}", txtPrice.Text, txtArea.Text, txtSize.Text);
                dataGridProperty.DataSource = da.GetData<Property>(whereClause);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Price and Size must have to be in Numbers");

            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            refreshList();
        }
    }
}
