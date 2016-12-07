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
    /// 芝加哥比萨店
    /// </summary>
    public class ChicagoPizzaStore : PizzaStore
    {

        public override PizzaC createPizza(PizzaTypeEnum type)
        {
            PizzaC pizza = null;
            switch (type)
            {
                case PizzaTypeEnum.Cheese:
                    pizza = new ChicagoStyleCheesePizza();
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
