using Duck.Behavior.Fly;
using Duck.Behavior.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            //动态改变绿头鸭的动作
            mallard.setPerformQuack(new Squeak());
            mallard.setPerformFly(new FlyNoWay());
            mallard.performQuack();
            mallard.performFly();

            Console.ReadKey();
        }
    }
}
