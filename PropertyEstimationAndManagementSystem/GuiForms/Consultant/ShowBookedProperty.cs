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
    public partial class ShowBookedProperty : Form
    {
        DataAccess da;
        Property property;
        Customer customer;
        Users user;
        Consultants consultant;
        public ShowBookedProperty(Users user,Consultants consultant)
        {
            InitializeComponent();
            da = new DataAccess();
            property = new Property();
            customer = new Customer();
            this.user = user;
            this.consultant = consultant;
        }

        private void ShowBookedProperty_Load(object sender, EventArgs e)
        {
            updateList();
            lblCustomerName.Hide();
            lblPhoneNumber.Hide();
            btnPayment.Hide();
        }

        private void updateList()
        {
            dataGridBookedProperty.DataSource = da.GetData<Property>("where Status='Booked'");
            dataGridBookedProperty.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridBookedProperty.SelectedRows[0] as DataGridViewRow;
                property.Id = Convert.ToInt32(row.Cells[5].Value.ToString());
                property.Name = row.Cells[0].Value.ToString();
                property.Status = row.Cells[1].Value.ToString();
                property.Area = row.Cells[2].Value.ToString();
                property.Price = Convert.ToDouble(row.Cells[3].Value.ToString());
                property.Size = Convert.ToDouble(row.Cells[4].Value.ToString());

                DataTable dt = da.GetData<BookedProperty>(string.Format("where PropertyId={0}", property.Id));
                customer.Id = Convert.ToInt32(dt.Rows[0][0].ToString());
                var row2 = da.GetData<Customer>(string.Format("where Id={0}", customer.Id)).Rows[0];
                customer.FirstName = row2[0].ToString();
                customer.LastName = row2[1].ToString();
                customer.Address = row2[2].ToString();
                customer.MobileNumber = row2[3].ToString();
                customer.Email = row2[4].ToString();
                customer.Nid = row2[5].ToString();

                lblCustomerName.Text = customer.FirstName +" "+ customer.LastName;
                lblPhoneNumber.Text = customer.MobileNumber;
                lblCustomerName.Show();
                lblPhoneNumber.Show();
                btnPayment.Show();

            }
            catch (Exception eae)
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void dataGridBookedProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPayment.Hide();
            try
            {
                var row = dataGridBookedProperty.SelectedRows[0] as DataGridViewRow;
                property.Id = Convert.ToInt32(row.Cells[5].Value.ToString());
                property.Name = row.Cells[0].Value.ToString();
                property.Status = row.Cells[1].Value.ToString();
                property.Area = row.Cells[2].Value.ToString();
                property.Price = Convert.ToDouble(row.Cells[3].Value.ToString());
                property.Size = Convert.ToDouble(row.Cells[4].Value.ToString());
                PropertyHome ph = new PropertyHome(property);
                ph.Show();
            }
            catch (Exception exe)
            {
                MessageBox.Show("NO DESCRIPTION AVAILABLE");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(property,customer,user);
            consultant.OpenFormPanel(payment);
            this.Dispose();
        }
    }
}
