using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Operation:");
                string op = Console.ReadLine();
                Console.WriteLine("b:");
                double b = Convert.ToDouble(Console.ReadLine());
                double res = 0;
                if (op == "*")
                    res = a * b;
                else if (op == "+")
                    res = a + b;
                else if (op == "-")
                    res = a - b;
                else if (op == "/")
                    res = a / b;
                Console.WriteLine(res);
        }
    }
}
