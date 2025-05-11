using System.Data;
using System.Data.SqlClient;
using CustomReportGenerationCentralizer.Infrastructure.Interfaces;

namespace CustomReportGenerationCentralizer.Infrastructure.DatabaseConfiguration;

public class SqlConnectionFactory(string connectionString) : IDbConnectionFactory
{
    public IDbConnection CreateConnection()
    {
        var connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }
}