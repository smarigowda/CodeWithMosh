using System;
using CodeWithMosh;
using CodeWithMosh.Math;
using CodeWithMosh.Enums;

namespace ControlFlow__String_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = "1,20,3,4,5".Split(',');
            var max = 0;
            foreach(var letter in output)
            {
                if(max < Convert.ToInt32(letter))
                {
                    max = Convert.ToInt32(letter);
                }
            }
            Console.WriteLine(max);
        }
    }
}