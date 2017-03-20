using System;

namespace CollectionsVsArrays
{
    public class Events
    {
        public void Run()
        {
            //Events have the following characteristics:
            //The publisher determines when an event is raised
            //The subscribers determine what action is taken in response to the event.
            //An event can have multiple subscribers
            //A subscriber can handle multiple events from multiple publishers.

            //instanciate event publisher object
            EventPublisher ep = new EventPublisher();

            //Instanciate Event Subscriber Object
            EventSubscriber es = new EventSubscriber();

            //Pont the delegate to the subscriber method
            ep.evt += es.HandleTheEvent;

            //Call the check balance method, and it will invoke the ep.evt delegate if balance is over 250.
            ep.CheckBalance(251);
        }
    }

    public class EventPublisher
    {
        public delegate void del(string x); //public delegate that returns void and accepts a string
        public event del evt; // an event of type del and the event name is evt.  When we raise the event, it will call the delegate and all the methods that will call all the methods subscribed to it.

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                evt("attention the current balance exceeds 250"); // raise the event
            }
        }

    }

    public class EventSubscriber
    {
        public void HandleTheEvent(string x)
        {
            Console.WriteLine(x);
        }
    }


}