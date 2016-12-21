using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.Receivers
{
    /// <summary>
    /// 电灯命令类
    /// </summary>
    public class Light
    {

        public Light()
        {

        }

        /// <summary>
        /// 打开电灯的方法
        /// </summary>
        public void on()
        {
            Console.WriteLine("已为你打开电灯！");
        }

        /// <summary>
        /// 关闭电灯的方法
        /// </summary>
        public void off()
        {
            Console.WriteLine("已为你关闭电灯！");
        }
    }
}
