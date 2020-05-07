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

namespace PropertyEstimationAndManagementSystem.GuiForms.Consultant
{
    public partial class Search : Form
    {
        DataAccess da;
        ShowCustomer showCustomer;
        public Property property { get; set; }
        Users user;
        Consultants cons;
        public Search(Users user, Consultants cons)
        {
            InitializeComponent();
            property = new Property();
            da = new DataAccess();
            this.user = user;
            this.cons = cons;
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            if(property.Id!=0)
            {
                property.Status = "Sold";
                showCustomer = new ShowCustomer(property,user,cons);
                cons.OpenFormPanel(showCustomer);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a ROW");
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (property.Id != 0)
            {
                property.Status = "Booked";
                showCustomer = new ShowCustomer(property, user, cons);
                cons.OpenFormPanel(showCustomer);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a ROW");
            }
        }


        private void Search_Load(object sender, EventArgs e)
        {
            showProperty();
        }

        public void showProperty()
        {
            dataGridProperty.DataSource = da.GetData<Property>("where Status='Available'");
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
            catch(Exception eae)
            {
                MessageBox.Show("Please select a row");
            }

            try
            {
                PropertyHome ph = new PropertyHome(property,"Sell");
                ph.Show();
            }
            catch (Exception exe)
            {
                MessageBox.Show("NO DESCRIPTION AVAILABLE");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnPropertySearch_Click(object sender, EventArgs e)
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
                string whereClause = string.Format("where Status='Available' and Price >= {0} and Area like '%{1}%' and Size >= {2}", txtPrice.Text, txtArea.Text, txtSize.Text);
                dataGridProperty.DataSource = da.GetData<Property>(whereClause);
            }
            catch(Exception exe)
            {
                MessageBox.Show("Price and Size must have to be in Numbers");

            }
            
        }

       
    }
}
