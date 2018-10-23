using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{

    [Table("Kategori")]
    public class Kategori : EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string KategoriAd { get; set; }

        public string acıklama { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Silindi { get; set; }

        ///////

        public virtual List<Urun> Urunler { get; set; }

        //////


    }
}