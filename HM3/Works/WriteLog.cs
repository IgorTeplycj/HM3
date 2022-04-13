using HM3.Interfaces;
using HM3.Journals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Works
{
    public class WriteLog : IRunObject
    {
        string toLog = "";
        public WriteLog(string toLog)
        {
            this.toLog = toLog;
        }
        public void ToDo()
        {
            //Здесь пишем строку "toLog" в лог
            LogApp.Write(toLog);
        }
    }
}
