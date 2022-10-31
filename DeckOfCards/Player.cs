namespace DeckOfCards
{
    public class Player
    {
        private List<Card> hand = new List<Card>();

        public List<Card> Hand
        {
            get { return this.hand; }
            set { this.hand = value; }
        }
    }
}
