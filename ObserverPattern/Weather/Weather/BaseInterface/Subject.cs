using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.BaseInterface
{
    /// <summary>
    /// 天气主题接口
    /// </summary>
    public interface Subject
    {
        /// <summary>
        /// 未实现的注册观察者的方法
        /// </summary>
        void registerObserver(Observer o);
        /// <summary>
        /// 未实现的删除观察者的方法
        /// </summary>
        void removeObserver(Observer o);
        /// <summary>
        /// 未实现的通知观察者的方法
        /// </summary>
        void notifyObserver();
    }
}
