﻿using System;

namespace Basic_Core_Programs
{
    internal class HarmonicNumber
    {
        public void PrintHarmonic(int term)
        {
            string result;
            for (int i = 1; i <= term; i++)
            {
                if (i < term)
                {
                    result = $"1/{i} +";
                    Console.Write(result + " ");
                }
                else
                {
                    Console.WriteLine($"1/{i}");
                }
            }
        }
    }
}