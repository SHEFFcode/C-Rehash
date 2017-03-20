using System;

namespace CollectionsVsArrays
{
    public class ExplicitInterfaceImplementation
    {
        public void Run()
        {
            Mark m = new Mark();
            m.DoThis(); // implements ifirst implementation
            ((ISecond) m).DoThis();//implements the other do this

            ISecond mm = new Mark();
            mm.DoThis(); // you can also explicidly call this.
        }
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class Mark : IFirst, ISecond
    {
        public void DoThis() // explicit interface implementation
        {
            Console.WriteLine("Implements ifirst");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implements isecond");
            return 0;
        }

        public void Test()
        {
            //Add some code
        }
    }
}