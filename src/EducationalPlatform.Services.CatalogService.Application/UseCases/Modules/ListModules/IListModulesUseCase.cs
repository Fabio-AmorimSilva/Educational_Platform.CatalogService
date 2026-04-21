namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.ListModules;

public interface IListModulesUseCase
{
    Task<UseCaseResult<IEnumerable<ListModulesUseCaseModel>>> ExecuteAsync();
}