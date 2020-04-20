using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PropertyEstimationAndManagementSystem.Entites
{
    public class Property:BaseEntity
    {

        public string Name { get; set; }
        public string Status { get; set; }
        public string Area { get; set; }
        public double Price { get; set; }
        public double Size { get; set; }

    }
}
