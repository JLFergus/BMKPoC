using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BMK.Models;
using BMK.DAL;
using Ninject;

namespace BMK_API.Controllers
{
    public class UserController : ApiController
    {
        [Inject]
        IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public UserController() 
        { }

        public Registration RegisterKnife(int userId, string productSKU)
        {
            return _userRepo.RegisterProduct(userId, productSKU);
        }
    }
}
