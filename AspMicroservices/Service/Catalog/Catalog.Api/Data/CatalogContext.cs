using Catalog.Api.Entites;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public class CatalogContext : IcatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings.ConnectionString"));
            var databse = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings.DatabaseName"));
            Products = databse.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings.CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
      public IMongoCollection<Product> Products { get; }
    }
}
