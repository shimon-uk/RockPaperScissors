using System;
using NUnit.Framework.Legacy;
using Moq;
using RockPaperScissors;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class RuleTests
    {
        Rule sut;
        
        [OneTimeSetUp]
        public void SetupFixture()
        {
            sut = new Rule();
        }
        [Test]
        public void RulesObjectReturnsRules()
        {

            ClassicAssert.IsInstanceOf<Rule>(sut);
        }

        [Test]
        public void RuleWinnerReturnsPlayerObjects()
        {
            sut.Winner = GameOptions.Rock;

            ClassicAssert.IsInstanceOf<GameOptions>(sut.Winner);
        }

        [Test]
        public void RuleLosserReturnsPlayerObjects()
        {
            sut.Losser = GameOptions.Scissors;

            ClassicAssert.IsInstanceOf<GameOptions>(sut.Losser);
        }

        [Test]
        public void RuleLosserPassesGameOption_Losser()
        {

            var expected = GameOptions.Scissors;

            var sut = new Rule(GameOptions.Rock , expected);

             ClassicAssert.AreEqual(sut.Losser,expected);
        }
        [Test]
        public void RuleWinnerPassesGameOption_Winner()
        {
            var expected = GameOptions.Rock;

            var sut = new Rule(expected, GameOptions.Scissors);

            ClassicAssert.AreEqual(sut.Winner, expected);
        }
        [Test]
        public void RuleWinnerReturnsGameOption_Winner()
        {
            var expected = GameOptions.Rock;

            sut.Winner = expected;

            ClassicAssert.AreEqual(sut.Winner, expected);
        }
        [Test]
        public void RuleLosserReturnsGameOption_Losser()
        {
            var expected = GameOptions.Rock;

            sut.Losser = expected;

            ClassicAssert.AreEqual(sut.Losser, expected);
        }
  
        [Test]
        public void RuleObjectReturnsCorrectFormattedString()
        {
            var winner = GameOptions.Rock;
            var losser=GameOptions.Scissors;
            var expected = string.Format("{0} beats {1}", winner, losser);


            var sut = new Rule(winner, losser);
            

            ClassicAssert.AreEqual(sut.ToString(), expected);
        }

        [OneTimeTearDown]
        public void TearDownFixture()
        {
            sut = null;
        }
    }
}
