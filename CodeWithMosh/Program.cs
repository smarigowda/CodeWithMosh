using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace NonPrimitives
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                var a = 11;
                var b = 12;
                Console.WriteLine((float)a / (float)b);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception occurred...{ex}");
            }

            var person = new Person();
            person.FirstName = "Santosh";
            person.LastName = "Marigowea";
            person.Introuduce();

            var calc = new Calculator();
            Console.WriteLine(calc.Add(10, 12));
        }
    }
}