using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    [Serializable()]
    class Deck
    {
        Random rand = new Random();
        private List<FlashCard> cards;
        public string Name
        {
            get;
            set;
        }

        public FlashCard CardAt(int index)
        {
            return cards.ElementAt(index);
        }

        public void Add(FlashCard card)
        {
            cards.Add(card);
        }

        public FlashCard FirstCard()
        {
            return cards[0];
        }
        /// <summary>
        /// Moves the card at the front of the deck to the back of the deck.
        /// </summary>
        public void CycleCard()
        {
            FlashCard card = cards[0];
            cards.RemoveAt(0);
            cards.Add(card);
        }

        public Deck() { 
            cards = new List<FlashCard>();
        }

        public void Shuffle()
        {
            int n = cards.Count;
            for (int i = 0; i < n; i++)
            {
                int randNum = i + (int)(rand.NextDouble() * (n - 1));
                FlashCard temp = cards[randNum];
                cards[randNum] = cards[i];
                cards[i] = temp;
            }
        }
    }
}
