using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShelteredV1.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() { Name = "Çadır", Description = "Çadır Ürünleri" },
                new Category() { Name = "Dağcılık", Description = "Dağcılık Ürünleri" },
                new Category() { Name = "Kamp", Description = "Kamp Malzemeleri" },
                new Category() { Name = "Hiking", Description = "Hiking Ürünleri" }
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product()
                {
                    Name = "Tent Nail", Description = "30 cm Nail", Price = 50, Stock = 10, IsApproved = true,
                    CategoryId = 1 , IsHome = true , Image = "TentNail.png"
                },
                new Product()
                {
                    Name = "Ice Axe", Description = "57cm Axe", Price = 50, Stock = 10, IsApproved = true,
                    CategoryId = 2, Image = "IceAxe.png"
                },
                new Product()
                {
                    Name = "Tent", Description = "2M Tent", Price = 200, Stock = 5, IsApproved = true, CategoryId = 3, Image = "Tent.png"
                },
                new Product()
                {
                    Name = "Canteen", Description = "1L Canteen", Price = 150, Stock = 7, IsApproved = true,
                    CategoryId = 4, Image = "Canteen.png"
                }
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}