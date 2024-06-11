using Dapper;
using Negocio.Entities;
using Negocio.Interfaces;

namespace Negocio.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConnection _connectionService;

        //Constructor 
        public ProductRepository(IConnection connectionService)
        {
            _connectionService = connectionService;
        }

        //Insert Product
        public void InsertProduct(Product product)
        {
            using (var connection = _connectionService.GetConnection())
            {
                Console.WriteLine("Ingresamos a la base de datos");
                var now = DateTime.Now;
                connection.Open();
                string query = "INSERT INTO Productos (Nombre, ItemDescription, Price, ActualStock, CreationDate)" +
                               "VALUES (@Nombre, @ItemDescription, @Price, @ActualStock, @CreationDate)";

                connection.Execute(query, product);

                connection.Close();
            }
        }
        //Search Product
        public Product SearchProduct()
        {
            using (var connection = _connectionService.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos WHERE Nombre = 'Laptop'";
                var result = connection.QueryFirstOrDefault<Product>(query);
                return result;

            }

        }
        public List<Product> SearchProducts()
        {
            using (var connection = _connectionService.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Productos";
                List<Product> result = connection.Query<Product>(query).ToList();
                return result;

            }

        }
    }
}
