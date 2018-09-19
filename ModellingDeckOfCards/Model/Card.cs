using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingDeckOfCards.Model
{
    public enum Suit
    {
        S = 0,
        D = 1,
        H= 2,
        C= 3
    }
    public enum Rank
    {
        Rank_2 = 2,
        Rank_3 = 3,
        Rank_4 = 4,
        Rank_5 = 5,
        Rank_6 = 6,
        Rank_7 = 7,
        Rank_8 = 8,
        Rank_9 = 9,
        Rank_10 = 10,
        Rank_J = 11,
        Rank_Q = 12,
        Rank_K = 13,
        Rank_A = 1
    }
    public class Card
    {
        public Suit Suit { get;private set; }
        public Rank Rank { get;private set; }
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}

