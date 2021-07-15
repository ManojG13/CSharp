using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo
{
    public class AppLogger
    {
        ILog logger;
        public AppLogger(ILog log)
        {
            logger = log;
        }

        public void AppLog(string data)
        {
            logger.LogData(data);
        }
    }
}
