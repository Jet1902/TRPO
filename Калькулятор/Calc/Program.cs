using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 1)
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
				{
					if(b == 0)
						Console.WriteLine("Error: divide by zero");
					else
						res = a / b;
				}
                Console.WriteLine(res);
                Console.WriteLine("Press 1 to exit... ");
                option = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
