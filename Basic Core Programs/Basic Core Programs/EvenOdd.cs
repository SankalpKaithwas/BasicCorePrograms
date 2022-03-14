using System;

namespace Basic_Core_Programs
{
    internal class EvenOdd
    {
        public void isEven()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }
        }

    }
}