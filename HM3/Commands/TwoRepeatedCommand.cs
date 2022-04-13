using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Commands
{
    public class TwoRepeatedCommand : IRunCommand
    {
        IRunCommand failCommand;
        public TwoRepeatedCommand(IRunCommand command)
        {
            failCommand = command;
        }

        public void Execute()
        {
            failCommand.Execute();
        }
    }
}
