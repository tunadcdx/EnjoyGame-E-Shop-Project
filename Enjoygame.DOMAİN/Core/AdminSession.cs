namespace Enjoygame.DOMAİN.Core
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AdminSession : EntityBase
    {
        public string email { get; set; }
        public string password { get; set; }
        public string adminName { get; set; }

    }

}