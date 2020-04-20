using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    public class BookedProperty : BaseEntity
    {
        public int customerId { get; set; }
        public int PropertyId { get; set; }
        public int EmployeeId { get; set; }
    }
}
