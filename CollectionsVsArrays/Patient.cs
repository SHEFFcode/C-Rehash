using System;

namespace CollectionsVsArrays
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public void Examine(string pName)
        {
            Console.WriteLine($"Examination of {pName} is completed.");
        }

        public void Billing(long SSN)
        {
            Console.WriteLine($"Billing to {SSN}");
        }
    }

    public class Child : Patient
    {
        public void Innoculate()
        {
            Console.WriteLine("Child has been innoculated");
        }
    }

    public class UnderFive : Child
    {
        public void Cry()
        {
            Console.WriteLine("Weaaa weaa!!");
        }
    }
}