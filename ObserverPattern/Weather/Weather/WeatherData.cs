using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.BaseInterface;

namespace Weather
{
    /// <summary>
    /// 具体的实现天气主题接口的类
    /// </summary>
    public class WeatherData : Subject
    {
        /// <summary>
        /// 保存观察者的数组
        /// </summary>
        private ArrayList observers;
        /// <summary>
        /// 温度
        /// </summary>
        private float temperature;
        /// <summary>
        /// 湿度
        /// </summary>
        private float humidity;
        /// <summary>
        /// 气压
        /// </summary>
        private float pressure;

        /// <summary>
        /// 默认构造函数实例化保存观察者的数组
        /// </summary>
        public WeatherData()
        {
            observers = new ArrayList();
        }

        /// <summary>
        /// 注册观察者的方法
        /// </summary>
        /// <param name="o">要注册的观察者对象</param>
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// 删除观察者的方法
        /// </summary>
        /// <param name="o">要删除的观察者对象</param>
        public void removeObserver(Observer o)
        {
            int index = observers.IndexOf(o);
            if (index >= 0)
            {
                observers.RemoveAt(index);
            }
        }

        /// <summary>
        /// 将数据通知所有观察者的方法
        /// </summary>
        public void notifyObserver()
        {
            foreach (Observer o in observers)
            {
                o.update(this.temperature, this.humidity, this.pressure);
            }
        }

        /// <summary>
        /// 数据改变时执行通知所有观察者的方法
        /// </summary>
        public void measurementsChanged()
        {
            notifyObserver();
        }

        /// <summary>
        /// 设置天气数据的方法
        /// </summary>
        /// <param name="temperature">温度</param>
        /// <param name="humidity">湿度</param>
        /// <param name="pressure">气压</param>
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}
