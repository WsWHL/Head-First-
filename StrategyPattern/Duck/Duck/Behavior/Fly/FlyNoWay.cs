using Duck.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.Behavior.Fly
{
    public class FlyNoWay : FlyBehavior
    {

        public void fly()
        {
            Console.WriteLine("呜呜呜，我不会飞行！");
        }
    }
}
