using System;
namespace CodeWithMosh
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person()
        {
        }
        public void Introuduce()
        {
            Console.WriteLine($"Hi, I am {FirstName} {LastName}...");
        }
    }
}
