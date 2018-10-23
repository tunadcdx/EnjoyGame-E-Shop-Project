using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{
    [Table("Satislar")]
    public class Satis : EntityBase
    {
        [Required]
        public DateTime tarih { get; set; }

        public int kullaniciID { get; set; }

        [Required]
        [DefaultValue(1)]
        public int toplamMiktar { get; set; }

        [Required]
        [DefaultValue(0)]
        public decimal toplamTutar { get; set; }

        [Required]
        public DateTime teslimTarihi { get; set; }

        public byte durumu { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        //Relations
        [ForeignKey("kullaniciID")]
        public virtual Kullanici Kullanici { get; set; }

        public virtual List<SatisDetay> SatisDetaylar { get; set; }

    }
}