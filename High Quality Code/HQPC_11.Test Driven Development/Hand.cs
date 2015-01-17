using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            string[] handToString = new string[5];
            for (int i = 0; i < this.Cards.Count; i++)
            {
                handToString[i] = this.Cards[i].ToString();
            }

            return string.Join(", ", handToString);
        }
    }
}
