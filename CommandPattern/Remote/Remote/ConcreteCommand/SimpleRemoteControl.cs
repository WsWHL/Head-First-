using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote.ConcreteCommand
{
    public class SimpleRemoteControl
    {
        Command slot;

        public void setCommand(Command command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.execute();
        }

        public void buttonUndo()
        {
            slot.undo();
        }
    }
}
