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

namespace PropertyEstimationAndManagementSystem.GuiForms
{
    public partial class EditProperty : Form
    {
        Property property;
        Form prevForm;
        string eventType;
        DataAccess da;
        public EditProperty(Property property,Form prevForm,string eventType)
        {
            InitializeComponent();
            this.property = property;
            this.prevForm = prevForm;
            this.eventType = eventType;
            da = new DataAccess();
        }

        private void EditProperty_Load(object sender, EventArgs e)
        {
            if(eventType.ToUpper()=="INSERT")
            {
                btnUpdate.Hide();
                comboBoxStatus.SelectedIndex = 0;
            }
            if(eventType.ToUpper()=="UPDATE")
            {
                btnCreate.Hide();
                txtPropertyId.Text = property.Id.ToString();
                txtPropertyName.Text = property.Name;
                txtArea.Text = property.Area;
                txtSize.Text = property.Size.ToString();
                txtPrice.Text = property.Price.ToString();
                for (int i = 0; i < comboBoxStatus.Items.Count; i++)
                {
                    if (comboBoxStatus.Text.ToUpper() == property.Status.ToUpper())
                    {
                        comboBoxStatus.SelectedIndex = i - 1;
                        break;
                    }
                    comboBoxStatus.SelectedIndex = i;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                if (property.Status.ToUpper() == "BOOKED")
                {
                    da.remove<BookedProperty>(string.Format("where PropertyId={0}", property.Id.ToString()));
                }
                property.Id = Convert.ToInt32(txtPropertyId.Text);
                property.Name = txtPropertyName.Text;
                property.Area = txtArea.Text;
                property.Size = Convert.ToDouble(txtSize.Text);
                property.Price = Convert.ToDouble(txtPrice.Text);
                property.Status = comboBoxStatus.Text;
                da.Insert<Property>(property, true);
                MessageBox.Show("Update Successful!");
                this.Dispose();
            }
            catch (Exception exe)
            {
                MessageBox.Show("PRICE AND AREA MUST BE NUMBERS");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try {
                property.Name = txtPropertyName.Text;
                property.Area = txtArea.Text;
                property.Size = Convert.ToDouble(txtSize.Text);
                property.Price = Convert.ToDouble(txtPrice.Text);
                property.Status = comboBoxStatus.Text;
                da.Insert<Property>(property, true);
                MessageBox.Show("Insert Successful!");
                this.Dispose();
            }
            catch(Exception exe)
            {
                MessageBox.Show("PRICE AND AREA MUST BE NUMBERS");
            }
        }

        private void txtPropertyName_Validating(object sender, CancelEventArgs e)
        {
            var propertyName = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                e.Cancel = true;
                txtPropertyName.Focus();
                errorProvider1.SetError(txtPropertyName, "$Property Name should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPropertyName, "");
            }
        }

        private void txtArea_Validating(object sender, CancelEventArgs e)
        {
            var propertyArea = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(propertyArea))
            {
                e.Cancel = true;
                txtArea.Focus();
                errorProvider1.SetError(txtArea, "$Area should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtArea, "");
            }
        }

        private void txtSize_Validating(object sender, CancelEventArgs e)
        {
            var Size = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(Size))
            {
                e.Cancel = true;
                txtSize.Focus();
                errorProvider1.SetError(txtSize, "$Property Size should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSize, "");
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            var propertyPrice = (sender as TextBox).Text;
            if (string.IsNullOrWhiteSpace(propertyPrice))
            {
                e.Cancel = true;
                txtPrice.Focus();
                errorProvider1.SetError(txtPrice, "$Property Price should not be empty!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrice, "");
            }
        }

     
        }
    }

