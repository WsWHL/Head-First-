using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.AbstractClass
{
    /// <summary>
    /// 抽象的比萨类
    /// </summary>
    public abstract class PizzaC
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string name;
        /// <summary>
        /// 面团
        /// </summary>
        public string dough;
        /// <summary>
        /// 酱料
        /// </summary>
        public string sauce;
        public ArrayList toppings = new ArrayList();

        /// <summary>
        /// 打印输出比萨信息的虚方法
        /// </summary>
        public virtual void prepare()
        {
            Console.WriteLine("Name：" + name);
            Console.WriteLine("Dough：" + dough);
            Console.WriteLine("Sauce：" + sauce);
            Console.WriteLine("Adding toppings...");
            foreach (var item in toppings)
            {
                Console.WriteLine("\t\t" + item);
            }
        }

        /// <summary>
        /// 烘烤的虚方法
        /// </summary>
        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 30");
        }

        /// <summary>
        /// 切块的虚方法
        /// </summary>
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        /// <summary>
        /// 包装的虚方法
        /// </summary>
        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        /// <summary>
        /// 获取这个比萨名字的方法
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
    }
}
