using Enjoygame.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Enjoygame.PL.Areas.Admin.Models
{
    public class LoginState
    {
        EnjoyGameContext ent = new EnjoyGameContext();

        public bool IsLoginSucces(string email, string password)
        {
            var userid = ent.Admin.Where(x => x.email.Equals(email) && x.password.Equals(password)).SingleOrDefault();
            if (userid != null)
            {
                HttpContext.Current.Session["userid"] = userid.ID.ToString();
                
                return true;
            }
            return false;
        }
    }
}