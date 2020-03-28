using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;
using System.Collections.Generic;

namespace Class_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            //customer.Id = 1;
            //customer.Name = "Santosh Marigowda";
        }
    }
}