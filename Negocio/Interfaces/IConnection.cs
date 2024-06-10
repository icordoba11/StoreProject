using System.Data.SqlClient;

namespace Negocio.Interfaces
{
    public interface IConnection
    {
        SqlConnection GetConnection();
    }
}
