using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.Receivers
{
    /// <summary>
    /// 大门打开与关闭命令
    /// </summary>
    public class Gete
    {

        public Gete()
        {
        }

        public void on()
        {
            Console.WriteLine("正在为你打开大门...");
        }


        public void off()
        {
            Console.WriteLine("正在为你关闭大门...");
        }
    }
}
