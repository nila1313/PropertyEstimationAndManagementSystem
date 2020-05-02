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
    public partial class PropertyDescription : Form
    {
        Form form;
        Property property;
        public PropertyDescription(Form form,Property property)
        {
            InitializeComponent();
            this.form = form;
            this.property = property;
        }

        private void PropertyDescription_Load(object sender, EventArgs e)
        {
            lblPropertyIDValue.Text = property.Id.ToString();
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image,typeof(byte[]));                
            }
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox2.ImageLocation = ofd.FileName;
                MessageBox.Show(pictureBox2.ImageLocation.ToString());
            }
        }

        private void btnUpload3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox3.ImageLocation = ofd.FileName;
                MessageBox.Show(pictureBox3.ImageLocation.ToString());
            }
        }
    }
}
