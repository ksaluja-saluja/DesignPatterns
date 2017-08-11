using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    public class Subscriber
    {
        public string name { get; set; }
        public void ReceiveUpdate()
        {
            Console.WriteLine(this.name + " has received update...");
        }
    }
    public class Publisher
    {
        List<Subscriber> subscribers = null;

        public Publisher()
        {
            subscribers = new List<ConsoleApplication3.Subscriber>();
        }

        public void AddSubscriber(Subscriber sub)
        {
            subscribers.Add(sub);
        }

        public void RemoveSubscriber(Subscriber sub)
        {
            subscribers.Remove(sub);
        }

        public void Notify()
        {
            foreach(Subscriber sub in subscribers)
            {
                sub.ReceiveUpdate();
            }
        }
    }
}
