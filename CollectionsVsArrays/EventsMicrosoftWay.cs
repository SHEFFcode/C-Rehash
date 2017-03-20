using System;

namespace CollectionsVsArrays
{
    public class EventsMicrosoftWay
    {
        public void Run()
        {

            Console.WriteLine("This is running");

            EvtPublisher ep = new EvtPublisher();
            EvtSubscriber ev = new EvtSubscriber();

            ep.evt += ev.HandleTheEvent;

            ep.CheckBalance(260);

        }
    }

    public class EvtPublisher
    {
//        public EventHandler evt;
        public EventHandler<EventArgsClass> evt;
        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                EventArgsClass eac = new EventArgsClass($"Balance Exceeds {x}.");
                evt(this, eac);
            }
        }

    }

    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgsClass e)
        {
            Console.WriteLine($"Attention from {sender} alerts: {e.Message}");
        }
    }

    public class EventArgsClass : EventArgs
    {
        public EventArgsClass(string str)
        {
            msg = str;
        }

        private string msg;

        public string Message
        {
            get { return msg; }
        }
    }

}