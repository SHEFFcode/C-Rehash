using System;

namespace CollectionsVsArrays
{
    public class OverridingMethods
    {
        
    }

    public class OverridingPatient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patient has been examined");
        }
    }

    public class OverridingAdultPatient : OverridingPatient
    {
        public override void Examine()
        {
            Console.WriteLine("The adult has been examined");
        }
    }

}