using System;

namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 for Flipcoin");
            Console.WriteLine("Choose 2 for Leap year");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    Console.WriteLine("Enter numbers of time coin needs to flip");
                    int input = int.Parse(Console.ReadLine());
                    percentage.FlipCoinPercentage(input);
                    break;
                case 2: LeapYear checkLeapYear = new LeapYear();
                     Console.WriteLine("Enter year to check if it is leap year or not");
                    int year = int.Parse(Console.ReadLine());                    
                    checkLeapYear.CheckLeapYear(year);
                    break;
                default:
                    Console.WriteLine("Input valid option");
                    break;
            }
        }
    }
}
