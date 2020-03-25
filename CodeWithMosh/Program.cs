using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            const float PI = 3.14f;
            // PI = 3.14
            int i = 100;
            byte b = (byte)i; // compatible
            string s = "Santosh";
            //int parsedToInt = int.Parse(s);
            //int i32 = Convert.ToInt32(s);
            
            try
            {
                var number = "1234";
                byte b2 = Convert.ToByte(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Number could not be converted to byte...");
            }

        }
    }
}
