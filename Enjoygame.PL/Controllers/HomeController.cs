using Enjoygame.DAL.Context;
using Enjoygame.DAL.Repositories;
using Enjoygame.DOMAİN.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enjoygame.PL.Controllers
{
    public class HomeController : Controller
    {
        EnjoyGameContext ent = new EnjoyGameContext();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewGames()
        {
            Repository<Urun> repo = new Repository<Urun>(ent);
            return PartialView(repo.GetAll().Take(5).ToList());
        }


        public ActionResult GameDetails(int ID)
        {
            Repository<Urun> repo = new Repository<Urun>(ent);
            return View(repo.Get(ID));
        }
        public ActionResult RandomGame()
        {
            Repository<Urun> repo = new Repository<Urun>(ent);
            return PartialView(repo.GetAll().Take(5).ToList());
        }


        public ActionResult Midgame()
        {
            Repository<Urun> repo = new Repository<Urun>(ent);

            return PartialView(repo.GetAll().Take(20).ToList());
        }
    }
}