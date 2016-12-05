using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BaseInterface;

namespace Weather.Billboard
{
    /// <summary>
    /// 显示天气数据的布告板
    /// </summary>
    public class CurrentCondtionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;

        /// <summary>
        /// 一个带参的构造函数，默认实现对当前主题注册观察者
        /// </summary>
        /// <param name="weatherData">需要注册的主题</param>
        public CurrentCondtionsDisplay(Subject weatherData)
        {
            weatherData.registerObserver(this);
        }

        /// <summary>
        /// 更新天气数据并显示的方法
        /// </summary>
        /// <param name="temperature">温度</param>
        /// <param name="humidity">湿度</param>
        /// <param name="pressure">气压</param>
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            display();
        }

        /// <summary>
        /// 显示天气数据的方法
        /// </summary>
        public void display()
        {
            Console.WriteLine("Temperature:{0}\nHumidity:{1}\nPressure:{2}", this.temperature, this.humidity, this.pressure);
        }
    }
}
