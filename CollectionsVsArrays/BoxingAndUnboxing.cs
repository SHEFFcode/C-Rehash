using System;

namespace CollectionsVsArrays
{
    public class BoxingAndUnboxing
    {
        public static void Run()
        {
            object o;
            int x = 25;
            o = x; // Boxing is taking place here, because we are taking an integer and moving it into an object.
            Console.WriteLine($"x is {x}");
            Console.WriteLine($"o is {o}");

            o = 23; //o is still an object, even though it points to an int
            x = (int)o; //Cannot implicidly convert an object to an int. Have to cast.
            Console.WriteLine($"x is {x}");
            Console.WriteLine($"o is {o}");

            //This is expensive and can really slow the code down.
        }
    }
}