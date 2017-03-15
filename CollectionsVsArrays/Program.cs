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
//            //Create a collection
//            var dogs = new List<string>();
//            dogs.Add("Bulldog");
//            dogs.Add("Collie");
//            dogs.Add("Retriever");
//            //use foreach to move through these
//            foreach (var dog in dogs)
//            {
//                Console.WriteLine(dog + " ");
//            }
//
//            Console.WriteLine(dogs[0]);
//
//            //Create an array
//            string[] dogsArray = new string[] {"Bulldog", "Collie", "Retriever"};
//            foreach (var dog in dogsArray)
//            {
//                Console.WriteLine(dog);
//            }

            //playing around with exceptions
            int a = 4;
            int b = 0;
            try
            {
                Console.WriteLine($"a divided by b is {a/b}.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"You cannot divide by 0. Exception is {ex}");
            }
            finally
            {
                Console.WriteLine("This gets called regardless.");
            }

            
        }
    }
}
