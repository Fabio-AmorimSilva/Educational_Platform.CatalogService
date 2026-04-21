namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.ListClasses;

public interface IListClassesUseCase
{
    Task<UseCaseResult<IEnumerable<ListClassesUseCaseModel>>> ExecuteAsync();
}