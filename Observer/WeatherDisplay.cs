using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class WeatherDisplay : IObserver
    {
        private readonly int ID;
        public WeatherDisplay(int id)
        {
            ID = id;
        }
        public void Update(float temperature)
        {
            Console.WriteLine("Notification for {0}: Temperature change to {1}.", ID, temperature);
        }
    }
}
