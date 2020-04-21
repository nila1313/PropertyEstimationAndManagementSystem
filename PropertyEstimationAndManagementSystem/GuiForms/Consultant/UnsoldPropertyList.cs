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
    public partial class UnsoldPropertyList : Form
    {
        Users user;
        DataAccess da;
        Property property;
        Consultants cons;
        public UnsoldPropertyList(Users user,Consultants cons)
        {
            InitializeComponent();
            this.user = user;
            da = new DataAccess();
            property = new Property();
            this.cons = cons;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (property.Id != 0)
            {
                property.Status = "Available";
                cons.OpenFormPanel(new ShowCustomer(property, user, cons));
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a ROW");
            }
        }

        private void UnsoldPropertyList_Load(object sender, EventArgs e)
        {
            dataGridPropertyList.DataSource = da.GetData<Property>("where Status='Unsold'");
            dataGridPropertyList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridPropertyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var row = dataGridPropertyList.SelectedRows[0] as DataGridViewRow;
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
        }
    }
}
