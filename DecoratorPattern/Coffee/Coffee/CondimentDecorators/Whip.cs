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

        public override Capacity getSize()
        {
            return beverage.getSize();
        }

        public override double cost()
        {
            double result = beverage.cost();
            switch (beverage.getSize())
            {
                case Capacity.Small:
                    result += 1.0;
                    break;
                case Capacity.Centre:
                    result += 1.2;
                    break;
                case Capacity.Large:
                    result += 1.5;
                    break;
            }

            return result;
        }
    }
}
