using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.AbstractClass
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract new string getDescription();
    }
}
