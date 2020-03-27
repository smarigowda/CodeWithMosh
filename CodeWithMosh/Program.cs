using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;
using System.Collections.Generic;

namespace DateTime_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2020, 1, 1);
            Console.WriteLine(date);

            var now = DateTime.Now;
            Console.WriteLine("now =" + now);
            var today = DateTime.Today;
            Console.WriteLine("Today = " + today);

            Console.WriteLine("Hour = " + now.Hour);
            Console.WriteLine("Minute = " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine("Tomorrow = " + tomorrow);
            Console.WriteLine("Yesterday = " + yesterday);

            Console.WriteLine(tomorrow.ToLongDateString());
            Console.WriteLine(tomorrow.ToShortDateString());

            Console.WriteLine(yesterday.ToLongTimeString());
            Console.WriteLine(yesterday.ToShortTimeString());

            Console.WriteLine(today.ToString("dd-MMMM-yyy"));
        }
    }
}