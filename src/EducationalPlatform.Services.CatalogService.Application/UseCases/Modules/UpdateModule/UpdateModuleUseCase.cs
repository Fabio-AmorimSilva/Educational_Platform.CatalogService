namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.UpdateModule;

public class UpdateModuleUseCase(IModuleRepository repository) : IUpdateModuleUseCase
{
    public async Task<UseCaseResult> ExecuteAsync(UpdateModuleUseCaseModel model)
    {
        var module = await repository.GetModuleAsync(model.Id);

        if (module is null)
            return new NotFoundResponse<Module>(ErrorMessages.NotFound<Module>());
        
        await repository.UpdateModuleAsync(module);
        
        return new NoContentResponse<UseCaseResult>();
    }
}