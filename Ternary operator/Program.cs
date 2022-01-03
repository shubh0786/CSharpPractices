using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter your age: ");
            int a = int.Parse(Console.ReadLine()); 


            string b = (a <= 18) ? "You are not able to cast vote" : "You are able to cast vote";
            Console.WriteLine(b);
            Console.ReadLine();

            //Ternary Operator is a alternative of if-else it is commonly used when thier is no need to write multiple lines to make a decision
        }
    }
}
