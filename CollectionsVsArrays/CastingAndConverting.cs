using System;

namespace CollectionsVsArrays
{
    public class CastingAndConverting
    {
        public static void Run()
        {
            int num = 173981372;
            long bugNum = num; // no problem, moving from smaller to bigger.

            int i = 5;
            double d = 10.5;

            i = (int)d; //Problem here, no way to implicidly cast this to an int
            Console.WriteLine($"Double variable d converted to int is: {i}");


            int x = 7;
            double y = 12.6;

            x = (int)y;
            Console.WriteLine($"Double cast to int is {x}"); //12, drops the decimal

            int xx = 7;
            double yy = 12.6;

            xx = Convert.ToInt32(yy);
            Console.WriteLine($"Double converted to int is {xx}"); //13, rounds up.
        }
    }
}