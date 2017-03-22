using System;
using System.Threading.Tasks;

namespace CollectionsVsArrays
{
    public class AsyncAwait
    {
        //Async marks a method so that the compiler knows to look for an await keyword
        //Await tells the compiler that async method can't continue past that point until the awaited asynchronous process is complete
        //In the meantime, the program that called the async method continues to execute.
        //Async caller and await method runs at the same time.

        public void Run()
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
            }

        }

    }

    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            await Task.Run(() =>
            {
                CountToFifty();
            });

            Console.WriteLine("Async task has completed.");
        }

        public async Task<string> CountToFifty()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine($"BG Thread: {i}");
            }

            return "counter";
        }
    }
}