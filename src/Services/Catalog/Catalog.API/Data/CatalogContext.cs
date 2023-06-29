using Catalog.API.Entites;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration config) {
            var db = new MongoClient(config.GetValue<string>("DatabaseSettings:ConnectionString"))
                     .GetDatabase(config.GetValue<string>("DatabaseSettings:DatabaseName"));
            Products = db.GetCollection<Product>("DatabaseSettings:CollectionName");
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
