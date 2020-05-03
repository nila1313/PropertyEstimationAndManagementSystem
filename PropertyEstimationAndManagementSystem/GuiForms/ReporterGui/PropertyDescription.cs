using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
        Image image1, image2, image3;
        string imageLocation1, imageLocation2, imageLocation3;
        PropertyImage propertyImage;
        DataAccess da;
        Entites.PropertyDescription pd;
        public PropertyDescription(Form form,Property property)
        {
            InitializeComponent();
            this.form = form;
            this.property = property;
            this.propertyImage = new PropertyImage();
            this.pd = new Entites.PropertyDescription();
            this.da = new DataAccess(); 
        }

        private void PropertyDescription_Load(object sender, EventArgs e)
        {
            lblPropertyIDValue.Text = property.Id.ToString();
            this.image1 = null;
            this.image2 = null;
            this.image3 = null;
            this.propertyImage.PropertyID = property.Id;
            this.pd.Id = property.Id;
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                this.image1 = Image.FromFile(ofd.FileName);
                pictureBox1.Image = image1;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image1,typeof(byte[]));                
            }
        }

        private void btnUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.image2 = Image.FromFile(ofd.FileName);
                pictureBox2.Image = image2;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image2, typeof(byte[]));
            }
        }

        private void btnUpload3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.image3 = Image.FromFile(ofd.FileName);
                pictureBox3.Image = image3;
                byte[] arr;
                ImageConverter converter = new ImageConverter();
                arr = (byte[])converter.ConvertTo(image3, typeof(byte[]));
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.image1 != null && this.image2 != null && this.image3!=null)
                {
                    RemoveImage();
                    string currentLocation = Directory.GetCurrentDirectory();
                    string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
                    this.imageLocation1 = projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + property.Id.ToString() + "1.jpg";
                    image1.Save(imageLocation1, ImageFormat.Jpeg);

                    this.imageLocation2 = projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + property.Id.ToString() + "2.jpg";
                    image2.Save(imageLocation2, ImageFormat.Jpeg);

                    this.imageLocation3 = projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + property.Id.ToString() + "3.jpg";
                    image3.Save(imageLocation3, ImageFormat.Jpeg);

                    propertyImage.Image = property.Id.ToString() + "1.jpg";
                    da.Insert<PropertyImage>(propertyImage,true);

                    propertyImage.Image = property.Id.ToString() + "2.jpg";
                    da.Insert<PropertyImage>(propertyImage, true);

                    propertyImage.Image = property.Id.ToString() + "3.jpg";
                    da.Insert<PropertyImage>(propertyImage, true);

                    pd.Description = richTextBoxDescription.Text;
                    da.Insert<Entites.PropertyDescription>(pd, false);

                    MessageBox.Show("Save successfully");
                }
               else
                {
                    MessageBox.Show("Select minimum 3 pictures");
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Select minimum 3 pictures");
            }
        }

        public void RemoveImage()
        {
            DataTable dt = da.GetData<PropertyImage>(string.Format("where PropertyID={0}", property.Id.ToString()));
            if (dt.Rows.Count > 0)
            {
                da.remove<PropertyImage>(string.Format("where PropertyID={0}", property.Id.ToString()));
            }
        }
    }
}
