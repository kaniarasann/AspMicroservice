using Catalog.API.Entites;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
    }
}
