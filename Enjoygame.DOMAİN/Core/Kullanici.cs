using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Enjoygame.DOMAİN.Core
{
    [Table("Kullanıcılar")]
    public class Kullanici : EntityBase

    {
        [Required]
        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string Surname { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        ///////

        public virtual List<Satis> Satislar { get; set; }
        ///////
    }
}