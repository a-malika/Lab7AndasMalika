using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class StandardShippingStrategy : IShippingStrategy
    {
        public double CalculateShipping(double distance, double weight)
        {
            return weight * 0.5 + distance * 0.1;
        }
    }
}
