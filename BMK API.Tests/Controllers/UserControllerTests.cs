using System;
using NUnit.Framework;
using Rhino.Mocks;
using BMK_API;
using BMK.Models;
using BMK.DAL;
using BMK_API.Controllers;

namespace BMK_API.Tests.Controllers
{
    [TestFixture]
    public class UserControllerTests
    {
        IUserRepository _userRepo;
        DateTime registerDate = DateTime.Now.Date;
        [SetUp]
        public void Setup()
        {
            
            _userRepo = MockRepository.GenerateStub<IUserRepository>();
            _userRepo.Stub(x => x.RegisterProduct(0, "")).IgnoreArguments().Return(
                new Registration
                {
                    User = new User { Id = 0 },
                    Product = new Product { SKU = "0" },
                    Date = registerDate,
                    Comment = "not actually registered!"
                });
        }

        [Test]
        public void TestRegisterProduct()
        {
            var testCtrlr = new UserController();
            var ctrlr = new UserController(_userRepo);
            var reg = ctrlr.RegisterKnife(0, "KNIFE");
            Assert.AreEqual(reg.Comment, "not actually registered!");
        }
    }
}
