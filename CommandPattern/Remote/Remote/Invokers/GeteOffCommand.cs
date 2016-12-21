using Remote.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.Invokers
{
    /// <summary>
    /// 关闭大门
    /// </summary>
    public class GeteOffCommand : Command
    {
        //声明控制大门的命令
        private Gete gete;

        public GeteOffCommand(Gete gete)
        {
            this.gete = gete;
        }

        public void execute()
        {
            gete.off();
        }

        public void undo()
        {
            gete.on();
        }
    }
}
