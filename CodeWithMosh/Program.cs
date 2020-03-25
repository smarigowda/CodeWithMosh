using System;
using CodeWithMosh;
using CodeWithMosh.Math;

namespace NonPrimitives
{
    public enum ShippingMethod
    {
        Regular = 1,
        Regsitered = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine(method.ToString());
            Console.WriteLine((int)method);

            var methodId = 3;

            Console.WriteLine((ShippingMethod)methodId);

            string methodName = "Regular";

            var name = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(name);

        }
    }
}