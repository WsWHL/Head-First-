using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.AbstractClass
{
    public abstract class Beverage
    {
        //描述语句
        public string description = "Unknown Beverage";

        //获取描述语句
        public virtual string getDescription()
        {
            return description;
        }

        //返回价格
        public abstract double cost();
    }
}
