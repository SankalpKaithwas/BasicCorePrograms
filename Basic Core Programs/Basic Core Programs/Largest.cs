using System;

namespace Basic_Core_Programs
{
    internal class Largest
    {
        public void LargestNumber()
        {

            int i = 0;
            int max = 0;
            while (i < 3)
            {
                Console.WriteLine("Enter a number");
                int number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                i++;
            }
            Console.WriteLine("Largets number is " + max);
        }
    }
}