using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    public class Rule : RockPaperScissors.IRule
    {

        public Rule()
        {
            // TODO: Complete member initialization
        }

        public Rule(GameOptions winner, GameOptions losser)
        {
            // TODO: Complete member initialization
            Winner = winner;
            Losser = losser;
        }
        public GameOptions Winner { get; set; }

        public GameOptions Losser { get; set; }

        public override string ToString()
        {
            return string.Format("{0} beats {1}", Winner, Losser);
        }
    }
}
