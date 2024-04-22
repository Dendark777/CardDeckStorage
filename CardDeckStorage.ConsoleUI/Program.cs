using CardDeckStorage.Common.Services;
using CardDeckStorage.StorageMemory.Data;

ICardDeckStorage _cardDeckStorage = new CardDeckStorageMemory();

Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeckNames()));
_cardDeckStorage.CreateDeck("Новая");
Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeckNames()));

Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeck("Новая")));
Console.WriteLine();
_cardDeckStorage.Shuffle("Новая", new SimpleShufflerDeck());
Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeck("Новая")));

_cardDeckStorage.RemoveDeck("Новая");
Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeckNames()));

Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeck("Первая колода", new SimpleShufflerDeck())));
Console.WriteLine();
Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeck("Первая колода")));
Console.WriteLine();
Console.WriteLine(string.Join(", ", _cardDeckStorage.GetDeck("Первая колода", new SortDeck())));

Console.ReadLine();
