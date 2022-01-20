using System;

namespace Lab_4_1_WS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            // Ask the user to type the first number.
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            int num2 = 0;
            // Ask the user to type the second number.
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
