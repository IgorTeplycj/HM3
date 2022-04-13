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
    /// <summary>
    /// Создает команду, записывающую в лог, и ставит команду в очередь
    /// </summary>
    public class HandlerWriteLog
    {
        IRunCommand writeCpmmand;
        public void Handle(IRunCommand command, Exception ex, Action<IRunCommand> method)
        {
            string s = $"{ex.GetType()} {command.GetType()}";
            IRunObject wr = new WriteLog(s);
            writeCpmmand = new RunCommand(wr);
            method.Invoke(writeCpmmand);
        }
    }
}
