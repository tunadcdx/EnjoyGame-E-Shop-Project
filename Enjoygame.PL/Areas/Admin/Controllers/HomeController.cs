using Enjoygame.DAL.Context;
using Enjoygame.DAL.Repositories;
using Enjoygame.DOMAİN.Core;
using Enjoygame.PL.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enjoygame.PL.Areas.Admin.Controllers
{

    public class HomeController : Controller
    {
        // GET: Admin/Home
        //[LoginControl]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            if (new LoginState().IsLoginSucces(email, password))
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Login", "Home");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult NewgameCreate()
        {
            EnjoyGameContext ent = new EnjoyGameContext();
            Repository<Urun> repo = new Repository<Urun>(ent);
             
            return PartialView();
        }





    }
}