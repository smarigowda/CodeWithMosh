using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number 0 - 12: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if(input >=0 && input <= 12) 
            {
                Console.WriteLine($"Your input is valid, well done!");
            } else
            {
                Console.WriteLine($"Your input is not valid !!!");
            }

        }
    }
}