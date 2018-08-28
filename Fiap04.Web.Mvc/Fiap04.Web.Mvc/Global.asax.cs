using Fiap04.Web.Mvc.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap04.Web.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object DataBase { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<ImigracaoContext>()
            );
        }
    }
}
