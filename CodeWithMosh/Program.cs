using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter firsr number: ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            var second = Convert.ToInt32(Console.ReadLine());

            var maxnum = first > second ? first : second;

            Console.WriteLine($"Max Num = {maxnum}");

        }
    }
}