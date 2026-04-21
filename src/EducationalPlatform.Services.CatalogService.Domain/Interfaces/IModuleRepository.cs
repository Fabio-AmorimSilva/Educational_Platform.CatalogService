namespace EducationalPlatform.Services.CatalogService.Domain.Interfaces;

public interface IModuleRepository
{
    Task<int> CreateModuleAsync(Module module);
    Task<int> UpdateModuleAsync(Module module);
    Task DeleteModuleAsync(Guid id);
    Task<Module?> GetModuleAsync(Guid id);
    Task<IEnumerable<Module>> GetModulesAsync();
}