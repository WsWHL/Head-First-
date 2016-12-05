using Coffee.AbstractClass;
using Coffee.Beverages;
using Coffee.CondimentDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();

            Console.WriteLine(beverage.getDescription() + "：" + beverage.cost());
            Beverage house = new HouseBlend();
            house = new Mocha(house);
            house = new Mocha(house);
            house = new Whip(house);
            house = new Soy(house);
            Console.WriteLine(house.getDescription() + "：" + house.cost());
            Console.ReadKey();
        }
    }
}
