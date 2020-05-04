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
    public partial class Payment : Form
    {
        Property property;
        Transaction transaction;
        Customer customer;
        Users user;
        DataAccess da;
      public Payment(Property property,Customer customer,Users user)
        {
            InitializeComponent();
            this.property = property;
            this.customer = customer;
            this.user = user;
            this.transaction = new Transaction();
            this.da = new DataAccess();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            btnCash.Checked = true;
            txtChequeNumber.Hide();
            lblChequeNumber.Hide();
            transaction.EmployeeId = user.Id;
            transaction.CustomerId = customer.Id;
            transaction.PropertyId = property.Id;
            transaction.TransactionDateTime =DateTime.Now.ToString();
            transaction.TransactionType = "Cash";
            transaction.ChequeNumber = "0";
            if (property.Status.ToUpper() == "AVAILABLE")
            {
                transaction.Trade = "BOUGHT";

            }
            if(property.Status.ToUpper()=="SOLD" || property.Status.ToUpper() == "BOOKED")
            {
                transaction.Trade = "SOLD";
                property.Status = "SOLD";
            }
        }

        private void btncheque_CheckedChanged(object sender, EventArgs e)
        {
            txtChequeNumber.Show();
            lblChequeNumber.Show();
            transaction.TransactionType = "Cheque";
        }

        private void btnCash_CheckedChanged(object sender, EventArgs e)
        {
            txtChequeNumber.Hide();
            lblChequeNumber.Hide();
            transaction.TransactionType = "Cash";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            transaction.Amount = Convert.ToInt32(txtAmount.Text);
            if(transaction.TransactionType=="Cheque")
            {
                transaction.ChequeNumber = txtChequeNumber.Text;

            
            }

            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(property.Status.ToUpper()=="BOOKED")
                {
                    da.remove<BookedProperty>(string.Format("where PropertyId={0}",property.Id));
                }

                property.Price = Convert.ToDouble(txtAmount.Text);
                da.Insert<Transaction>(transaction,true);
                
                da.Insert<Property>(property, true);
                


                MessageBox.Show("CONGRATULATIONS!!!!");

                this.Dispose();
            }
        }
    }
}
