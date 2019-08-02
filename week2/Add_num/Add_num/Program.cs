using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the numbers");
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            int.TryParse(n1, out num1);
            int.TryParse(n2, out num2);
            int res = num1 + num2;
            Console.WriteLine("The result of addition of {0} and {1} is {2}", num1, num2, res);
            Console.Read();
        }
    }
}
