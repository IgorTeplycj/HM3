using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Tests.Mocks
{
    public class RunPbjectThrowNullReferenceException : IRunObject
    {
        public void ToDo()
        {
            throw new NullReferenceException();
        }
    }
}
