using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 30 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number++;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 20;
        }
    }
}