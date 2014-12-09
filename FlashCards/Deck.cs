using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    class Deck
    {
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
    }
}
