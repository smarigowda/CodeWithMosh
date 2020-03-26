using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace ConditionalsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var isGoldCustomer = true;

            var price = isGoldCustomer ? 19.99f : 29.99;

            Console.WriteLine($"Price = {price}");
        }
    }
}