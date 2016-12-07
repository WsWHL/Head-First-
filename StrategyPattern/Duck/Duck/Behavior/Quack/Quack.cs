using Duck.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck.Behavior.Quack
{
    public class Quack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("我会呱呱叫！");
        }
    }
}
