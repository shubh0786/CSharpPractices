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
            Console.WriteLine("{0:d}",dt);// For short Date only  eg: (2/01/2022)
            Console.WriteLine("{0:D}", dt);// For Full Date only eg: (Sunday, 2 January 2022)
            Console.WriteLine("{0:f}", dt);// For Short time but date will be default full eg: (Sunday, 2 January 2022 2:18 pm)
            Console.WriteLine("{0:F}", dt);//For Full time with seconds but date will be default full eg: (Sunday, 2 January 2022 2:19:35 pm)
            Console.WriteLine("{0:g}", dt);// For short date and time eg: (2/01/2022 2:20 pm)
            Console.WriteLine("{0:G}", dt);// For short date and fulltime with seconds eg: (2/01/2022 2:20:57 pm)
            Console.WriteLine("{0:m}", dt);
            Console.WriteLine("{0:t}", dt);
            Console.WriteLine("{0:T}", dt);
            Console.WriteLine("{0:y}", dt);
            Console.WriteLine("{0:yy}", dt);
            Console.WriteLine("{0:yyyy}", dt);
            Console.WriteLine("{0:ddd}", dt);
            Console.WriteLine("{0:dddd}", dt);
            Console.WriteLine("{0:HH}", dt);
            Console.WriteLine("{0:MM}", dt);
            Console.WriteLine("{0:MMM}", dt);
            Console.WriteLine("{0:MMMM}", dt);
            Console.WriteLine("{0:ss}", dt);

            Console.WriteLine("{0:dd-MMM-yyyy: hhtt}", dt); // You can customize your Date format

            Console.ReadLine();
        }
    }
}
