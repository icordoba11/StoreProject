using Dapper;
using Negocio.Entities;
using Negocio.Interfaces;
using Negocio.Persistence;
using System.Data.SqlClient;


namespace Negocio.Services
{
    public class ProductService : IProductService
    {

        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public void InsertProduct(Product product)
        {
            _productRepository.InsertProduct(product);
        }

        public Product CreateDefaultProduct()
        {
            var now = DateTime.Now;

            return new Product
            {
                idProduct = 1,
                name = "pinza agarra huevos",
                description = "pinza para agarrarse los huevos",
                price = 17,
                actualStock = 1,
                creationDate = now
            };
        }

        public Product SearchProduct()
        {
            var product = _productRepository.SearchProduct();
          
            return product;
        }
    }
}
