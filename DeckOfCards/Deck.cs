// Written by Rogan Helm
// 10/17/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Deck
    {
        private List<Card> cards = new List<Card>();
        public List<Card> Cards { get { return this.cards; } set { this.cards = value; } }
        public Deck()
        {
            int index = 1;
            Card aCard;
            while (index < 14)
            {
                aCard = new Card(index, "Clubs");
                cards.Add(aCard);
                index = index + 1;
            }
            index = 1;
            while (index < 14)
            {
                aCard = new Card(index, "Diamonds");
                cards.Add(aCard);
                index = index + 1;
            }
            while (index < 14)
            {
                aCard = new Card(index, "Spades");
                cards.Add(aCard);
                index = index + 1;
            }
            while (index < 14)
            {
                aCard = new Card(index, "Hearts");
                cards.Add(aCard);
                index = index + 1;
            }
            index = 1;
        }
        public List<Card> Deal(int numberOfCards)
        {
            List<Card> aHand = new List<Card>();
            int index = 0;

            while (index < numberOfCards)
            {
                // deals the card at the top of the deck
                aHand.Add(cards[cards.Count - 1]);
                cards.RemoveAt(cards.Count - 1);
                index = index + 1;
            }
            return aHand;
        }
        public void Shuffle()
        {
            Random random = new Random();
            Card tempCard = new Card();
            int numberOfSwaps = 1000;
            int counter = 0;
            while(counter < numberOfSwaps)
            {
                int cardIndexA = random.Next(0, 52);
                int cardIndexB = random.Next(0, 52);
                tempCard = cards[cardIndexA];
                cards[cardIndexA] = cards[cardIndexB];
                cards[cardIndexB] = tempCard;
                counter++;
            }
        }
        public override string ToString()
        {
            string message = "";
            foreach(var c in this.Cards)
            {
                message = message + c.ToString() + "\n";
            }
            return message;
        }
    }
}
