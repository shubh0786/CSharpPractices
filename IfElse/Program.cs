using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your second number");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {

                Console.WriteLine("Both are equal");             
            }
            else
            {
                Console.WriteLine("They are not equal");
            }
             
            Console.ReadLine();
        }
    }
}
