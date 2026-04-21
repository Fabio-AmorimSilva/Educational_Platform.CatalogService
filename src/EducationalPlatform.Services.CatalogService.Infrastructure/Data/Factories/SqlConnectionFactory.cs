namespace EducationalPlatform.Services.CatalogService.Infrastructure.Data.Factories;

public class SqlConnectionFactory(IConfiguration configuration) : IDbConnectionFactory
{
    private readonly string _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException();

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}