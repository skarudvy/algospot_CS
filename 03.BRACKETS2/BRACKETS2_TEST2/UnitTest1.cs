using System;
using BRACKETS2;
using NUnit.Framework;

namespace BRACKETS2_TEST2
{
    public class UnitTest1
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingAccountToAccountsAddsAccountToList()
        {
            Brackets brackets = new Brackets("()()");
            Assert.AreEqual(brackets.ValidationBracket(), true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
