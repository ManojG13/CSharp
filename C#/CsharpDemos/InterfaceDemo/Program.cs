using System;

namespace InterfaceDemo
{
   

   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Demo");
            // ILog log = new ILog();

            ILog log1 = new DBLogger(); 

            AppLogger logger = new AppLogger(log1);

            logger.AppLog("Welcome Interface!!!");
        }
    }
}
