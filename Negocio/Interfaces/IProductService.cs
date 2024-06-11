using Negocio.Entities;

namespace Negocio.Interfaces
{
    public interface IProductService 
    {
        Product CreateDefaultProduct();
        Product SearchProduct();

        List<Product> SearchProducts();
    }
}
