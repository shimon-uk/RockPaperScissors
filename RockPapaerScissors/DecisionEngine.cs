using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissors
{
    public class DecisionEngine : RockPaperScissors.IDecisionEngine
    {
        private bool? champion;
        private Rule winningrule;
        private PlayerType player1Type;
        private PlayerType player2Type;


        public DecisionEngine(bool? champion, Rule rule)
        {
            // TODO: Complete member initialization
            this.champion = champion;
            this.winningrule = rule;
        }

        public DecisionEngine()
        {
            // TODO: Complete member initialization
        }
        public DecisionEngine Decide(IPlayer player1, IPlayer player2)
        {

            player1Type = player1.Type;
            player2Type = player2.Type;

            var rule = FindWinningRule(player1, player2);

            if (rule != null)
                return new DecisionEngine(true, rule);


            rule = FindWinningRule(player2, player1);
            if (rule != null)
                return new DecisionEngine(false, rule);


            return new DecisionEngine(null, null);
        }

        private Rule FindWinningRule(IPlayer player1, IPlayer player2)
        {
            var ruleList = (IEnumerable<IRule>) Rules.RulesCollection;
            
            return (Rule)ruleList.FirstOrDefault(r => r.Winner == player1.Descision && r.Losser == player2.Descision);
        }

        public override string ToString()
        {
            var result = String.Empty;

            switch (champion)
            {
                case null:
                    result = "It's a tie";
                    break;
                case true:
                    result = string.Format("{0}, {1} Won!!", winningrule.ToString(), "Player 1");
                    break;
                case false:
                    result = string.Format("{0}, {1} Won!!", winningrule.ToString(), "Player 2");
                    break;
            }

            return result;
        }
    }
}
