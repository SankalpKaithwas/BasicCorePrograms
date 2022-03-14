using System;

namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1: Flipcoin");
            Console.WriteLine("Choose 2: Leap year");
            Console.WriteLine("Choose 3: Power of 2");
            Console.WriteLine("Choose 4: Harmonic number");
            Console.WriteLine("Choose 5: Prime factors");
            Console.WriteLine("Choose 6: Quotient and Remainder");
            Console.WriteLine("Choose 7: Swap two numbers");
            Console.WriteLine("Choose 8: Check number is even or odd");
            Console.WriteLine("Choose 9: Check Alphabet is vowel or consonant");
            Console.WriteLine("Choose 10: To find the largest number");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin percentage = new FlipCoin();
                    percentage.FlipCoinPercentage();
                    break;
                case 2:
                    LeapYear checkLeapYear = new LeapYear();
                    checkLeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.CheckPowerOfTwo();
                    break;
                case 4:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.PrintHarmonic();
                    break;
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.PrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder check = new QuotientAndRemainder();
                    check.QuotientsAndRemainders();
                    break;
                case 7:
                    Swap swap = new Swap();
                    swap.SwapNumber();
                    break;
                case 8:
                    EvenOdd evenOrOdd = new EvenOdd();
                    evenOrOdd.isEven();
                    break;
                case 9:
                    VowelConsonant vowelOrConsonant = new VowelConsonant();
                    vowelOrConsonant.isVowel();
                    break;
                case 10:
                    Largest largest = new Largest();
                    largest.LargestNumber();
                    break;
                default:
                    Console.WriteLine("Input valid option");
                    break;
            }
        }
    }
}
