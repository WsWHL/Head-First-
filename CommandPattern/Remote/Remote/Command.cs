using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote
{
    /// <summary>
    /// 命令控制接口
    /// </summary>
    public interface Command
    {
        /// <summary>
        /// 未实现的执行命令的方法
        /// </summary>
        void execute();

        /// <summary>
        /// 未实现是撤销上次命令的方法
        /// </summary>
        void undo();
    }
}
