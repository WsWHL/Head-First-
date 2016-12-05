using Coffee.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Beverages
{
    /// <summary>
    /// 浓缩咖啡
    /// </summary>
    public class Espresso : Beverage
    {
        /// <summary>
        /// 设置当前浓缩咖啡的描述
        /// </summary>
        public Espresso()
        {
            description = "Espresso";
        }

        /// <summary>
        /// 返回浓缩咖啡的价格
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return 1.99;
        }
    }
}
