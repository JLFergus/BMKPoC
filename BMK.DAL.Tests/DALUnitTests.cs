using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace BMK.DAL.Tests
{
    [TestFixture]
    public class DALUnitTests
    {
        [Test]
        public void TestSaveUser()
        {
            Assert.AreEqual(10, 5 + 5);
        }
        [Test]
        public void FailSameValues()
        {
            Assert.AreEqual(10, 5 + 6);
        }
    }
}
