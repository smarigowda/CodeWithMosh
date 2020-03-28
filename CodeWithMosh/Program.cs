using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;
using System.Collections.Generic;

namespace Class_Demo
{
    class Person
    {
        public string Name;

        public void Introduce(string name)
        {
            Console.WriteLine($"Hello {name}, I am {Name}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Santosh";
            person.Introduce("Roopa");
        }
    }
}