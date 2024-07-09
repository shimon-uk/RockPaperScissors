using System;
using NUnit.Framework.Legacy;
using Moq;
using RockPaperScissors;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class DecisionEngineTests
    {
        RockPaperScissors.DecisionEngine sut;
        Mock<Player> mockPlayer1;
        Mock<Player> mockPlayer2;

        [OneTimeSetUp]
        public void SetupFixture()
        {
            sut = new DecisionEngine();
            mockPlayer1 = new Mock<Player>();
            mockPlayer2 = new Mock<Player>();
        }

        [Test]
        public void DescisonEngineObjectIsInstantiatedDescisonEngineObject()
        {
           ClassicAssert.IsInstanceOf<DecisionEngine>(sut);
        }

        [Test]
        public void DecideMethodReturnsResults()
        {

            var actual = sut.Decide(mockPlayer1.Object, mockPlayer2.Object);

            ClassicAssert.IsInstanceOf<DecisionEngine>(actual);
        }


        [Test]
        public void DecisiionEngineObjectReturnsCorrectFormattedString_Player2Won()
        {
            mockPlayer1.SetupProperty(p => p.Descision, GameOptions.Scissors);
            mockPlayer2.SetupProperty(p => p.Descision, GameOptions.Rock);
            var expected = string.Format("{0} beats {1}, {2}", GameOptions.Rock, GameOptions.Scissors, "Player 2 Won!!");

            var actual = sut.Decide(mockPlayer1.Object, mockPlayer2.Object);
            

            ClassicAssert.AreEqual(actual.ToString(), expected);
        }
        [Test]
        public void DecisiionEngineObjectReturnsCorrectFormattedString_Player1Won()
        {
            mockPlayer1.SetupGet(p => p.Descision).Returns(GameOptions.Paper);
            mockPlayer2.SetupGet(p => p.Descision).Returns(GameOptions.Rock);           
            var expected = string.Format("{0} beats {1}, {2}", GameOptions.Paper, GameOptions.Rock, "Player 1 Won!!");

            var actual = sut.Decide(mockPlayer1.Object, mockPlayer2.Object);


            ClassicAssert.AreEqual(actual.ToString(), expected);
        }

        [Test]
        public void DecisiionEngineObjectReturnsCorrectFormattedString_DrawResult()
        {
            mockPlayer1.SetupProperty(p => p.Descision, GameOptions.Scissors);
            mockPlayer2.SetupProperty(p => p.Descision, GameOptions.Scissors);
            var expected = string.Format("It's a tie");

            var actual = sut.Decide(mockPlayer1.Object, mockPlayer2.Object);


            ClassicAssert.AreEqual(actual.ToString(), expected);
        }

        [OneTimeTearDown]
        public void TearDownFixture()
        {
            sut = null;
            mockPlayer1 = null;
            mockPlayer2 = null;
        }
    }
}
