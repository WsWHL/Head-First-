using Pizza.AbstractClass;
using Pizza.AppEnum;
using Pizza.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            //订购一块纽约干酪比萨和一块芝加哥干酪比萨
            List<PizzaStore> stores = new List<PizzaStore>()
            {
                new NYPizzaStore(),
                new ChicagoPizzaStore()
            };

            //订购同种类型的比萨
            foreach (PizzaStore item in stores)
            {
                item.orderPizza(PizzaTypeEnum.Cheese);
            }

            Console.ReadKey();
        }
    }
}
