using Duck.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    /// <summary>
    /// 抽象类，所有鸭子的基类
    /// </summary>
    public abstract class Duck
    {

        //为两个行为接口声明两个引用变量
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck()
        {
        }

        //委托给行为执行飞行动作
        public void performFly()
        {
            flyBehavior.fly();
        }

        //设置飞行动作
        public void setPerformFly(FlyBehavior fly)
        {
            flyBehavior = fly;
        }

        //委托给行为执行发出叫声的动作
        public void performQuack()
        {
            quackBehavior.quack();
        }

        //设置发出声音的动作
        public void setPerformQuack(QuackBehavior quack)
        {
            quackBehavior = quack;
        }
    }
}
