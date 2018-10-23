using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{
    public class AltKategori: EntityBase
    {
        [Required]
        [MaxLength(50)]
        public string altkategoriAd { get; set; }
        public int? kategoriID { get; set; }

        public string aciklama { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool silindi { get; set; }

        //Relations

        [ForeignKey("kategoriID")]
        public virtual Kategori Kategori { get; set; }

    }
}