using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                var str = "True";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("String could not be converted to boolean...");
            }

        }
    }
}
