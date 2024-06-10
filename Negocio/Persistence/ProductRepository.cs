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
                string query = "INSERT INTO Productos (Id_producto, Nombre, Descripcion, Precio, Stock_actual, Fecha_creacion)" +
                               "VALUES (@idProduct, @name, @description, @price, @actualStock, @creationDate)";

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
                string query = "SELECT * FROM Productos WHERE Id_producto = @ProductId";
                var result = connection.QueryFirstOrDefault<Product>(query, new { ProductId = 1 });
              
                return result;

            }

        }
    }
}
