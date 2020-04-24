namespace playing_cards
{
    internal class PlayingCards
    {
        private int rank;
        private int suit;

        //ranks
        public static int ACE = 1;
        public static int DEUCE = 2;
        public static int THREE = 3;
        public static int FOUR = 4;
        public static int FIVE = 5;
        public static int SIX = 6;
        public static int SEVEN = 7;
        public static int EIGHT = 8;
        public static int NINE = 9;
        public static int TEN = 10;
        public static int JACK = 11;
        public static int QUEEN = 12;
        public static int KING = 13;

        // suits
        public static int DIAMONDS = 1;
        public static int CLUBS = 2;
        public static int HEARTS = 3;
        public static int SPADES = 4;

        public static bool isValidR(int rank)
        {
            if ((rank >= ACE) && (rank <= KING))
            {

                return true;
            }
            return false;
        }
        public static bool isValidS(int suit)
        {
            if ((suit >= DIAMONDS) && (suit <= SPADES))
            {

                return true;
            }
            return false;
        }
        public PlayingCards(int suit, int rank)
        {
            bool isvalidR = isValidR(rank);
            bool isvalidS = isValidS(suit);
            if (!isvalidR)
                System.Console.WriteLine("Rank is not valid");
            else
                this.rank = rank;
            if (!isvalidS)
                System.Console.WriteLine("Suit is not valid");
            else
                this.suit = suit;


        }
        public int getSuit()
        {
            return suit;
        }
        public int getRank()
        {
            return rank;
        }
        public string rankString()
        {
            switch (rank)
            {
                case 1: return "Ace";
                case 2: return "Deuce";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return "error";

            }
        }
            public string suitString()
            {
                switch (suit)
                {
                    case 1: return "DIAMONDS";
                    case 2: return "CLUBS";
                    case 3: return "HEARTS";
                    case 4: return "SPADES";
                    default: return "ERROR";

                }
            }
        
    }
}