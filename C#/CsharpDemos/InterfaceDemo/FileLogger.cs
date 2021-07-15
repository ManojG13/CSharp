using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class FileLogger : ILog
    {
        public void LogData(string data)
        {
            Console.WriteLine($"Logging to file - {data}");
        }
       
    }
}
