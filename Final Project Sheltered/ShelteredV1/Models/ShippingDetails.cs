using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShelteredV1.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Adres tanımını giriniz.")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lütfen Adres giriniz.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen Şehir giriniz.")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen Semt giriniz.")]
        public string Semt { get; set; }

        public string Mahalle { get; set; }

        [Required(ErrorMessage = "Lütfen Posta Kodu giriniz.")]
        public string PostaKodu { get; set; }
    }
}