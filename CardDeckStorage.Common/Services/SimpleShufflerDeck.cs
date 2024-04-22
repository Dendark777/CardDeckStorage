using CardDeckStorage.Common.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckStorage.Common.Services
{
    public class SimpleShufflerDeck : DeckAction
    {
        private readonly Random random;

        public SimpleShufflerDeck(DeckAction? deckAction = null) : base(deckAction)
        {
            random = new Random();
        }

        public override void ActionOfCards(List<CardDto> cards)
        {
            base.ActionOfCards(cards);
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                (cards[n], cards[k]) = (cards[k], cards[n]);
            }
        }
    }
}
