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

            Logger log1 = Logger.GetInstance();
            log1._name = "Vasya";
            log1.SayHello();

            Logger log2 = Logger.GetInstance();
            log2.SayHello();

            /* Весь прикол в том, что мы назначили _name для log1, 
             * а _name оказывается потом и в log2, так как по сути 
             * в памяти это один и тот же объект.
             */
            Console.ReadKey(true);
        }
    }
}
