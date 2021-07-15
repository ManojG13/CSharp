using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    class ConsoleLogger : ILog
    {
        public void LogData(string data)
        {
            Console.WriteLine($"Logging data to console - {data}");
        }
    }
}
