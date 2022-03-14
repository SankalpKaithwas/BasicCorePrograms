using System;

namespace Basic_Core_Programs
{
    internal class PowerOfTwo
    {
        public void CheckPowerOfTwo()
        {
            Console.WriteLine("Enter power of 2 ");
            int power = int.Parse(Console.ReadLine());
            double result = 0;
            double condition = Math.Pow(2, power);
            for (int i = 1; result <= condition; i++)
            {
                result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}