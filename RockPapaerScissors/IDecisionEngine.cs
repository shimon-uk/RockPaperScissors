using System;
namespace RockPaperScissors
{
   public interface IDecisionEngine
    {
       DecisionEngine Decide(IPlayer player1, IPlayer player2);
       string ToString();
    }
}
