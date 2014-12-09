using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCards
{
    struct FlashCard
    {
        private string front;
        private string back;

        public string Front
        {
            get
            {
                return front;
            }
        }

        public string Back
        {
            get
            {
                return back;
            }
        }

        public FlashCard(string front, string back)
        {
            this.front = front;
            this.back = back;
        }
    }
}
