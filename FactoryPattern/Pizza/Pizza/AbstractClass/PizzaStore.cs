using Pizza.AppEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.AbstractClass
{
    /// <summary>
    /// 抽象的比萨店类
    /// </summary>
    public abstract class PizzaStore
    {
        /// <summary>
        /// 未实现的创建比萨的方法
        /// </summary>
        /// <param name="type">需要的比萨类型</param>
        /// <returns>返回制作好的比萨</returns>
        public abstract PizzaC createPizza(PizzaTypeEnum type);

        /// <summary>
        /// 创建比萨订单信息以及制作比萨的方法
        /// </summary>
        /// <param name="type">需要制作的比萨类型</param>
        /// <returns>返回制作好的比萨</returns>
        public PizzaC orderPizza(PizzaTypeEnum type)
        {
            PizzaC pizza;

            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
