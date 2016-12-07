using Pizza.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.PizzaType.Cheese
{
    /// <summary>
    /// 纽约风味的干酪比萨
    /// </summary>
    public class NYStyleCheesePizza : PizzaC
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and cheese pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiao Cheese");
        }
    }
}
