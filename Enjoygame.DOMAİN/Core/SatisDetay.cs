using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{
    [Table("SatisDetaylar")]
    public class SatisDetay : EntityBase
    {
        public int satisID { get; set; }
        public int urunID { get; set; }

        [Required]
        [DefaultValue(1)]
        public int adet { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal birimFiyat { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal tutar { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        //Relations

        [ForeignKey("satisID")]
        public virtual Satis Satis { get; set; }

        [ForeignKey("urunID")]
        public virtual Urun Urun { get; set; }
    }
}