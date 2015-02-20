using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BMK.DAL;

namespace BMK_API
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}