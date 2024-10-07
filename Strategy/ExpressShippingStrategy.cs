using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public double CalculateShipping(double distance, double weight)
        {
            return weight * 1.5 + distance * 1.1;
        }
    }
}
