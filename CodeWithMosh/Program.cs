using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = a;
            b++;
            Console.WriteLine($"a = {a}, b = {b}");

            var names1 = new string[3] { "Santosh", "Roopa", "Sukruthi" };
            var names2 = names1;

            names2[0] = "Santosh Marigowda";

            Console.WriteLine($"names1[0] = {names1[0]}, names2[0] = {names2[0]}");

        }
    }
}