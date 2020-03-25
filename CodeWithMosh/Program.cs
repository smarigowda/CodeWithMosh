using System;

namespace TypeConversion
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
                Console.WriteLine("Exception occurred...");
            }

        }
    }
}