using Microsoft.SqlServer.Server;
using PropertyEstimationAndManagementSystem.Data;
using PropertyEstimationAndManagementSystem.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyEstimationAndManagementSystem.GuiForms.ReporterGui
{
    public partial class PropertyHome : Form
    {
        Property property;
        DataAccess da;
        const double alpha = 0.4;
        double buyProfit, sellProfit;
        string imageLocation1, imageLocation2, imageLocation3;
        int count;
        string eventType;
        public PropertyHome(Property property,String eventType)
        {
            InitializeComponent();
            this.property = property;
            this.da = new DataAccess();
            this.eventType = eventType;
        }

        private void PropertyHome_Load(object sender, EventArgs e)
        {
            lblPropertyName.Text = property.Name;
            lblArea.Text = property.Area;
            lblSize.Text = property.Size.ToString()+ "  Square Feet";
            SetProfit();
            setDescription();
            setEstimatedValue();
            setImage();
        }

        public void setDescription()
        {
            try
            {
                DataTable dt = da.GetData<Entites.PropertyDescription>(string.Format("where Id={0}", property.Id.ToString()));
                lblPropetyDescription.Text=dt.Rows[0][0].ToString();
            }
            catch(Exception exe)
            {
                lblPropetyDescription.Text = "No Description Available";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            count = (count + 1) % 3;
            selectPicture();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            count = (count - 1) % 3;
            selectPicture();
        }

        public void setEstimatedValue()
        {
            string sql = string.Format("select area, round(sum(price) / sum(size), 2) as 'Average Price per Square Feet' from property where area like '%{0}%' group by area ", property.Area);
            DataTable dt = da.Execute(sql);
            
            if (eventType=="Sell" || eventType=="Null")
            {
                double perUnit = Convert.ToDouble(dt.Rows[0][1].ToString());
                double AverageValue = perUnit * property.Size;
                double difference = property.Price - AverageValue;
                double totalPrice = difference * alpha + property.Price;
                double estimatedValue = totalPrice + totalPrice * (sellProfit/100);
                lblValue.Text = estimatedValue.ToString();
            }
            if(eventType=="Buy")
            {
                double perUnit = Convert.ToDouble(dt.Rows[0][1].ToString());
                double AverageValue = perUnit * property.Size;
                double difference = property.Price - AverageValue;
                double totalPrice = difference * alpha + property.Price;
                double estimatedValue = totalPrice - totalPrice * (buyProfit/100);
                lblValue.Text = estimatedValue.ToString();
            }
        }

        public void setImage()
        {
            try
            {
                DataTable dt = da.GetData<PropertyImage>(string.Format("where PropertyID={0}", property.Id));                
                string currentLocation = Directory.GetCurrentDirectory();
                string projectDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(currentLocation).FullName).FullName).FullName;
                imageLocation1=projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + dt.Rows[0][1].ToString();
                imageLocation2=projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + dt.Rows[1][1].ToString();
                imageLocation3=projectDir + @"\PropertyEstimationAndManagementSystem\Pictures\" + dt.Rows[2][1].ToString();
                pictureBox1.Image=Image.FromFile(imageLocation1);
                count = 1;
            }
            catch(Exception exe)
            {
                count = -6;
            }
        }
        public void selectPicture()
        {
            try
            {
                if (count == 1 || count == -1)
                {
                    pictureBox1.Image = Image.FromFile(imageLocation1);
                }
                if (count == 2 || count == -2)
                {
                    pictureBox1.Image = Image.FromFile(imageLocation2);
                }
                if (count == 0)
                {
                    pictureBox1.Image = Image.FromFile(imageLocation3);
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("No Picture Available");
            }
        }
        public void SetProfit()
        {
            DataTable dt = da.GetData<MainAccount>("");
            sellProfit = Convert.ToDouble(dt.Rows[0][1].ToString());
            buyProfit = Convert.ToDouble(dt.Rows[0][2].ToString());
        }
    }

}
