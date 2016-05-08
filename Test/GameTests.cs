using System;
using NUnit.Framework;
using Moq;
using RockPaperScissors;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class GameTests
    {
        Game sut;

        [OneTimeSetUp]
        public void SetupFixture()
        {
            sut = new Game();
        }
        [Test]
        public void GameObjectisinstantiatedCorrectly()
        {

            Assert.IsInstanceOf<Game>(sut);
        }

        [Test]
        public void SelectGameType_ComputerVsComputer()
        {
            sut.GameType=GameType.ComputerVsComputer;

            Assert.AreEqual(sut.GameType, GameType.ComputerVsComputer);
        }

        [Test]
        public void SelectGameType_PlayerVsComputer()
        {
            sut.GameType = GameType.PlayerVsComputer;

            Assert.AreEqual(sut.GameType, GameType.PlayerVsComputer);
        }
        [Test]
        public void SelectGameSeries_Single()
        {
            sut.GameSeries = GameSeries.Single;

            Assert.AreEqual(sut.GameSeries, GameSeries.Single);
        }
        [Test]
        public void SelectGameSeries_Multiple()
        {
            sut.GameSeries = GameSeries.Multiple;

            Assert.AreEqual(sut.GameSeries, GameSeries.Multiple);
        }
        [Test]
        public void ConfigurePlayers()
        {
            var mockPlayer1 = new Mock<Player>();
            var mockPlayer2 = new Mock<Player>();
            sut.GameSeries = GameSeries.Single;
            sut.GameType = GameType.ComputerVsComputer;

            var result =sut.ConfigurePlayers(mockPlayer1.Object, mockPlayer2.Object);

            Assert.AreEqual(result.Count, 2);
        }
        [Test]
        public void ConfigureComputerVsComputerPlayers1()
        {
            var mockPlayer1 = new Mock<Player>();
            var mockPlayer2 = new Mock<Player>();
            sut.GameSeries = GameSeries.Single;
            sut.GameType = GameType.ComputerVsComputer;

            var result = sut.ConfigurePlayers(mockPlayer1.Object, mockPlayer2.Object);

            Assert.AreEqual(result[0].Type, PlayerType.Computer);
        }
        [Test]
        public void ConfigureHumanVsComputerPlayers1()
        {
            var mockPlayer1 = new Mock<Player>();
            var mockPlayer2 = new Mock<Player>();
            mockPlayer1.SetupGet(p => p.Type).Returns(PlayerType.Human);
            sut.GameSeries = GameSeries.Single;
            sut.GameType = GameType.PlayerVsComputer;


            var result = sut.ConfigurePlayers(mockPlayer1.Object, mockPlayer2.Object);

            Assert.AreEqual(result[0].Type, PlayerType.Human);
        }
        [Test]
        public void ConfigureComputerVsComputerPlayers2()
        {
            var mockPlayer1 = new Mock<Player>();
            var mockPlayer2 = new Mock<Player>();
            sut.GameSeries = GameSeries.Single;
            sut.GameType = GameType.ComputerVsComputer;

            var result = sut.ConfigurePlayers(mockPlayer1.Object, mockPlayer2.Object);

            Assert.AreEqual(result[1].Type, PlayerType.Computer);
        }
        [Test]
        public void ConfigureHumanVsComputerPlayers2()
        {
            var mockPlayer1 = new Mock<Player>();
            var mockPlayer2 = new Mock<Player>();
            mockPlayer1.SetupGet(p => p.Type).Returns(PlayerType.Human);
            sut.GameSeries = GameSeries.Single;
            sut.GameType = GameType.PlayerVsComputer;


            var result = sut.ConfigurePlayers(mockPlayer1.Object, mockPlayer2.Object);

            Assert.AreNotEqual(result[1].Type, PlayerType.Human);
        }


        [OneTimeTearDown]
        public void TearDownfixture()
        {
            sut = null;
        }
    }
}
