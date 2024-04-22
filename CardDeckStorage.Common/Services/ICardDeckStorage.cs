using CardDeckStorage.Common.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeckStorage.Common.Services
{
    public interface ICardDeckStorage
    {
        void CreateDeck(string name);
        void Shuffle(string name, DeckAction deckAction);
        DeckDto GetDeck(string name, DeckAction? deckAction = null);
        List<string> GetDeckNames();
        void RemoveDeck(string name);
    }
}
