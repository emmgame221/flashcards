using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    /// <summary>
    /// A structure representing a flash card.
    /// Has Front and Back properties which contain the data for the card.
    /// </summary>
    [Serializable()]
    class FlashCard
    {
        /// <summary>
        /// Represents the front side of the card.
        /// </summary>
        public string Front
        {
            get;
            set;
        }
        /// <summary>
        /// Represents the back side of the card.
        /// </summary>
        public string Back
        {
            get;
            set;
        }
        public FlashCard()
        {
            Front = "";
            Back = "";
        }
        /// <summary>
        /// Constructor which creates a new FlashCard with the specified properties.
        /// </summary>
        /// <param name="front">The front side of the new card</param>
        /// <param name="back">The back side of the new card</param>
        public FlashCard(string front, string back)
        {
            Front = front;
            Back = back;
        }
    }
}
