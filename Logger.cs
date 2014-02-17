using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    public class Logger
    {
        private static Logger instance = null;
        public string _name;
        public static Logger GetInstance()
        {
            if (instance == null)
                instance = new Logger();
            return instance;
        }

        private Logger()
        {

        }

        public void SayHello()
        {
            Console.WriteLine("Hello, " + _name);
        }
    }
}
