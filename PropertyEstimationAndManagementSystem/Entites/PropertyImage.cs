using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    public class PropertyImage:BaseEntity
    {
        public int PropertyID { get; set; }
        public string Image { get; set; }
    }
}
