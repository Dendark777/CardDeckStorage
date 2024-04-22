using CardDeckStorage.Common.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckStorage.Common.Services
{
    public class SortDeck : DeckAction
    {
        public SortDeck(DeckAction? deckAction = null) : base(deckAction)
        {
        }

        public override void ActionOfCards(List<CardDto> cards)
        {
            base.ActionOfCards(cards);
            cards.Sort((card1, card2) =>
            {
                int suitComparison = card1.Suit.CompareTo(card2.Suit);
                if (suitComparison == 0)
                {
                    return card1.Rank.CompareTo(card2.Rank);
                }
                return suitComparison;
            });
        }
    }
}
