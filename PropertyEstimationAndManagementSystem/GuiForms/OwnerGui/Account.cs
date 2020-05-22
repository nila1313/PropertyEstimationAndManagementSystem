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
    public partial class Account : Form
    {
        DataAccess da;
        MainAccount mainAcc;
        public Account()
        {
            InitializeComponent();
            da = new DataAccess();
            mainAcc = new MainAccount();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }

        private void RefreshPage()
        {
            DataTable dt = da.GetData<MainAccount>("");
            lblCurrentBalanceValue.Text = dt.Rows[0][0].ToString();
            lblSellCurrentProfitPercentValue.Text = dt.Rows[0][1].ToString();
            lblCurrentBuyProfitPercentValue.Text = dt.Rows[0][2].ToString();
            lblCurrentCompanyNameValue.Text = dt.Rows[0][3].ToString();

            mainAcc.Id = 0;
            mainAcc.Balance = Convert.ToDouble(lblCurrentBalanceValue.Text);
            mainAcc.SellProfitPercent = Convert.ToDouble(lblSellCurrentProfitPercentValue.Text);
            mainAcc.BuyProfitPercent= Convert.ToDouble(lblCurrentBuyProfitPercentValue.Text);
            mainAcc.CompanyName = lblCurrentCompanyNameValue.Text;

            txtChangeName.Text = mainAcc.CompanyName;
        }

        private void btnProfitChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    double currentSell= Convert.ToDouble(txtSellProfitPercent.Text);
                    if(currentSell>=0 && currentSell<=100)
                    {
                        mainAcc.SellProfitPercent = currentSell;
                        da.Insert<MainAccount>(mainAcc, false);
                        MessageBox.Show("Profit Value Changed!!");
                        RefreshPage();
                    }
                    else
                    {
                        MessageBox.Show("The value must have to be within 0-100");
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Put a valid number");
                }

            }
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    mainAcc.CompanyName = txtChangeName.Text;
                    da.Insert<MainAccount>(mainAcc, false);
                    MessageBox.Show("Company Name Changed!!");
                    RefreshPage();
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Put a valid number");
                }

            }
        }

        private void btnBuyChangeProperty_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    double currentSell = Convert.ToDouble(txtBuyProfitPercent.Text);
                    if (currentSell >= 0 && currentSell <= 100)
                    {
                        mainAcc.BuyProfitPercent = currentSell;
                        da.Insert<MainAccount>(mainAcc, false);
                        MessageBox.Show("Profit Value Changed!!");
                        RefreshPage();
                    }
                    else
                    {
                        MessageBox.Show("The value must have to be within 0-100");
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show("Put a valid number");
                }

            }
        }

        private void txtChangeName_Validating(object sender, CancelEventArgs e)
        {
            var changeName = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(changeName))
            {
                e.Cancel = true;
                txtChangeName.Focus();
                errorProvider1.SetError(txtChangeName, "$This field should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtChangeName, "");
            }
        }

        private void txtSellProfitPercent_Validating(object sender, CancelEventArgs e)
        {
            var sellprofitPercent = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(sellprofitPercent))
            {
                e.Cancel = true;
                txtSellProfitPercent.Focus();
                errorProvider1.SetError(txtSellProfitPercent, "$Percentage of Sell Profit required!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSellProfitPercent, "");
            }
        }

        private void txtBuyProfitPercent_Validating(object sender, CancelEventArgs e)
        {
            var buyProfitPercent = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(buyProfitPercent))
            {
                e.Cancel = true;
                txtBuyProfitPercent.Focus();
                errorProvider1.SetError(txtBuyProfitPercent, "$Percentage of Sell Profit required!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBuyProfitPercent, "");
            }
        }
    }
}
