using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow__Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            while(true)
            {
                Console.WriteLine("Enter a Number (ok to exit) :");
                var input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                total = total + Convert.ToInt32(input);
            }
            Console.WriteLine($"Total of all numbers = {total}");

        }
    }
}