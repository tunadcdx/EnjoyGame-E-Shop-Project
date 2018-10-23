using Enjoygame.DAL.Context;
using Enjoygame.DAL.Repositories;
using Enjoygame.DOMAİN.Core;
using Enjoygame.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enjoygame.PL.Controllers
{
    public class BasketController : Controller
    {
        EnjoyGameContext ent = new EnjoyGameContext();
        private int urun;


        // GET: Basket
        public ActionResult Index()
        {
            List<cBasket> basket = new List<cBasket>();
            return View(basket);
        }

        public ActionResult BasketAdd(string ID, string Adet)
        {

            Repository<Urun> repo = new Repository<Urun>(ent);
            Urun u = repo.Get(Convert.ToInt32(ID));
            cBasket s = new cBasket();
            s.urunid = u.ID;
            s.urunad = u.urunAd;
            s.adet = Convert.ToInt32(Adet);
            s.fiyat = u.urunFiyat;
            s.tutar = s.adet * s.fiyat;
            List<cBasket> shop = cBasket.SepetAl();
            s.SepeteEkle(shop, s);
            return View("Index");
        }
    }
}