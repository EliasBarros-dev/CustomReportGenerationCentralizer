using System.Data;

namespace CustomReportGenerationCentralizer.Infrastructure.Interfaces;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}