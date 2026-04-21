namespace EducationalPlatform.Services.CatalogService.Domain.Interfaces;

public interface IClassRepository
{
    Task<int> CreateClass(Class model);
    Task<int> UpdateClass(Class model);
    Task DeleteClass(Guid id);
    Task<Class?> GetClassById(Guid id);
    Task<IEnumerable<Class>> GetAllClasses();
}