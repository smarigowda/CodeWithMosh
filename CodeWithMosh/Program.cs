using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of an image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of an image: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if(width > height)
            {
                Console.WriteLine("Image is Landscape");
            } else if( height > width)
            {
                Console.WriteLine("Image is Portrait");
            } else
            {
                Console.WriteLine("Image is Square");
            }

        }
    }
}