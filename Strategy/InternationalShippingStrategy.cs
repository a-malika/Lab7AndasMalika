using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class InternationalShippingStrategy : IShippingStrategy
    {
        public double CalculateShipping(double distance, double weight)
        {
            return weight * 2.5 + distance * 2.1;
        }
    }
}
