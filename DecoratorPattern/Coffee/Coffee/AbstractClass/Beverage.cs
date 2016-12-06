using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.AbstractClass
{
    public abstract class Beverage
    {
        public Capacity _size;
        //描述语句
        public string description = "Unknown Beverage";

        //获取描述语句
        public virtual string getDescription()
        {
            return description;
        }

        // 设置咖啡容量大小的方法
        public void setSize(Capacity c)
        {
            _size = c;
        }

        //获取咖啡容量大小的虚方法
        public virtual Capacity getSize()
        {
            return _size;
        }

        //返回价格
        public abstract double cost();
    }

    /// <summary>
    /// 咖啡容量大小的枚举值
    /// </summary>
    public enum Capacity
    {
        Small = 0,  //小杯
        Centre = 1, //中杯
        Large = 2   //大杯
    }
}
