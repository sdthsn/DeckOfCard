﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingDeckOfCards.Model
{
   
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public Player(string name)
        {
            Name = name;
            Cards = new List<Card>();

        }
    }
}
