using System;
using System.ComponentModel;

namespace CollectionsVsArrays
{
    public class Delegates
    {
        delegate int del(int x, int y);

        public void Run()
        {
            Markus m = new Markus();

            del d = m.AddNumbers; //Delegate d now points to the function add numbers on the Markus object m.
            d(3, 2);

            d = m.MultiplyNumbers; // we change d to point to the multiply numbers function
            d(3, 2);
        }
    }


    public class Markus
    {
        public int AddNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
            return (a + b);
        }

        public int MultiplyNumbers(int a, int b)
        {
            Console.WriteLine(a * b);
            return (a * b);
        }
    }

}