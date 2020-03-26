using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var buffer = new char[10];
            for (int i = 0; i < 10; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}