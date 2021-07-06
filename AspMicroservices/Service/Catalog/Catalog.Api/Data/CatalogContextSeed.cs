using Catalog.Api.Entites;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool exitProduct = productCollection.Find(p => true).Any();
            if(!exitProduct)
            {
                productCollection.InsertManyAsync(GetPreConfigureProduct());
            }
        }

        public static IEnumerable<Product> GetPreConfigureProduct()
        {
            return new List<Product>()
           {
               new Product()
               {
                   Id = "507f1f77bcf86cd799439011",
                   Name = "Iphone",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product1.png",
                   Price = 989.00M,
                   Category = "Smart phone"
               },
                new Product()
               {
                   Id = "507f191e810c19729de860ea",
                   Name = "computer",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product2.png",
                   Price = 989.00M,
                   Category = "computer "
               },
                 new Product()
               {
                   Id = "5349b4ddd2781d08c09890f3",
                   Name = "ball",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product3.png",
                   Price = 989.00M,
                   Category = "Sports"
               },
                  new Product()
               {
                   Id = "5349b4ddd2781d08c09890f4",
                   Name = "notebook",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product4.png",
                   Price = 900.00M,
                   Category = "Notebook"
               },
                   new Product()
               {
                   Id = "5349b4ddd2781d08c09890f3",
                   Name = "Pen",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product5.png",
                   Price = 600,
                   Category = "Pen"
               },
                    new Product()
               {
                   Id = "5349b4ddd2781d08c09890f5",
                   Name = "Oil",
                   Summary = "This is company product",
                   Description = "This is company product",
                   ImageFile = "product6.png",
                   Price = 500,
                   Category = "hair Oil"
               },

           };
        }
    }
}
