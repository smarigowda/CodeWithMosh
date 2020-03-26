using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Spring;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's Spring");
                    break;
                default:
                    Console.WriteLine("Unknown Season...!");
                    break;
            }
        }
    }
}