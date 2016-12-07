using Coffee.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.CondimentDecorators
{
    /// <summary>
    /// 摩卡
    /// </summary>
    public class Mocha : Beverage
    {
        Beverage beverage;

        /// <summary>
        /// 接收并设置一个咖啡对象
        /// </summary>
        /// <param name="beverage">接收的咖啡对象</param>
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// 追加描述信息
        /// </summary>
        /// <returns></returns>
        public override string getDescription()
        {
            return beverage.getDescription() + "，Mocha";
        }

        public override Capacity getSize()
        {
            return beverage.getSize();
        }


        /// <summary>
        /// 添加调料的价格
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            double result = beverage.cost();
            switch (beverage.getSize())
            {
                case Capacity.Small:
                    result += 0.2;
                    break;
                case Capacity.Centre:
                    result += 0.5;
                    break;
                case Capacity.Large:
                    result += 0.8;
                    break;
            }

            return result;
        }
    }
}
