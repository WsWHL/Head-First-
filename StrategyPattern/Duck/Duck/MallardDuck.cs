using Duck.Behavior.Fly;
using Duck.Behavior.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    /// <summary>
    /// 绿头鸭
    /// </summary>
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            //会呱呱叫也会飞的鸭子
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }
    }
}
