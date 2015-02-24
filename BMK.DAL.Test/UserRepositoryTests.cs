using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BMK.DAL;
using BMK.Models;
using NUnit.Framework;


namespace BMK.DAL.Test
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void TestPass()
        {
            Assert.AreEqual(10, 5 + 5);
        }
        [Test]
        public void TestPass2()
        {
            Assert.AreEqual(11, 5 + 6);
        }
    }
}
