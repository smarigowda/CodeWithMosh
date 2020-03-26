using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow__Ex3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var input = Console.ReadLine();
            var inputNum = Convert.ToInt32(input);
            int factorial = 1;
            int i = 1;
            while(i <= inputNum)
            {
                factorial = factorial * i;
                i++;
            }
            Console.WriteLine($"Factorial of {inputNum} is {factorial}");

        }
    }
}