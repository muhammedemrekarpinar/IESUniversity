using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ShelteredV1.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Ürün Miktarı")]
        public int Stock { get; set; }
        [DisplayName("Ürün Resmi")]
        public string Image { get; set; }
        [DisplayName("Anasayfa Görünürlüğü")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün Görünürlüğü")]
        public bool IsApproved { get; set; }
        [DisplayName("Ürün Kategorisi")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }

    }
}