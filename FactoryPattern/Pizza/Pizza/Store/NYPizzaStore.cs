using Pizza.AbstractClass;
using Pizza.AppEnum;
using Pizza.PizzaType.Cheese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Store
{
    /// <summary>
    /// 纽约比萨店
    /// </summary>
    public class NYPizzaStore : PizzaStore
    {

        public override PizzaC createPizza(PizzaTypeEnum type)
        {
            PizzaC pizza = null;
            switch (type)
            {
                case PizzaTypeEnum.Cheese:
                    pizza = new NYStyleCheesePizza();
                    break;
                case PizzaTypeEnum.Clam:
                    break;
                case PizzaTypeEnum.Pepperoni:
                    break;
                case PizzaTypeEnum.Veggie:
                    break;
            }

            return pizza;
        }
    }
}
