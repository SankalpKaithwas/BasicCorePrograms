using System;

namespace Basic_Core_Programs
{
    internal class Swap
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter first number ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swaping first Number is {firstNumber} and second Number is {secondNumber}");
            int temp = firstNumber * secondNumber;
            firstNumber = temp / firstNumber;
            secondNumber = temp / secondNumber;
            Console.WriteLine($"After swapping first number is {firstNumber} and second number is {secondNumber}");
        }
    }
}