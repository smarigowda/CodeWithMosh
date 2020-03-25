using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace NonPrimitives
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Santosh";
            var lastName = "Marigowda";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            Console.WriteLine(fullName);

            var names = new string[3] { "Santosh", "Roopa", "Sukruthi" };
            Console.WriteLine(string.Join(',', names));

            Console.WriteLine(@"Hi John
Please have a look into
c:\home\santosh\");
        }
    }
}