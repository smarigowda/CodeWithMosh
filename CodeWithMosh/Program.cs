using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour >= 0 && hour <= 12)
            {
                Console.WriteLine("Good morning");
            }
            else if (hour > 12 && hour <= 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else if (hour >18 )
            {
                Console.WriteLine("Good evening");
            }
        }
    }
}