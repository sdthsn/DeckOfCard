using ModellingDeckOfCards.Logic;
using ModellingDeckOfCards.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingDeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = 5;
            int handSize = 5;
            Deck deck = new Deck();


            var hand = new Hand(deck, numberOfPlayers, handSize);
            // Randomly assigning the card to each player and get the info of each player
            var playersInfo = hand.Deal();
            //Printing the result
            playersInfo.ForEach(x => PrintHelper(x));

            Console.ReadKey();
        }

        //The emthod used to print player info after deal
        static void PrintHelper(Player player)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(player.Name);
            builder.Append(": ");
            player.Cards.ForEach(x => builder.Append(x.Rank.ToString().Substring(5) + "" + x.Suit + "-"));
            Console.WriteLine(builder.ToString().TrimEnd('-'));
            builder.Clear();
            
        }
    }
}
