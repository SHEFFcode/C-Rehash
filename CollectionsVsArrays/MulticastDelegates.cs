using System;

namespace CollectionsVsArrays
{
    public class MulticastDelegates
    {
        delegate void del(int x, int y);

        public void Run()
        {
            //Target methods of a multicast deletage are always called in the order they were added to the delegate.

            MCD mcd = new MCD();

            mcd.AddNumbers(3, 3);
            mcd.MultiplyNumbers(3, 3);
            mcd.SubtractNumbers(3, 3);

            del d;

            d = mcd.AddNumbers;

            Console.WriteLine("Calling a delegate with one target...");
            d(3, 3);

            d += mcd.MultiplyNumbers;
            Console.WriteLine("Invoke delegate with two targets ...");
            d(3, 3);

            d += mcd.SubtractNumbers;
            Console.WriteLine("Inoke delegate with three targets ...");
            d(3, 3);

            d -= mcd.MultiplyNumbers;
            Console.WriteLine("Invoke delegate without multiply numbers...");
            d(3, 3);

        }
    }

    public class MCD
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"Add numbers: a + b = {a + b}");
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine($"Multiply numbers a * b = {a * b}");
        }

        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine($"Subtract numbers a - b = {a - b}");
        }
    }
}