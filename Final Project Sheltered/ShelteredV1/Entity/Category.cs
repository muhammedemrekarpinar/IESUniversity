using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShelteredV1.Entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        public string Description { get; set; }

        public List<Product> Products { get; set; }

    }
}