namespace DeckOfCards
{
    public class Card
    {
        // class variables
        private int cardValue = 0;
        private string suit = "n/a";

        // Gets and sets
        public int Value
        {
            get { return this.cardValue; }
            set { this.cardValue = value; }
        }

        public string Suit
        {
            get { return this.suit; }
            set { this.suit = value; }
        }

        // Constructor

        public Card():this(0, "n/a")
        {
            // empty constructor
        }
        public Card(int aCardValue, string aSuit)
        {
            this.cardValue = aCardValue;
            this.Suit = aSuit;
        }

        // methods
        public override string ToString()
        {
            string message = "";

            message = this.cardValue + " of " + this.Suit;
            return message;
        }
    }
}
