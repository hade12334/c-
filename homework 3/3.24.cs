using System;

namespace homework_3._24
{
    class Program
    {
        static void Main()
        {

            Console.Write("Enter first integer: ");
            int number1 = int.Parse(Console.ReadLine());

            int result = number1 % 2;
            if (result == 0)
            {
                Console.WriteLine($"{number1} is even");
            }
            else {
                Console.WriteLine($"{number1} is odd");
            }

        }
    }
}
