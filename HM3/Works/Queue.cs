using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Works
{
    public class Queue
    {
        List<IRunCommand> commandCollection = new List<IRunCommand>();
        public IRunCommand Get()
        {
            IRunCommand outputVal = commandCollection[0];
            commandCollection.RemoveAt(0);

            return outputVal;
        }

        public void Add(IRunCommand runCommand)
        {
            commandCollection.Add(runCommand);
        }

        public bool IsFree()
        {
            if (commandCollection.Count == 0)
                return true;
            else
                return false;
        }
    }
}
