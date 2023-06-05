using Microsoft.Data.SqlClient;
using ProjeAcessoDadosDapper.Models;
using ProjeAcessoDadosDapper.Repositories;

public class UserRepository : Repository<User>
{
    private readonly SqlConnection _connection;

    public UserRepository(SqlConnection connection) : base(connection)
    =>_connection = connection;     

    
    
}