using Remote.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.Invokers
{
    /// <summary>
    /// 打开大门
    /// </summary>
    public class GeteOnCommand : Command
    {
        /// <summary>
        /// 声明控制大门的命令
        /// </summary>
        private Gete gete;

        public GeteOnCommand(Gete gete)
        {
            this.gete = gete;
        }

        public void execute()
        {
            gete.on();
        }

        public void undo()
        {
            gete.off();
        }
    }
}
