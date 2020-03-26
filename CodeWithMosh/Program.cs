using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}