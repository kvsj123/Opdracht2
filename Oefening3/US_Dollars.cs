using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening3
{
    internal class US_Dollars
    {
        public double amount { get; set; }

        public US_Dollars(double amount)
        {
            this.amount = amount;
        }

        public US_Dollars()
        {
        }

        public override string ToString()
        {
            return amount.ToString();
        }
    }
}
