using System;

namespace Basic_Core_Programs
{
    internal class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter year to check if it is leap year or not");
            int year = int.Parse(Console.ReadLine());
            int count = 0;
            int temp = 1;
            while (temp <= year)
            {
                temp *= 10;
                count++;
            }
            if (count == 4)
            {
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Enter a proper year");
            }
        }
    }
}