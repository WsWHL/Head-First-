using Coffee.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.CondimentDecorators
{
    public class Soy : Beverage
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + "，Soy";
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
                    result += 0.5;
                    break;
                case Capacity.Centre:
                    result += 0.7;
                    break;
                case Capacity.Large:
                    result += 0.9;
                    break;
            }

            return result;
        }
    }
}
