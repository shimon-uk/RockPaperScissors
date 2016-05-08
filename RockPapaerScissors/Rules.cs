using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    public class Rules
    {
        public static List<IRule> RulesCollection
        {
            get
            {
                return new List<IRule>()
                   {
                       new Rule(GameOptions.Rock, GameOptions.Scissors),
                       new Rule(GameOptions.Scissors, GameOptions.Paper),
                       new Rule(GameOptions.Paper, GameOptions.Rock)
                   };
            }
        }

    }
}
