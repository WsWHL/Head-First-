using Coffee.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.CondimentDecorators
{
    public class Whip : Beverage
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "，Whip";
        }

        public override double cost()
        {
            return beverage.cost() + 1.2;
        }
    }
}
