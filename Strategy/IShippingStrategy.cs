using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public interface IShippingStrategy
    {
        double CalculateShipping(double distance, double weight);
    }
}
