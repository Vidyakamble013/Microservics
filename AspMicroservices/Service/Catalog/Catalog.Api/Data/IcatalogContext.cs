using Catalog.Api.Entites;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Api.Data
{
    public interface IcatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
