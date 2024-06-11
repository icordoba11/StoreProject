using Negocio.Entities;

namespace Negocio.Persistence
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);
        Product SearchProduct();
        List<Product> SearchProducts();
    }
}
