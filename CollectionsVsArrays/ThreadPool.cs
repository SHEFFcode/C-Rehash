using System;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsVsArrays
{
    public class ThreadPool
    {
        //Starting a new thread requires some resources
        //It maintains a pool of pre-created recyclable pool
        //You cannot set the name of pooled thread, difficult to debug
        //Pooled threads are always background threads.
        //Blocking pooled threads can degrade performance
        //Task.Run starts a task that is executed on ta thread on a thread pool




        public void Run()
        {
            //Create foreground thread
            Thread t = new Thread(Count);
            t.Start();

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("T");
                }
            });
    }

        public void Count()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("FG");
            }
        }
    }
}