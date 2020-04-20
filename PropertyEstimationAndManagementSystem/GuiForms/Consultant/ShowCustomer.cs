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
    public partial class ShowCustomer : Form
    {
        Property property;
        Customer customer;
        Users user;
        DataAccess da;
        Payment payment;
        CustomerInformation customerInfo;
        Search search;
        BookedProperty bookedProperty;
        public ShowCustomer(Property property, Users user, Search search)
        {
            InitializeComponent();
            this.property = property;
            customer = new Customer();
            this.user = user;
            da = new DataAccess();
            this.search = search;

        }


        private void ShowCustomer_Load(object sender, EventArgs e)
        {
            showList();
            if (property.Status=="NULL")
            {
                btnSelect.Hide();
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            customerInfo = new CustomerInformation(this,property);
            this.Hide();
            customerInfo.Show();
        }

        public void showList()
        {
            dataGridCustomer.DataSource = da.GetData<Customer>("");
            dataGridCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(customer.Id!=0)
            {
                if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (property.Status.ToUpper() == "SOLD")
                    {
                        payment = new Payment(property, customer, user);
                        payment.Show();
                        this.Dispose();
                    }
                    if (property.Status.ToUpper() == "BOOKED")
                    {
                        bookedProperty = new BookedProperty();
                        bookedProperty.Id = 0;
                        bookedProperty.EmployeeId = user.Id;
                        bookedProperty.customerId = customer.Id;
                        bookedProperty.PropertyId = property.Id;
                        property.Status = "Booked";
                        da.Insert<Property>(property,true);
                        da.Insert<BookedProperty>(bookedProperty,true);
                        MessageBox.Show("Booked!");
                        this.Dispose();
                        search.showProperty();
                        search.property.Id = 0;
                        search.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A ROW");
            }
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridCustomer.SelectedRows[0] as DataGridViewRow;
                customer.FirstName = row.Cells[0].Value.ToString();
                customer.LastName = row.Cells[1].Value.ToString();
                customer.Address = row.Cells[2].Value.ToString();
                customer.MobileNumber = row.Cells[3].Value.ToString();
                customer.Email = row.Cells[4].Value.ToString();
                customer.Nid = row.Cells[5].Value.ToString();
                customer.Id = Convert.ToInt32(row.Cells[6].Value.ToString());
            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }
        }
    }
}
