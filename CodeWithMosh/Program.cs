using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Santosh Marigowda";

            for(var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach( var letter in name)
            {
                Console.WriteLine(letter);
            }

            var numbers = new int [] { 1, 2, 3, 4,};

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}