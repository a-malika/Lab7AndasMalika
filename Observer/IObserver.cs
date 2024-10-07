using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory7
{
    //WeatherStation station = new WeatherStation();
    //WeatherDisplay display1 = new WeatherDisplay(1);
    //WeatherDisplay display2 = new WeatherDisplay(2);
    //WeatherDisplayEmail display3 = new WeatherDisplayEmail(3);
    //WeatherDisplayEmail display4 = new WeatherDisplayEmail(4);
    //WeatherDisplaySound display5 = new WeatherDisplaySound(5);
    //WeatherDisplaySound display6 = new WeatherDisplaySound(6);
    //station.RegisterObserver(display1);
    //station.RegisterObserver(display2);
    //station.RegisterObserver(display3);
    //station.RegisterObserver(display4);
    //station.RegisterObserver(display5);
    //station.RegisterObserver(display6);
    //station.UnegisterObserver(display2);
    //station.UnegisterObserver(display6);
    //station.UnegisterObserver(display6);
    //while (true)
    //{
    //    Random rnd = new Random();
    //    station.SetTemperature((float)rnd.Next());
    //    Thread.Sleep(1000);
    //}
    public interface IObserver
    {
        void Update(float temperature);
    }
}
