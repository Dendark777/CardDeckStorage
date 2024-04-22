using CardDeckStorage.Common.Models.Dto;
using CardDeckStorage.Common.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CardDeckStorage.StorageMemory.Data
{
    public class CardDeckStorageMemory : ICardDeckStorage
    {
        private List<DeckDto> _decks;

        public CardDeckStorageMemory()
        {
            _decks =
            [
                new()
                {
                    Name = "Первая колода"
                },
                new()
                {
                    Name = "Вторая колода"
                },
                new()
                {
                    Name = "Третья колода"
                },
                new()
                {
                    Name = "Четвертая колода"
                },
            ];
        }

        public void CreateDeck(string name)
        {
            _decks.Add(new DeckDto
            {
                Name = name
            });
        }

        public void Shuffle(string name, DeckAction deckAction)
        {
            var existongDeck = TryGetDeck(name);
            deckAction.ActionOfCards(existongDeck.Cards);
        }

        public void RemoveDeck(string name)
        {
            var existongDeck = TryGetDeck(name);
            _decks.Remove(existongDeck);
        }

        public List<string> GetDeckNames()
        {
            return _decks.Select(d => d.Name).ToList();
        }

        public DeckDto GetDeck(string name, DeckAction? deckAction = null)
        {
            var existongDeck = TryGetDeck(name);
            if (deckAction == null)
            {
                return existongDeck;
            }
            deckAction.ActionOfCards(existongDeck.Cards);
            return existongDeck;
        }

        private DeckDto TryGetDeck(string name)
        {
            return _decks.FirstOrDefault(d => d.Name == name)
                ?? throw new ArgumentException($"Нет колоды под именем {name}");
        }
    }
}
