using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsVsArrays
{
    public class IEnumerableExample
    {
        public void Run()
        {
            List<string> cars = new List<string>();
            cars.Add("Chevy");
            cars.Add("Honda");
            cars.Add("Lexus");

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            Console.WriteLine("\n"+ "Now our own collection..." + "\n");

            Car c = new Car();
            c[0] = "Chevrolet";
            c[1] = "Dodge";
            c[2] = "Mercedes";

            foreach (var kar in c)
            {
                Console.WriteLine(kar);
            }
        }
    }

    public class Car : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var s in car)
            {
                yield return s;
            }
        }
    }


}