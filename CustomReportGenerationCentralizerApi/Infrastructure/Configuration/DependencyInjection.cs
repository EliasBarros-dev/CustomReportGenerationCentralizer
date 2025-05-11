using CustomReportGenerationCentralizer.Application.Utils;
using CustomReportGenerationCentralizer.Domain.Interfaces;
using CustomReportGenerationCentralizer.Domain.Services;
using CustomReportGenerationCentralizer.Infrastructure.DatabaseConfiguration;
using CustomReportGenerationCentralizer.Infrastructure.Interfaces;

namespace CustomReportGenerationCentralizer.Infrastructure.Configuration;

public class DependencyInjection
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IReportService, ReportService>();
    }

    public static void ConfigureDatabase(IServiceCollection configuration)
    {
        configuration.AddScoped<IDbConnectionFactory>(provider =>
        {
            return new SqlConnectionFactory(Conection.String());
        });
    }
}