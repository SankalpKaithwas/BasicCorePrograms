using System;

namespace Basic_Core_Programs
{
    internal class PrimeFactor
    {

        public void PrimeFactors(int number)
        {

            Console.WriteLine($"Factors of {number} are: ");
            for (int i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (isPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                    else { Console.WriteLine("No factors must be prime number"); }
                }
            }


        }
        public bool isPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
