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
            beverage.setSize(Capacity.Small);   //小杯咖啡
            beverage = new Whip(beverage);

            Console.WriteLine(beverage.getDescription() + "：" + beverage.cost());
            Beverage house = new HouseBlend();
            house.setSize(Capacity.Large);     //中杯咖啡
            house = new Mocha(house);
            house = new Mocha(house);
            house = new Whip(house);
            house = new Soy(house);
            Console.WriteLine(house.getDescription() + "：" + house.cost());
            Console.ReadKey();
        }
    }
}
