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
            if(property.Status.ToUpper()=="BOOKED")
            {
                da.remove<BookedProperty>(string.Format("where PropertyId={0}", property.Id.ToString()));
            }
            property.Id= Convert.ToInt32(txtPropertyId.Text);
            property.Name = txtPropertyName.Text;
            property.Area = txtArea.Text;
            property.Size= Convert.ToDouble(txtSize.Text);
            property.Price=Convert.ToDouble(txtPrice.Text);
            property.Status = comboBoxStatus.Text;
            da.Insert<Property>(property,true);
            MessageBox.Show("Update Successful!");
            this.Dispose();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            property.Name = txtPropertyName.Text;
            property.Area = txtArea.Text;
            property.Size = Convert.ToDouble(txtSize.Text);
            property.Price = Convert.ToDouble(txtPrice.Text);
            property.Status = comboBoxStatus.Text;
            da.Insert<Property>(property, true);
            MessageBox.Show("Insert Successful!");
            this.Dispose();
        }
    }
}
