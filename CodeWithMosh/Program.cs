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
            for(int i = 1; i <=100; i++ )
            {   
                if(i%3 == 0)
                {
                    total++;
                }
            }

            Console.WriteLine($"Divisible by 3 Count = {total}");
        }
    }
}