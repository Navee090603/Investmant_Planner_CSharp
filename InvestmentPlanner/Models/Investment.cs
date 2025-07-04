using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentPlanner.Models
{
    public class Investment
    {
        public double Amount { get; set; }
        public int Years { get; set; }
        public double AnnualRate { get; set; }
        public bool IsSip { get; set; }
    }
}
