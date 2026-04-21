namespace EducationalPlatform.Services.CatalogService.Infrastructure.Repositories;

public class ModuleRepository(IDbConnectionFactory factory) : IModuleRepository
{
    public async Task<int> CreateModuleAsync(Module module)
    {
        using var connection = factory.CreateConnection();

        return await connection.ExecuteAsync(Queries.InsertModule, module);
    }

    public async Task<int> UpdateModuleAsync(Module module)
    {
        using var connection = factory.CreateConnection();
        
        return await connection.ExecuteAsync(Queries.UpdateModule, module);
    }

    public async Task DeleteModuleAsync(Guid id)
    {
        using var connection = factory.CreateConnection();
        
        await connection.ExecuteAsync(Queries.DeleteModule, new { Id = id });
    }

    public async Task<Module?> GetModuleAsync(Guid id)
    {
        using var connection = factory.CreateConnection();
        
        return await connection.QueryFirstOrDefaultAsync<Module>(Queries.GetModule, id);
    }

    public async Task<IEnumerable<Module>> GetModulesAsync()
    {
        using var connection = factory.CreateConnection();
        
        return await connection.QueryAsync<Module>(Queries.GetAllModules);
    }
}