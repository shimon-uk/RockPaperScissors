using System;
namespace RockPaperScissors
{
  public  interface IPlayer
    {
        GameOptions Descision { get; set; }
        PlayerType Type { get; set; }
    }
}
