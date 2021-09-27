using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp01
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, ans;
            char op;

            Console.Write("Enter Number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator: ");
            op = char.Parse(Console.ReadLine());

            Console.WriteLine();

            if (op == '+')
            {
                ans = num1 + num2;
                answer();
            } else if (op == '-')
            {
                ans = num1 - num2;
                answer();
            } else if (op == '*')
            {
                ans = num1 * num2;
                answer();
            } else if (op == '/')
            {
                ans = num1 / num2;
                answer();
            } else
            {
                Console.WriteLine("Invalid Operation.");
            }


            void answer()
            {
                Console.WriteLine("The Result: {0} {1} {2} = {3}", num1, op, num2, ans);
            }

            Console.ReadKey();

        }
    }
}
