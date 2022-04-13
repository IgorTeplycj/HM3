using HM3.Handlers;
using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Works
{
    public class Run
    {
        ExceptionHandler exceptionHandler = new ExceptionHandler();
        Queue queue = new Queue();
        public void Start()
        {
            while (!queue.IsFree())
            {
                IRunCommand command = queue.Get();

                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    exceptionHandler.Handle(command, ex, AddCommand);
                }
            }
        }

        public void AddCommand(IRunCommand runCommand)
        {
            queue.Add(runCommand);
        }
    }
}
