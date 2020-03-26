using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter a name (space to break): ");
                var name = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine($"You entered: {name}");
                    continue;
                }
                break;
            }
        }
    }
}