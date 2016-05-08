using System;
namespace RockPaperScissors
{
   public interface IRule
    {
        GameOptions Losser { get; set; }
        string ToString();
        GameOptions Winner { get; set; }

    }
}
