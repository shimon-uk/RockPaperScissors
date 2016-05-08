using System;
using NUnit.Framework;
using Moq;
using RockPaperScissors;
using System.Collections.Generic;

namespace Test
{
    [TestFixture]
    public class RulesTest
    {
        [Test]
        public void GetMethodReturnsCollectionOfRuleObjects()
        {

            var sut = Rules.RulesCollection;
           
            Assert.IsInstanceOf<List<IRule>>(sut);

        }
       
    }
}
