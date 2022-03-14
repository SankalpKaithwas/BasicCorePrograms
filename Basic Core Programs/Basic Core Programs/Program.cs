using System;

namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1 for Flipcoin");
            Console.WriteLine("Choose 2 for Leap year");
            Console.WriteLine("Choose 3 for Power of 2");
            Console.WriteLine("Choose 4 for Harmonic number");
            Console.WriteLine("Choose 5 for Prime factors");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    Console.WriteLine("Enter numbers of time coin needs to flip");
                    int input = int.Parse(Console.ReadLine());
                    percentage.FlipCoinPercentage(input);
                    break;
                case 2:
                    LeapYear checkLeapYear = new LeapYear();
                    Console.WriteLine("Enter year to check if it is leap year or not");
                    int year = int.Parse(Console.ReadLine());
                    checkLeapYear.CheckLeapYear(year);
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    Console.WriteLine("Enter power of 2 ");
                    int power = int.Parse(Console.ReadLine());
                    powerOfTwo.CheckPowerOfTwo(power);
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    Console.WriteLine("Enter the number of harmonic ");
                    int term = int.Parse(Console.ReadLine());
                    harmonic.PrintHarmonic(term);
                    break;
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    Console.WriteLine("Enter the number ");
                    int number = int.Parse(Console.ReadLine());
                    primeFactor.PrimeFactors(number);
                    break;
                default:
                    Console.WriteLine("Input valid option");
                    break;
            }
        }
    }
}
