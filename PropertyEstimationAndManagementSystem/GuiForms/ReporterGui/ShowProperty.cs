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
    public partial class ShowProperty : Form
    {
        Form prevForm;
        Property property;
        public ShowProperty(Form prevForm,Property property)
        {
            InitializeComponent();
            this.prevForm = prevForm;
            this.property = property;
        }
    }
}
