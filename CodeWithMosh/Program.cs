using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit in km /hr: ");
            var speedlimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of a Car: ");
            var carspeed = Convert.ToInt32(Console.ReadLine());

            if(carspeed <= speedlimit)
            {
                Console.WriteLine("Thanks ! Your car speed is below the speed limit.");
            }


            var demeritPoints = 0;

            if(carspeed > speedlimit)
            {
                demeritPoints = (carspeed - speedlimit) / 5;
                Console.WriteLine($"Your demerit points = {demeritPoints}");
            }

            if(demeritPoints > 12)
            {
                Console.WriteLine("You have crossed the max demerit points. Your license is cancelled !!!");
            }
        }
    }
}