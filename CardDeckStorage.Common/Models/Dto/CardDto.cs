using CardDeckStorage.Common.Enums;

namespace CardDeckStorage.Common.Models.Dto
{
    public class CardDto
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public CardDto(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
