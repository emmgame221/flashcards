using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    [Serializable()]
    struct FlashCard
    {
        public string Front
        {
            get;
            set;
        }

        public string Back
        {
            get;
            set;
        }

        public FlashCard(string front, string back)
        {
            Front = front;
            Back = back;
        }

        public FlashCard()
        {

        }
    }
}
