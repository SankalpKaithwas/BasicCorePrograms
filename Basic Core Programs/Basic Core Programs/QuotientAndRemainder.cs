using System;

namespace Basic_Core_Programs
{
    internal class QuotientAndRemainder
    {
        public void QuotientsAndRemainders(int number)
        {
            int quotient;
            int rem;
            Console.WriteLine("Quotients are: ");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    quotient = number / i; Console.Write(quotient + " ");
                }


            }
            Console.WriteLine();
            Console.WriteLine("remainders are: ");
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    rem = number % i; Console.Write(rem + " ");
                }

            }
        }
    }
}