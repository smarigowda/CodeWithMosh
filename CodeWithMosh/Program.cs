using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);

            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count = " + numbers.Count);

            for(int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }

            numbers.Clear();
            Console.WriteLine("Count = " + numbers.Count);
        }
    }
}