using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logger log = new Logger(); Нет доступа к конструктору

            Logger log = Logger.GetInstance();
            log._name = "Vasya";

            log.SayHello();

            Logger log2 = Logger.GetInstance();
            log.SayHello();
            Console.ReadKey(true);
        }
    }
}
