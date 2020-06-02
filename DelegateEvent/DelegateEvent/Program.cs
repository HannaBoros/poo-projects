using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publish = new Publisher();
            SubscriberA sub1 = new SubscriberA();
            SubscriberB sub2 = new SubscriberB();
            //publish.eveniment += new Iteratie(sub1.Iteratie);
            publish.eveniment += new Iteratie(sub2.Iteratie);
            publish.DeclansareEveniment();
            
        }
    }
}
