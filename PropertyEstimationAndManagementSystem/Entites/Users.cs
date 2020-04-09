using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    class Users: BaseEntity
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
