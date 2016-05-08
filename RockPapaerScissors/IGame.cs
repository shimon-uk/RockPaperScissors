using System;
using System.Collections.Generic;
namespace RockPaperScissors
{
    interface IGame
    {
        List<Player> ConfigurePlayers(IPlayer player1, IPlayer player2);
        GameSeries GameSeries { get; set; }
        GameType GameType { get; set; }
    }
}
