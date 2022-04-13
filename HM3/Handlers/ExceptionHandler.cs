using HM3.Commands;
using HM3.Interfaces;
using HM3.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Handlers
{
    public class ExceptionHandler
    {
        Dictionary<string, Action<IRunCommand, Exception, Action<IRunCommand>>> exHndlrColl = 
            new Dictionary<string, Action<IRunCommand, Exception, Action<IRunCommand>>>();
        public ExceptionHandler()
        {
            HandlerWriteLog handlerWriteLog = new HandlerWriteLog();
            HeandlerRepeatedCommand heandlerRepeatedCommand = new HeandlerRepeatedCommand();
            HeandlerTwoRepeatedCommand heandlerTwoRepeatedCommand = new HeandlerTwoRepeatedCommand();

            exHndlrColl.Add(GetHash(new RunCommand(null), new NullReferenceException()), heandlerRepeatedCommand.Handle);
            exHndlrColl.Add(GetHash(new RunCommand(null), new DivideByZeroException()), heandlerRepeatedCommand.Handle);
            exHndlrColl.Add(GetHash(new RunCommand(null), new ArgumentOutOfRangeException()), heandlerRepeatedCommand.Handle);

            exHndlrColl.Add(GetHash(new RepeatedCommand(null), new ArgumentOutOfRangeException()), heandlerTwoRepeatedCommand.Handle);

            exHndlrColl.Add(GetHash(new RepeatedCommand(null), new DivideByZeroException()), handlerWriteLog.Handle);
            exHndlrColl.Add(GetHash(new RepeatedCommand(null), new NullReferenceException()), handlerWriteLog.Handle);
            exHndlrColl.Add(GetHash(new TwoRepeatedCommand(null), new ArgumentOutOfRangeException()), handlerWriteLog.Handle);
        }
        public void Handle(IRunCommand command, Exception ex, Action<IRunCommand> method)
        {
            string hash = GetHash(command, ex);

            exHndlrColl[hash].Invoke(command, ex, method);
        }

        public string GetHash(IRunCommand com, Exception ex)
        {
            string hashCommand = com.GetType().GetHashCode().ToString();
            string hashEx = ex.GetType().GetHashCode().ToString();

            return hashCommand + hashEx;
        }
    }
}
