using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow__Ex3_Guess_A_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number 1 - 10, you have 4 chances");
            var random = new Random();
            int randomNum = random.Next(1, 4);
            Console.WriteLine($"Random number choosen = {randomNum}");
            bool found = false;
            int i = 1;
            while( i <= 4)
            {
                Console.WriteLine($"Attempt {i} :");
                var input = Console.ReadLine();
                var inputNumber = Convert.ToInt32(input);

                if(inputNumber == randomNum)
                {
                    found = true;
                    break;
                }
                i++;
            }

            if(found == true)
            {
                Console.WriteLine("Cogratulations ! You Win.");
            } else
            {
                Console.WriteLine("Sorry, you lost :-(");
            }

            Console.WriteLine($"Random number choosen = {randomNum}");

        }
    }
}