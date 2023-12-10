using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Controle.Infrastructure.Context;

public class DapperContext : IDisposable
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SqlServerDb");
    }
    public IDbConnection CreateConnection()
        => new SqlConnection(_connectionString);

    public void Dispose() => CreateConnection().Dispose();
}
