using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JoiningDate { get; set; }
        public string Type { get; set; }
        public double Salary { get; set; }
        public string DateOfBirth { get; set; }
        public string BloodGroup { get; set; }

    }
}
