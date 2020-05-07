using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEstimationAndManagementSystem.Entites
{
    class MainAccount:BaseEntity
    {
        public double Balance { get; set; }
        public double SellProfitPercent { get; set; }
        public double BuyProfitPercent { get; set; }
        public string CompanyName { get; set; }
    }
}
