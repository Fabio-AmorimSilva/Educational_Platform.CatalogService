namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.ListModules;

public class ListModulesUseCase(IModuleRepository repository) : IListModulesUseCase
{
    public async Task<UseCaseResult<IEnumerable<ListModulesUseCaseModel>>> ExecuteAsync()
    {
        var modules = await repository.GetModulesAsync();

        return new OkResponse<IEnumerable<ListModulesUseCaseModel>>(
            modules.Select(m => new ListModulesUseCaseModel
            {
                Name = m.Name,
                Description = m.Description
            }));
    }
}