using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsVsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array vs Collection
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


            #endregion


            #region Exceptions
            //            //playing around with exceptions
            //            int a = 4;
            //            int b = 0;
            //            try
            //            {
            //                Console.WriteLine($"a divided by b is {a/b}.");
            //            }
            //            catch (DivideByZeroException ex)
            //            {
            //                Console.WriteLine($"You cannot divide by 0. Exception is {ex}");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("This gets called regardless.");
            //            }


            #endregion

            #region String vs StringBuilder

            //            string myString = "This is an example of ";
            //            myString = myString + "concactination."; //original mystring is destroyed and a new one was created with concated info.
            //            Console.WriteLine(myString);
            //
            //            var newString = new StringBuilder("This is a collection of ");
            //            newString.Append("concactination"); //this is done without dropping and recreating the string newString object.
            //            Console.WriteLine(newString);
            //
            //            newString.AppendLine();
            //            newString.Append("Using stringbuilder");
            //            Console.WriteLine(newString);
            //
            //            newString.Replace("stringbuilder", "stringbuilder Class");
            //            Console.WriteLine(newString);

            #endregion
            //
            //            #region StringREader and StringWriter
            //
            //            StringReadWrite srw = new StringReadWrite();

            //            #endregion


            //            #region Using properties and fields
            //
            //            var person = new Person();
            //            person.Age = 91;
            //
            //            #endregion


            //            #region Constructors
            //
            //            var defaultConstructor = new DefConstructor();
            //            defaultConstructor.DoTHis();
            //
            //            var addConstructor = new AddConstructor();
            //
            //            #endregion

            //
            //            #region Static Methods
            //
            //            var pi = Math.Round(3.14, 1);
            //            Console.WriteLine(pi);
            //
            //            Car.Accelerate(); //Notice the class is not static, but it has a static method, and it can be called without instantiating the object.
            //            var car = new Car();
            //            car.SlowDown(); //Notice that Accelerate is not available to the instance of car.
            //
            //            #endregion
            //
            //            #region Structs
            //
            //            Mark m = new Mark(6, 7);
            //            m.DoThis();
            //
            //            Mark m2; // create a struct without using the new keyword
            //            m2._x = 6; // if we dont use new keywork we have to provide the instance variables for the struct.
            //            m2._y = 7;
            //            m2.DoThis();
            //
            //            #endregion

            #region Generics

            //            Generics.Run();

            #endregion

            #region TypeCasting

            //            CastingAndConverting.Run();

            #endregion

            #region BoxingAndUnboxing

            //            BoxingAndUnboxing.Run();

            #endregion

            #region Indexers

            Indexers car = new Indexers();

            car[1] = "Mercedes";
            car[2] = "Dodge";
            car[3] = "Chevrolet";
            car[4] = "Honda";

            Console.WriteLine($"Car one is {car[1]}");
            Console.WriteLine($"Car one is {car[2]}");
            Console.WriteLine($"Car one is {car[41]}");

            #endregion


        }
    }

    //    #region Using Properties and Fields
    //
    //    public class Person
    //    {
    //        private int _age;
    //
    //        public int Age
    //        {
    //            get { return _age; }
    //            set
    //            {
    //                if (value > 0 && value < 65)
    //                {
    //                    _age = value;
    //                }
    //                else
    //                {
    //                    throw new Exception("Age cannot be over 65.");
    //                }
    //            }
    //        }
    //
    //
    //        private string _name; //Created using proofull tab tab
    //
    //        public string Name
    //        {
    //            get { return _name; }
    //            set { _name = value; }
    //        }
    //
    //    }
    //
    //    #endregion

    //    #region Write Data Using StringWriter
    //
    //
    //    public class StringReadWrite
    //    {
    //        StringBuilder sb = new StringBuilder();
    //
    //        public StringReadWrite()
    //        {
    //            WriteData();
    //            ReadData();
    //        }
    //
    //        public void WriteData()
    //        {
    //            StringWriter sw = new StringWriter(sb);
    //
    //            Console.WriteLine("Please enter your first and last name...");
    //
    //            string name = Console.ReadLine();
    //            sw.WriteLine($"Name: {name}");
    //            sw.Flush();
    //            sw.Close();
    //        }
    //
    //        public void ReadData()
    //        {
    //            StringReader sr = new StringReader(sb.ToString());
    //            while (sr.Peek() > -1)
    //            {
    //                Console.WriteLine(sr.ReadLine());
    //            }
    //
    //            Console.WriteLine();
    //            Console.WriteLine("Thank you for using our program.");
    //
    //            sr.Close();
    //        }
    //    }
    //
    //    #endregion



    //    #region Constructors
    //
    //    public class DefConstructor
    //    {
    //        public void DoTHis()
    //        {
    //            Console.WriteLine("This has run.");
    //        }
    //    }
    //
    //    public class AddConstructor
    //    {
    //        public AddConstructor()
    //        {
    //            Console.WriteLine("The add constructor has been called.");
    //            DoThat();
    //        }
    //
    //        public void DoThat()
    //        {
    //            Console.WriteLine("Do that has executed.");
    //        }
    //    }
    //
    //    #endregion


    //    #region Static Methods
    //
    //    public class Car
    //    {
    //        public static void Accelerate()
    //        {
    //            Console.WriteLine("Car is accelerating.");
    //        }
    //
    //        public void SlowDown()
    //        {
    //            Console.WriteLine("Car is slowing down.");
    //        }
    //    }
    //
    //    #endregion

//    #region Structs
//
//    public struct Mark
//    {
//        public int _x;
//        public int _y;
//
//        public Mark(int x, int y) // have to have params for a constructor for a struct.
//        {
//            _x = x;
//            _y = y;
//        }
//
//        public void DoThis()
//        {
//            Console.WriteLine(_x + _y);
//        }
//    }
//
//    #endregion



}
