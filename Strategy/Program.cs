using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DeliveryContext delivery = null;
            Console.WriteLine("Choose type of delivery: (1 - standart, 2 - express, 3 - international, 4 - night)");
            int typeDelivery = Convert.ToInt32(Console.ReadLine());
            if (typeDelivery == 1)
            {
                delivery = new DeliveryContext(new StandardShippingStrategy());
            }
            else if (typeDelivery == 2)
            {
                delivery = new DeliveryContext(new ExpressShippingStrategy());
            }
            else if (typeDelivery == 3)
            {
                delivery = new DeliveryContext(new InternationalShippingStrategy());
            }
            else if (typeDelivery == 4)
            {
                delivery = new DeliveryContext(new NightShippingStrategy());
            }
            else
            {
                throw new Exception("Not supported type of delivery");
            }
            var cost = delivery.CalculateShipping(700, 500);
            Console.WriteLine("Cost of delivery: " + cost);
        }
    }
}
