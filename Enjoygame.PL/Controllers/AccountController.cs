using Enjoygame.DAL.Context;
using Enjoygame.DOMAİN.Core;
using Enjoygame.DOMAİN.Identity;
using Enjoygame.PL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Enjoygame.PL.Controllers
{
    public class AccountController : Controller
    {


        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            EnjoyGameContext ent = new EnjoyGameContext();
            UserStore<ApplicationUser> userStore = new UserStore<ApplicationUser>(ent);
            UserManager = new UserManager<ApplicationUser>(userStore);

            RoleStore<ApplicationRole> roleStore = new RoleStore<ApplicationRole>(ent);
            RoleManager = new RoleManager<ApplicationRole>(roleStore);
        }


        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Kullanici model)
        {

            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser();
                user.Name = model.Name;
                user.SurName = model.Surname;
                user.Email = model.Email;
                user.UserName = model.Username;
                IdentityResult iResult = UserManager.Create(user, model.Password);
                if (iResult.Succeeded)
                {
                    UserManager.AddToRole(user.Id, "User");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("RegisterUser", "Kullanıcı Ekleme İşlemi Başarısız");
                }
            }
            return View(model);
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = UserManager.Find(model.Username, model.Password);
                if (user != null)
                {
                    IAuthenticationManager autManager = HttpContext.GetOwinContext().Authentication;
                    if (true)
                    {
                        ClaimsIdentity identity = UserManager.CreateIdentity(user, "ApplicationCookie");

                        AuthenticationProperties authProps = new AuthenticationProperties();
                        authProps.IsPersistent = model.RememberMe;
                        autManager.SignIn(authProps, identity);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Login", "Böyle Bir Kullancı Bulunamadı !");
                    }
                }
            }
            return View(model);
        }

        [Authorize]
        public ActionResult Logout()
        {
            IAuthenticationManager authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}