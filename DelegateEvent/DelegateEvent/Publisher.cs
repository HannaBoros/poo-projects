using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate void Iteratie(int param);
    public class Publisher
    {
            
        public event Iteratie eveniment;

        public void DeclansareEveniment()
        {
            for (int i = 0; i < 7; i++)
            {
                if (this.eveniment != null)
                    this.eveniment(i);
                else
                {
                    Console.WriteLine("nu exista eveniment");
                }
            }
            
        }
    }
    

}
