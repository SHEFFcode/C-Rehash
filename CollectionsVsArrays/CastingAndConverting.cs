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

        }
    }
}