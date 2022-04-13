using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Commands
{
    public class RunCommand : IRunCommand
    {
        IRunObject run;
        public RunCommand(IRunObject _run)
        {
            run = _run;
        }

        public void Execute()
        {
            run.ToDo();
        }
    }
}
