using Negocio.Interfaces;
using System.Data.SqlClient;

namespace Negocio.DataBaseConnection
{
    public class ConnectionService : IConnection
    {
        readonly IConfiguration _configuration;
        public ConnectionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public SqlConnection GetConnection()
        {
            var test = _configuration.GetConnectionString("DefaultConnectionString");
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnectionString"));
        }

        

    }
}
