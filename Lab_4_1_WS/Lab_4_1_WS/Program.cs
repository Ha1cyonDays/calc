using System;

namespace Lab_4_1_WS
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
            }
        }
    }
}
