using Enjoygame.DAL.Context;
using Enjoygame.DOMAİN.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Enjoygame.PL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            using (EnjoyGameContext db = new EnjoyGameContext())
            {
                db.Database.CreateIfNotExists();
            }
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //EnjoyGameContext ent = new EnjoyGameContext();
            //RoleStore<ApplicationRole> RoleStore = new RoleStore<ApplicationRole>(ent);
            //RoleManager<ApplicationRole> roleManager = new RoleManager<ApplicationRole>(RoleStore);

            //if (!roleManager.RoleExists("Admin"))
            //{
            //    ApplicationRole adminRole = new ApplicationRole("Admin", "Sistem Yöneticisi");
            //    roleManager.Create(adminRole);
            //}
            //if (!roleManager.RoleExists("User"))
            //{
            //    ApplicationRole userRole = new ApplicationRole("User", "Kullanıcı");
            //    roleManager.Create(userRole);
            //}

        }
    }
}
