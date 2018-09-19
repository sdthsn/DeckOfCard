using ModellingDeckOfCards.Model;
using System;
using System.Threading.Tasks;

namespace ModellingDeckOfCards.Logic
{
    public class Deck
    {
        public Card[] DeckOfCard { get; private set; }
        private readonly Random _rnd;
        public Deck()
        {
            _rnd = new Random();
            DeckOfCard = CreateDeck();
        }

        private Card[] CreateDeck()
        {
            Card[] deck = new Card[52];

            for (int i = 0; i < 52; i++)
            {
                Suit suit = (Suit)(i % 4);
                Rank rank = (Rank)(i % 13 + 1);
                deck[i] = new Card(suit, rank);
            }
            return deck;
        }

        public Card[] ShuffleDeck()
        {
            var n = DeckOfCard.Length - 1;
            while (n > 0)
            {
                var i = _rnd.Next(0, n);
                var t = DeckOfCard[n];
                DeckOfCard[n] = DeckOfCard[i];
                DeckOfCard[i] = t;
                n--;
            }
            return DeckOfCard;
        }
    }
}
