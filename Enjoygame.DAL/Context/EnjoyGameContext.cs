using Enjoygame.DAL.Migrations;
using Enjoygame.DOMAİN.Core;
using Enjoygame.DOMAİN.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Enjoygame.DAL.Context 
{
    public class EnjoyGameContext : DbContext
    {
        public EnjoyGameContext() : base("EnjoyGameContext")
        {

            Database.SetInitializer(new
                MigrateDatabaseToLatestVersion<EnjoyGameContext, Configuration>("EnjoyGameContext"));
        }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<AltKategori> AltKategori { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<SatisDetay> SatisDetay { get; set; }
        public virtual DbSet<Kullanici> Kullanicilar { get; set; }
        public virtual DbSet<AdminSession> Admin { get; set; }


    }
}