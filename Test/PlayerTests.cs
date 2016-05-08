using System;
using NUnit.Framework;
using Moq;
using RockPaperScissors;


namespace Test
{
    [TestFixture]
    public class PlayerTests
    {

        Player sut;

        [OneTimeSetUp]
        public void SetupFixture()
        {
           sut = new Player();
        }
        [Test]
        public void PlayerInstantiatesPlayerObject()
        {
            
            Assert.IsInstanceOf<Player>(sut);
        }

        [Test]
        public void PlayerTypeReturnsComputer()
        {
            var expected = PlayerType.Computer;

            sut.Type = PlayerType.Computer;

            Assert.AreEqual(sut.Type, expected);
        }
        [Test]
        public void PlayerTypeReturnsHuman()
        {
            var expected = PlayerType.Human;

            sut.Type = PlayerType.Human;

            Assert.AreEqual(sut.Type, expected);
        }

        [Test]
        [TestCaseSource("GameOptionsData")]
        public void PlayerDescisionReturnsGameOption(GameOptions input)
        {
            var expected = input;

            sut.Descision = input;

            Assert.AreEqual(sut.Descision, expected);
        }

        static object[] GameOptionsData =
        {
           new object[] {GameOptions.Rock},
           new object[] {GameOptions.Paper},
           new object[] {GameOptions.Scissors}
        };

        [OneTimeTearDown]
        public void TearDownFixture()
        {
            sut = null;
        }


    }
}
