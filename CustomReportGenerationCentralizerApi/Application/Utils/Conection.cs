namespace CustomReportGenerationCentralizer.Application.Utils;

public class Conection
{
    public static string String()
    {
        var host = Environment.GetEnvironmentVariable("HOST");
        var database = Environment.GetEnvironmentVariable("DATABASE");
        var user = Environment.GetEnvironmentVariable("USER");
        var password = Environment.GetEnvironmentVariable("PASSWORD");
        var port = Environment.GetEnvironmentVariable("PORT");
        
        return $"Server={host},{port};Database={database};User Id={user};Password={password};Trusted_Connection=True";
    }
}