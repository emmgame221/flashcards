using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    /// <summary>
    /// A class representing a Deck of FlashCards. Provides methods for cycling 
    /// cards and retrieving the first card.
    /// </summary>
    [Serializable()]
    class Deck
    {
        Random rand = new Random();
        private List<FlashCard> cards;
        /// <summary>
        /// The Name of the deck, to be used for UI purposes mainly.
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Gets the card at the specified position.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public FlashCard CardAt(int index)
        {
            return cards.ElementAt(index);
        }
        /// <summary>
        /// Adds a new FlashCard to the end of the deck.
        /// </summary>
        /// <param name="card">The FlashCard to add to the deck</param>
        public void Add(FlashCard card)
        {
            cards.Add(card);
        }
        /// <summary>
        /// Gets the first card in the deck.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Creates an empty deck with no name.
        /// </summary>
        public Deck() { 
            cards = new List<FlashCard>();
        }
        /// <summary>
        /// Creates an empty deck with a specified name.
        /// </summary>
        /// <param name="name">The name of the new Deck</param>
        public Deck(String name)
        {
            cards = new List<FlashCard>();
            Name = name;
        }
        /// <summary>
        /// Shuffles the deck using Fisher-Yates algorithm.
        /// </summary>
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
