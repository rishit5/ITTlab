using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op1, op2;
            Console.WriteLine("Enter any two numbers");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int.TryParse(n1, out op1);
            int.TryParse(n2, out op2);
            //int res = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", op1, op2, op1 + op2);
            Console.WriteLine("{0} - {1} = {2}", op1, op2, op1 - op2);
            Console.WriteLine("{0} * {1} = {2}", op1, op2, op1 * op2);
            Console.WriteLine("{0} / {1} = {2}", op1, op2, op1 / op2);
            Console.Read();
        }
    }
}
