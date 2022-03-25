using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CostumerManager costumer = new CostumerManager();
            costumer.Logger=new DatabasseLogger();
            costumer.Add();
            Console.ReadLine();
        }
        interface ILogger
        {
            void Log();
        }
        class CostumerManager
        {
         public ILogger Logger {get; set;}
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Costumer added");
            }
        }
        class DatabasseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged by database");
            }
        }
        class FileLogger: ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged by File");
            }
        }
        class SmsLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged by SMS");
            }
        }
    }
}
