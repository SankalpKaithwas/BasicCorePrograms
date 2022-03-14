using System;

namespace Basic_Core_Programs
{
    internal class VowelConsonant
    {
        public void isVowel()
        {
            Console.WriteLine("Enter a character");
            char chars = Convert.ToChar(Console.ReadLine());
            char character = char.ToLower(chars);            

            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                Console.WriteLine($"{chars} is Vowel");
            }
            else
            {
                Console.WriteLine($"{chars} is consonant");
            }
        }
    }
}