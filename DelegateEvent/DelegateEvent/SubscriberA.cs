using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class SubscriberA
    {
        public void Iteratie(int param)
        {
            Console.WriteLine("Eveniment in Subscriber A, declansat de publisher");
        }
    }
    class SubscriberB
    {
        public void Iteratie(int param)
        {
            Console.WriteLine("Eveniment in Subscriber B, declansat de publisher");
        }
    }
}
