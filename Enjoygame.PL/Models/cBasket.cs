using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enjoygame.PL.Models
{
    public class cBasket
    {
            public int urunid { get; set; }
            public string urunad { get; set; }
            public int adet { get; set; }
            public decimal fiyat { get; set; }
            public decimal tutar { get; set; }

            public static List<cBasket> SepetAl()
            {
                HttpContext context = HttpContext.Current;
                if (context.Session["basket"] == null)
                    context.Session["basket"] = new List<cBasket>();
                return (List<cBasket>)context.Session["basket"];
            }
            public void SepeteEkle(List<cBasket> basket, cBasket order)
            {
                if (basket.Any(s => s.urunid == order.urunid))
                {
                    foreach (cBasket item in basket)
                    {
                        if (item.urunid == order.urunid)
                        {
                            item.adet += order.adet;
                            item.tutar += order.tutar;
                        }
                    }
                }
                else
                {
                basket.Add(order);
                }
                HttpContext.Current.Session["basket"] = basket;
                HttpContext.Current.Session["toplamadet"] = ToplamAdetBul(basket);
                HttpContext.Current.Session["toplamtutar"] = ToplamTutarBul(basket);
            }
            public void SepettenSil(List<cBasket> basket, cBasket order)
            {
            basket.Remove(order);
                HttpContext.Current.Session["basket"] = basket;
                HttpContext.Current.Session["toplamadet"] = ToplamAdetBul(basket);
                HttpContext.Current.Session["toplamtutar"] = ToplamTutarBul(basket);
            }
            public int ToplamAdetBul(List<cBasket> sepet)
            {
                int ToplamAdet = 0;
                foreach (cBasket item in sepet)
                {
                    ToplamAdet += item.adet;
                }
                return ToplamAdet;
            }
            public decimal ToplamTutarBul(List<cBasket> basket)
            {
                decimal ToplamTutar = 0;
                foreach (cBasket item in basket)
                {
                    ToplamTutar += item.tutar;
                }
                return ToplamTutar;
            }
        }
    }
