using HM3.Commands;
using HM3.Interfaces;
using HM3.Works;
using System;

namespace HM3
{
    class Program
    {
        static void Main(string[] args)
        {
            IRunCommand repCommand = new RepeatedCommand(new RunCommand(null));
            Exception ex = new ArgumentNullException();
            string writeLogCommandHash = repCommand.GetHashCode().ToString();
            string exHash = ex.GetHashCode().ToString();
            string resultHash = writeLogCommandHash + exHash;


            (IRunCommand, Exception) vr = new(repCommand, ex);
            string hashS = vr.GetHashCode().ToString();
        }
    }


    public class Mock : IRunObject
    {
        public void ToDo()
        {

        }

    }
}
