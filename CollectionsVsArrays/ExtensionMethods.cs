using System;

namespace CollectionsVsArrays
{
    public class ExtensionMethods
    {
        public static void Run()
        {
            string x = "Hello";
            string y = "hello";

            Console.WriteLine($"{x} is Capitalized? {x.isCap()}");
            Console.WriteLine($"{y} is Capitalized? {y.isCap()}");

        }
    }

    public static class StringCap
    {
        public static bool isCap(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return false;
            }
            return char.IsUpper(s[0]);
        }
    }
}