using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; }
        public string Face { get; set; }

    }
}
