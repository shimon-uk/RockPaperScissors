using System;
using NUnit.Framework.Legacy;
using Moq;
using RockPaperScissors;
using System.Collections.Generic;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class RulesTest
    {
        [Test]
        public void GetMethodReturnsCollectionOfRuleObjects()
        {

            var sut = Rules.RulesCollection;
           
            ClassicAssert.IsInstanceOf<List<IRule>>(sut);

        }
       
    }
}
