using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string a = "25";
            //string b = "25";


            //int c = int.Parse(a) + int.Parse(b);

            //Console.WriteLine(c);
            //Console.ReadLine();

            string d = "25.898";
            string e = "29.878";

            float f = float.Parse(d) + float.Parse(e);
            Console.WriteLine(f);
            Console.ReadLine();

            //Points to be noted there are two types of data conversions.
            // **Implicit and **Explicit.

            // ** Implicit Conversion: This is sytem applied convertion which took place
            // When thier is no loss of data.

            // ** Explicit: Whereas Explicit is implemented by a user
            // so he knows he will be the responsible of any data loss.

            // Parse conversion is only used when converting a string to any data type.


        }
    }
}
