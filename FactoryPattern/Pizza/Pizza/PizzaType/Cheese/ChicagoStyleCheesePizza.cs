using Pizza.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.PizzaType.Cheese
{
    /// <summary>
    /// 芝加哥风味的干酪比萨
    /// </summary>
    public class ChicagoStyleCheesePizza : PizzaC
    {

        public ChicagoStyleCheesePizza()
        {
            name = "Chicago  Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        /// <summary>
        /// 重写切块方法
        /// </summary>
        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
