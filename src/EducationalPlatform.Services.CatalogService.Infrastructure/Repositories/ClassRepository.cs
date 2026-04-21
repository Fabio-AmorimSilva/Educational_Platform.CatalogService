namespace EducationalPlatform.Services.CatalogService.Infrastructure.Repositories;

public class ClassRepository(IDbConnectionFactory connectionFactory) : IClassRepository
{
    public async Task<int> CreateClass(Class model)
    {
        using var connection = connectionFactory.CreateConnection();

        const string sql = Queries.InsertClass;

        return await connection.ExecuteAsync(sql, model);
    }

    public async Task<int> UpdateClass(Class model)
    {
        using var connection = connectionFactory.CreateConnection();

        const string sql = Queries.UpdateClass;

        return await connection.ExecuteAsync(sql, model);
    }

    public async Task DeleteClass(Guid id)
    {
        using var connection = connectionFactory.CreateConnection();

        const string sql = Queries.DeleteClass;

        await connection.ExecuteAsync(sql, new { Id = id });
    }

    public async Task<Class?> GetClassById(Guid id)
    {
        using var connection = connectionFactory.CreateConnection();

        const string sql = Queries.GetClass;

        return await connection.QueryFirstOrDefaultAsync<Class>(sql, new { Id = id });
    }

    public async Task<IEnumerable<Class>> GetAllClasses()
    {
        using var connection = connectionFactory.CreateConnection();

        const string sql = Queries.GetAllClasses;

        return await connection.QueryAsync<Class>(sql);
    }
}