using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // These are the date time formatters

            DateTime dt = DateTime.Now;
            Console.WriteLine("{0:d}",dt);
            Console.WriteLine("{0:D}", dt);
            Console.WriteLine("{0:f}", dt);
            Console.WriteLine("{0:F}", dt);
            Console.WriteLine("{0:g}", dt);
            Console.WriteLine("{0:G}", dt);

            Console.ReadLine();
        }
    }
}
