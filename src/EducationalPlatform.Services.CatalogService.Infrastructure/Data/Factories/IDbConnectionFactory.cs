namespace EducationalPlatform.Services.CatalogService.Infrastructure.Data.Factories;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}