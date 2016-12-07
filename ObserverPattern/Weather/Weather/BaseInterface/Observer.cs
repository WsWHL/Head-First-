using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.BaseInterface
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface Observer
    {
        /// <summary>
        /// 未实现的更新天气数据的方法
        /// </summary>
        /// <param name="temp">温度</param>
        /// <param name="humidity">湿度</param>
        /// <param name="pressure">气压</param>
        void update(float temp, float humidity, float pressure);
    }
}
