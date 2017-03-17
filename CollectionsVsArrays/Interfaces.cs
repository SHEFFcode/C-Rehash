namespace CollectionsVsArrays
{
    public class Interfaces
    {

        public static void Run()
        {
            Machine1 m1 = new Machine1();
            Machine2 m2 = new Machine2();
            Machine3 m3 = new Machine3();

            m1.Start();
            m1.Stop();
            m2.Start();
            m3.Start();
        }

    }

    public class Machine1 : IControls
    {
        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }

    public class Machine2 : IControls
    {
        public void Start()
        {
            //Add Code
        }

        public void Stop()
        {
            //Add code
        }
    }

    public class Machine3 : IControls
    {
        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }

    interface IControls
    {
        void Start();
        void Stop();
    }
}