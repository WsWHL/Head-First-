using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.ConcreteCommand
{
    /// <summary>
    /// 多组开关控制
    /// </summary>
    public class RemoteControl
    {
        /// <summary>
        /// 声明打开的命令对象组
        /// </summary>
        private Command[] onCommand;
        /// <summary>
        /// 声明关闭的命令对象组
        /// </summary>
        private Command[] offCommand;
        /// <summary>
        /// 声明一个命令对象用来保存最后一个命令用于撤销操作
        /// </summary>
        private Command lastCommand;

        /// <summary>
        /// 带参构造函数默认实例化命令对象
        /// </summary>
        /// <param name="number">需要实例化的命令对象个数</param>
        public RemoteControl(int number = 1)
        {
            if (number > 0)
            {
                onCommand = new Command[number];
                offCommand = new Command[number];
            }
        }

        /// <summary>
        /// 设置对应编号按钮的操作对象
        /// </summary>
        /// <param name="slot">按钮编号</param>
        /// <param name="onCommand">打开对象</param>
        /// <param name="offCommand">关闭对象</param>
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            if (validitySlot(slot))
            {
                this.onCommand[slot - 1] = onCommand;
                this.offCommand[slot - 1] = offCommand;
            }
        }

        /// <summary>
        /// 执行打开的操作
        /// </summary>
        /// <param name="slot">按钮编号</param>
        public void onButtonWasPushed(int slot)
        {
            if (validitySlot(slot) && onCommand[slot - 1] != null)
            {
                onCommand[slot - 1].execute();
                lastCommand = onCommand[slot - 1];      //注意：必须放在上面操作的后面
            }
        }

        /// <summary>
        /// 执行关闭的操作
        /// </summary>
        /// <param name="slot">按钮编号</param>
        public void offButtonWasPushed(int slot)
        {
            if (validitySlot(slot) && offCommand[slot - 1] != null)
            {
                offCommand[slot - 1].execute();
                lastCommand = offCommand[slot - 1];     //注意：必须放在上面操作的后面
            }
        }

        /// <summary>
        /// 撤销最后的一个操作动作
        /// </summary>
        public void undoButton()
        {
            if (lastCommand != null)
            {
                lastCommand.undo();
            }
        }

        private bool validitySlot(int slot)
        {
            if (slot > 0 && slot <= onCommand.Length && slot <= offCommand.Length)
            {
                return true;
            }
            else
            {
                Console.WriteLine("抱歉，没有该选项的开关！");
                return false;
            }
        }

    }
}
