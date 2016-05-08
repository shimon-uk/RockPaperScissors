using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RockPaperScissors;
using System.Threading;

namespace UI.WIN
{
    public partial class Form1 : Form
    {

        Game game = new Game();
        Player player1 = new Player();
        Player player2 = new Player();
        int player1Total = 0;
        int player2Total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialiseControls();
        }

        private void InitialiseControls()
        {
            foreach (var item in Enum.GetValues(typeof(GameType)))
            {
                GameType.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(GameSeries)))
            {
                GameSeries.Items.Add(item);
            }
            foreach (var item in Enum.GetValues(typeof(GameOptions)))
            {
                GameOptions.Items.Add(item);
            }

            GameType.SelectedIndex = 0;
            GameSeries.SelectedIndex = 0;
            GameOptions.SelectedIndex = 0;

            Player1Scores.Text = string.Format("Player 1:   {0} wins", player1Total);
            Player2Scores.Text = string.Format("Player 2:   {0} wins", player2Total);

            GameBox.Visible = false;
            ScoresPanel.Visible = false;
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Play.Enabled = false;
            Results.Text = String.Empty;

            if (game.GameSeries == RockPaperScissors.GameSeries.Multiple)
            {
                var players = game.ConfigurePlayers(player1, player2);
                player1 = players[0];
                player2 = players[1];
            }


            if (game.GameType == RockPaperScissors.GameType.PlayerVsComputer)
                player1.Descision = (RockPaperScissors.GameOptions)Enum.Parse(typeof(RockPaperScissors.GameOptions), GameOptions.SelectedItem.ToString());

            var result = game.Decide(player1, player2);




            Thread.Sleep(500);
            Results.Text = result.ToString();


            if (result.ToString().Contains("Player 1"))
            {
                player1Total++;
                Player1Scores.Text = string.Format("Player 1:   {0} wins", player1Total);
            }
            if (result.ToString().Contains("Player 2"))
            {
                player2Total++;
                Player2Scores.Text = string.Format("Player 2:   {0} wins", player2Total);
            }

           

            if (game.GameSeries == RockPaperScissors.GameSeries.Single)
            {
                Play.Enabled = false;
                GameBox.Visible = false;
            }
            else
            {
                Play.Enabled = true;
            }

            
        }

        private void GenerateGame_Click(object sender, EventArgs e)
        {

            Results.Text = String.Empty;
            game.GameType = (RockPaperScissors.GameType)Enum.Parse(typeof(RockPaperScissors.GameType), GameType.SelectedItem.ToString());
            game.GameSeries = (RockPaperScissors.GameSeries)Enum.Parse(typeof(RockPaperScissors.GameSeries), GameSeries.SelectedItem.ToString());


            var players = game.ConfigurePlayers(player1, player2);
            player1 = players[0];
            player2 = players[1];

            if (game.GameType == RockPaperScissors.GameType.PlayerVsComputer)
            {
                GameOptionBox.Visible = true;
            }
            else
            {
                GameOptionBox.Visible = false;
            }

            if (game.GameSeries == RockPaperScissors.GameSeries.Multiple)
            {
                ScoresPanel.Visible = true;
                player1Total = 0;
                player2Total = 0;
                Player1Scores.Text = string.Format("Player 1:    {0} wins", player1Total);
                Player2Scores.Text = string.Format("Player 2:    {0} wins", player2Total);
            }
            else
            {
                ScoresPanel.Visible = false;
            }
            Play.Enabled = true;

            GameBox.Visible = true;
        }


    }
}
