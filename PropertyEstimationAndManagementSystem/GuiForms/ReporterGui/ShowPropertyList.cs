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

namespace PropertyEstimationAndManagementSystem.GuiForms.ReporterGui
{
    public partial class ShowPropertyList : Form
    {
        DataAccess da;
        Form prevForm;
        Property property;
        public ShowPropertyList(Form prevForm)
        {
            InitializeComponent();
            da = new DataAccess();
            this.prevForm = prevForm;
            this.property = new Property();

        }

        private void ShowPropertyList_Load(object sender, EventArgs e)
        {
            showProperty();
        }

        public void showProperty()
        {
            dataGridPropertyList.DataSource = da.GetData<Property>("");
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

            try
            {
                PropertyHome ph = new PropertyHome(property,"Null");
                ph.Show();
            }
            catch(Exception exe)
            {
                MessageBox.Show("NO DESCRIPTION AVAILABLE");
            }
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            
            if(prevForm is Reporter)
            {
                Reporter rep = prevForm as Reporter;
                rep.OpenFormPanel(new EditProperty(new Property(),prevForm,"Insert"));
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(property.Id!=0)
            {
                if (prevForm is Reporter)
                {
                    Reporter rep = prevForm as Reporter;
                    rep.OpenFormPanel(new EditProperty(property, prevForm, "Update"));
                }
            }
            else
            {
                MessageBox.Show("Please select a row!!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to confirm?", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {    if (property.Id != 0)
                {
                    da.remove<Property>(property);
                    showProperty();
                    MessageBox.Show("Remove successful!!");
                }
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            if(property.Id!=0)
            {
                ((Reporter)prevForm).OpenFormPanel(new PropertyDescription(this,property));
            }
        }
    }
}
