using CardDeckStorage.Common.Enums;
using CardDeckStorage.Common.Services;
using System.Text;

namespace CardDeckStorage.Common.Models.Dto
{
    public class DeckDto
    {
        public string Name { get; set; }
        public List<CardDto> Cards { get; set; }

        public DeckDto() 
        {
            Cards = [];
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new CardDto(suit, rank));
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            foreach (var card in Cards)
            {
                sb.AppendLine(card.ToString());
            }
            return sb.ToString();
        }
    }
}
