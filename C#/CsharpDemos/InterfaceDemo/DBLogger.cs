using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class DBLogger : ILog
    {
        public void LogData(string data)
        {
            Console.WriteLine($"Logging to Database  -{data}");
        }
    }
}
