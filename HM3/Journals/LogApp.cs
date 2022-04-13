using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3.Journals
{
    public static class LogApp
    { 
        static List<string> message = new List<string>();

        public static void Write(string s)
        {
            message.Add(s);
        }

        public static List<string> GetMessages()
        {
            return message;
        }
    }
}
