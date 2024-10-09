using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class DeliveryContext
    {
        private IShippingStrategy shipping;
        public DeliveryContext(IShippingStrategy shipping)
        {
            this.shipping = shipping;
        }
        public void SetCalculationMethod(IShippingStrategy shipping)
        {
            this.shipping = shipping;
        }
        public double CalculateShipping(double distance, double weight)
        {
            if (distance < 0 || weight < 0)
            {
                throw new Exception("Wrong arguments.");
            }
            return shipping.CalculateShipping(distance, weight);
        }
    }
}
