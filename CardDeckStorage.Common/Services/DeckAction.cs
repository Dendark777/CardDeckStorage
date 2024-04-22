using CardDeckStorage.Common.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckStorage.Common.Services
{
    public abstract class DeckAction
    {
        private readonly DeckAction? _deckAction;

        protected DeckAction(DeckAction? deckAction = null)
        {
            _deckAction = deckAction;
        }

        public virtual void ActionOfCards(List<CardDto> cards)
        {
            _deckAction?.ActionOfCards(cards);
        }
    }
}
