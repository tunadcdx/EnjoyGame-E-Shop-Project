using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{
    [Table("Urunler")]
    public class Urun : EntityBase
    {
        [Required]
        [MaxLength(20)]
        public string urunkodu { get; set; }

        [Required]
        [MaxLength(50)]
        public string urunAd { get; set; }
        public int? kategoriID { get; set; }
        public int altkategoriID { get; set; }

        [Required]
        [DefaultValue(1)]
        public int miktar { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal urunFiyat { get; set; }
        public string urunBilgisi { get; set; }

        public string AltBilgisi { get; set; }

        [StringLength(100)]
        public string urunResimYolu1 { get; set; }

        [StringLength(100)]
        public string urunKapakResim { get; set; }
        [StringLength(100)]
        public string urunResimYolu2 { get; set; }
        [StringLength(100)]
        public string urunResimYolu3 { get; set; }


        [Required]
        [DefaultValue(false)]
        public bool indirim { get; set; }

        [Required]
        [DefaultValue(0)]
        public int indirimOrani { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        //Relations

        [ForeignKey("kategoriID")]
        public virtual Kategori Kategori { get; set; }


        public virtual List<SatisDetay> SatisDetaylar { get; set; }
    }
}
