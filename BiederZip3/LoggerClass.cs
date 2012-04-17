using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiederDB3
{
    static class LoggerClass
    {
        static System.IO.StreamWriter sw;
        public static void log(string s)
        {
            if (sw == null)
                sw = new System.IO.StreamWriter(Utils.AppPath + "biederdb.log.txt", false, Encoding.GetEncoding(1252));
            System.Diagnostics.Debug.WriteLine(s);
            sw.WriteLine(s);
            sw.Flush();
        }
         
    }
}
