using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Enjoygame.PL.Areas.Admin.Models
{
    public class LoginControl : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                if (!string.IsNullOrEmpty(HttpContext.Current.Session["userid"].ToString()))
                {
                    base.OnActionExecuting(filterContext);
                }
                else
                {
                    HttpContext.Current.Response.Redirect("/Admin/Home/Login");
                }
            }
            catch (Exception)
            {
                HttpContext.Current.Response.Redirect("/Admin/Home/Login");
            }
        }

    }
}