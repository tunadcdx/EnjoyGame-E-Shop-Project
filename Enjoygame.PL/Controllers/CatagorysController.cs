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
    public class CatagorysController : Controller
    {
        EnjoyGameContext ent = new EnjoyGameContext();
        // GET: Catagorys
        public ActionResult Index(int id)
        {
            Repository<Kategori> repo = new Repository<Kategori>(ent);


            return PartialView(repo.Get(x => x.ID == id));
        }

    }
}