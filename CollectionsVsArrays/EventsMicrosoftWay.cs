using System;

namespace CollectionsVsArrays
{
    public class EventsMicrosoftWay
    {
        public void Run()
        {
            EventPublisher ep = new EventPublisher();
            EventSubscriber ev = new EventSubscriber();

            ep.evt += ev.HandleTheEvent;

            ep.CheckBalance(260);

        }
    }

    public class EvtPublisher
    {
        public EventHandler evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                evt(this, EventArgs.Empty);
            }
        }

    }

    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine($"Attention {sender} is advising that the balance is over 250.");
        }
    }

}