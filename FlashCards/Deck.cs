using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class Deck
    {
        Random rand = new Random();
        private List<FlashCard> cards;

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
