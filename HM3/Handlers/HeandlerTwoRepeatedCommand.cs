using HM3.Commands;
using HM3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Handlers
{
    /// <summary>
    /// Создает команду повторитель команды и ставит в очередь на выполнение
    /// </summary>
    public class HeandlerTwoRepeatedCommand
    {
        public void Handle(IRunCommand command, Exception ex, Action<IRunCommand> method)
        {
            IRunCommand twoRepeatedCommand = new TwoRepeatedCommand(command);
            method.Invoke(twoRepeatedCommand);
        }
    }
}
