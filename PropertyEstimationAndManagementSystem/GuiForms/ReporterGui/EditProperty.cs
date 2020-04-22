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
        public EditProperty(Property property,Form prevForm,string eventType)
        {
            InitializeComponent();
            this.property = property;
            this.prevForm = prevForm;
            this.eventType = eventType;
        }

        private void EditProperty_Load(object sender, EventArgs e)
        {
            if(eventType.ToUpper()=="INSERT")
            {
                btnUpdate.Hide();
            }
            if(eventType.ToUpper()=="UPDATE")
            {
                btnCreate.Hide();
                txtPropertyId.Text = property.Id.ToString();
                txtPropertyName.Text = property.Name;
                txtArea.Text = property.Area;
                txtSize.Text = property.Size.ToString();
                txtPrice.Text = property.Price.ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
