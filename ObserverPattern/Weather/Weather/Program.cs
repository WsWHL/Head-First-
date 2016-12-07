using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Billboard;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //采用观察者设计模式模拟气象站数据显示
            WeatherData weather = new WeatherData();

            CurrentCondtionsDisplay ccd = new CurrentCondtionsDisplay(weather);

            weather.setMeasurements(35, 13, 90.5f);
            Console.ReadKey();
        }
    }
}
