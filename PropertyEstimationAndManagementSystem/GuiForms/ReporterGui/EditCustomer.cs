using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using PropertyEstimationAndManagementSystem.GuiForms.Consultant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms.ReporterGui
{
    public partial class EditCustomer : Form
    {
        DataAccess da;
        Reporter prevForm;
        Customer customer;
        public EditCustomer(Reporter prevForm)
        {
            InitializeComponent();
            da = new DataAccess();
            this.prevForm = prevForm;
            this.customer = new Customer();
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            showCustomer();
        }
        public void showCustomer()
        {
            dataGridViewShowCustomer.DataSource = da.GetData<Customer>("");
            dataGridViewShowCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            prevForm.OpenFormPanel(new CustomerInformation(customer));
        }

        private void dataGridViewShowCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewShowCustomer.SelectedRows;
            customer.Id = Convert.ToInt32(row[0].Cells[6].Value.ToString());
            customer.FirstName = row[0].Cells[0].Value.ToString();
            customer.LastName= row[0].Cells[1].Value.ToString();
            customer.Address= row[0].Cells[2].Value.ToString();
            customer.MobileNumber= row[0].Cells[3].Value.ToString();
            customer.Email= row[0].Cells[4].Value.ToString();
            customer.Nid= row[0].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(customer.Id!=0)
                {
                    da.remove<Customer>(customer);
                    MessageBox.Show("Removed Successfully");
                    showCustomer();
                }
                else
                {
                    MessageBox.Show("Please select a row");
                }
            }
    
        }
    }
}
