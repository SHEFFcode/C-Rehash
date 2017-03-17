using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsVsArrays
{
    public class Generics
    {
        public static void Run()
        {
            ArrayList list = new ArrayList();
            list.Add(3);
            list.Add(5);
            list.Add(12);
//            list.Add("Hello");


            Console.WriteLine("Non generic list results.");

            foreach (int x in list)
            {
                Console.WriteLine(x);
            }




            List<int> list2 = new List<int>();
            list2.Add(34);
            list2.Add(21);
            list2.Add(15);
//            list2.Add("Hello");

            Console.WriteLine("Generic list results");
            foreach (var i in list2)
            {
                Console.WriteLine(i);
            }


        }
    }
}