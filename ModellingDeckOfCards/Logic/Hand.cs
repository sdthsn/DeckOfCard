using ModellingDeckOfCards.Model;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ModellingDeckOfCards.Logic
{
    public class Hand
    {
        private readonly Deck _deck;
        private readonly int _playersNum;
        private readonly int _handSize;
        public Hand(Deck deck, int playersNum, int handSize)
        {
            _deck = deck;
            _playersNum = playersNum;
            _handSize = handSize;
        }

        public List<Player> Deal()
        {
            // Creating Player list
            var players = Players(_playersNum);
            // Shuffelling the deck
            _deck.ShuffleDeck();
            int cardNumber = 0;
            //Assigning random card to Players hands by dealing one card from the deck to each hand, passing around the players
            for (int i = 0; i < _handSize; i++)
            {
                players.ForEach(x => x.Cards.Add(_deck.DeckOfCard[++cardNumber]));
            }

            return players;
        }

        #region Helper Method  to create Player

        private List<Player> Players(int playersNum)
        {
            List<Player> players = new List<Player>();

            for (int i = 1; i <= playersNum; i++)
            {
                string name = string.Concat("Player #", i.ToString());
                players.Add(new Player(name));
            }

            return players;
        }
        #endregion

    }


}
