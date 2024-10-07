using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public void SetTemperature(float temperature)
        {
            if (temperature >= -50 && temperature <= 50)
            {
                this.temperature = temperature;
                NotifyObserver();
            }
            else
            {
                Console.WriteLine("Cannot do action. Wrong temperature.");
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void UnegisterObserver(IObserver observer)
        {
            if (observers.Remove(observer))
            {
                Console.WriteLine("Observer unregistered");
            }
            else Console.WriteLine("Cannot do action. Observer is not registered.");
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this.temperature);
            }
        }
    }
}
