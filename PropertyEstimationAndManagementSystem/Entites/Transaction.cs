using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    public class Transaction : BaseEntity
    {
        public int CustomerId { set; get; }
        public int PropertyId { set; get; }
        public int EmployeeId {set; get;}
        public long Amount { set; get; }
        public string ChequeNumber { set; get; }
        public string TransactionDateTime { set; get; }
        public string TransactionType { set; get; }

        public string Trade { set; get; }
        
    }


    
}
