using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playing_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayingCards card = new PlayingCards(3, 7);
            Console.Write("the suit is:");
            Console.WriteLine(card.suitString());
            Console.Write("the rank is:");
            Console.WriteLine(card.rankString());

        }
    }
}
