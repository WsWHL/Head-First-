using Coffee.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Beverages
{
    /// <summary>
    /// 综合咖啡
    /// </summary>
    public class HouseBlend : Beverage
    {

        /// <summary>
        /// 设置综合咖啡的描述
        /// </summary>
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        /// <summary>
        /// 返回综合咖啡的价格
        /// </summary>
        /// <returns></returns>
        public override double cost()
        {
            return 0.99;
        }
    }
}
