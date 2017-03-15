using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsVsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a collection
            var dogs = new List<string>();
            dogs.Add("Bulldog");
            dogs.Add("Collie");
            dogs.Add("Retriever");
            //use foreach to move through these
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");
            }

            Console.WriteLine(dogs[0]);

            //Create an array

        }
    }
}
