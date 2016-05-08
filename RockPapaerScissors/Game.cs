using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Configuration;

namespace RockPaperScissors
{
    public class Game : RockPaperScissors.DecisionEngine, RockPaperScissors.IGame
    {

        public GameType GameType { get; set; }

        public GameSeries GameSeries { get; set; }

        public List<Player> ConfigurePlayers(IPlayer player1, IPlayer player2)
        {

            switch (GameType)
            {
                case GameType.ComputerVsComputer:
                    player1 = setupPlayer(player1, PlayerType.Computer, RandomiseGameOption());
                    player2 = setupPlayer(player2, PlayerType.Computer, RandomiseGameOption());
                    break;
                case GameType.PlayerVsComputer:
                    player1 = setupPlayer(player1, PlayerType.Human, GameOptions.Rock);
                    player2 = setupPlayer(player2, PlayerType.Computer, RandomiseGameOption());
                    break;
            }

            var result = new List<Player>();
            result.Add((Player)player1);
            result.Add((Player)player2);

            return result;
        }

        private IPlayer setupPlayer(IPlayer player, PlayerType ptype, GameOptions option)
        {
            player.Type = ptype;
            player.Descision = option;

            return player;
        }

        private GameOptions RandomiseGameOption()
        {
            AddPause();

            Array values = Enum.GetValues(typeof(GameOptions));
            Random random = new Random();
            GameOptions randomGameoption = (GameOptions)values.GetValue(random.Next(0, values.Length));

            return randomGameoption;
        }

        private static void AddPause()
        {
            var myConfigKeyValue = ConfigurationManager.AppSettings["RandomiseGameOptionDelay"];
            int valPassed;

            if (int.TryParse(myConfigKeyValue, out valPassed))
                Thread.Sleep(int.Parse(myConfigKeyValue));
        }



    }
}
