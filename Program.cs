using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Please enter a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter another number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select the operation");
            Console.WriteLine(" a - add");
            Console.WriteLine(" s - Subtract");
            Console.WriteLine(" m - Multiply");
            Console.WriteLine("d - Divide");
            Console.WriteLine("Your Operation?");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "a":
                    Console.WriteLine($"Result :{num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Result :{num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Result :{num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Result :{num1} / {num2} = " + (num1 / num2));
                    break;
                default:
                    break;
            }
            bool IsEnd = false;

            while (IsEnd == false)
            { }

        }
    }

}

