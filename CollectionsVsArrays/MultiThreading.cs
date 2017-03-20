using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace CollectionsVsArrays
{
    public class MultiThreading
    {
        //Thread operates independently of other execution paths.
        //Most programs run single threaded
        //Thread has isAlive prop that returns true while thread is running.
        //Running thread can be paused using Thread.Sleep();
        // You can wait for another thread to end by calling Join method
        //Can check if its blocked by checking its threadstate poperty
        //Priority determined how much time it gets compared to other threads
        //Mouse has a very high prioerty for example
        //There are foreground and background threads
        //Background threads terminate once no foreground threads are running
        //Background tasks can be set using IsBackground prop or create a task
        //Background is good for polling or logging


        public void Run()
        {

            Thread t = new Thread(WriteX);
            t.Start();


            for (int i = 0; i < 1000; i++)
            {
                Console.Write("0");
            }

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(".");
            }

        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }
    }
}