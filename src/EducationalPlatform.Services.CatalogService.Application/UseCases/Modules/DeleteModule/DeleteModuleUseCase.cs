namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.DeleteModule;

public class DeleteModuleUseCase(IModuleRepository repository) : IDeleteModuleUseCase
{
    public async Task<UseCaseResult> ExecuteAsync(Guid id)
    {
        var module = await repository.GetModuleAsync(id);

        if (module is null)
            return new NotFoundResponse<Module>(ErrorMessages.NotFound<Module>());
        
        await repository.DeleteModuleAsync(module.Id);
        
        return new NoContentResponse<UseCaseResult>();
    }
}