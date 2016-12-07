using Duck.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.Behavior.Fly
{
    public class FlyWithWings : FlyBehavior
    {

        public void fly()
        {
            Console.WriteLine("哈哈哈，我会飞行！");
        }
    }
}
