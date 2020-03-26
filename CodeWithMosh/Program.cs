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
            for(int i = 0; i < 10; i++)
            {
                Console.Write((char)( 'a' + random.Next(0,26)));
            }

        }
    }
}