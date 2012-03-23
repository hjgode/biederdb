using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiederDB3
{
    static class LoggerClass
    {
        public static void log(string s)
        {
            System.Diagnostics.Debug.WriteLine(s);
        }
    }
}
