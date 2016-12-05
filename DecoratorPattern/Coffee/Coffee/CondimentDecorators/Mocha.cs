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

        /// <summary>
        /// 添加调料的价格
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return beverage.cost() + 0.2;
        }
    }
}
