using System;

namespace CollectionsVsArrays
{
    public class Overloading
    {
        public void CheckBilling()
        {
            Console.WriteLine("Billing info is being checked");
        }

        public void CheckBilling(int a, int b) 
        {
            Console.WriteLine("Billing info has been checked using two integers");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Billing info has been checked using a string and an integer");
        }
    }
}