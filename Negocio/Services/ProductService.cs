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

                Nombre = "Sacacorchos",
                ItemDescription = "Saca los corchos",
                Price = 450,
                ActualStock = 60,
                CreationDate = now
            };
        }

        public Product SearchProduct()
        {
            var product = _productRepository.SearchProduct();

            return product;
        }
        public List<Product> SearchProducts()
        {
            List<Product> products = _productRepository.SearchProducts();

            return products;
        }
    }
}
