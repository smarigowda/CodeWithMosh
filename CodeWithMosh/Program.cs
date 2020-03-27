using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[3] { 1, 2, 3 };
            var numbers = new [] { 1, 5, 3, 4, 2, 6, 9, 8, 7 };
            Console.WriteLine(numbers.Length);
            var index = Array.IndexOf(numbers, 7);
            Console.WriteLine(index);

            int[] another = new int[9];

            Array.Copy(numbers, another, 9);

            foreach(var num in another)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Array.Sort");
            Array.Sort(numbers);
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Array.Reverse");
            Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}