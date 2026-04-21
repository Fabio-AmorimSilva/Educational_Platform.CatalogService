namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.UpdateModule;

public interface IUpdateModuleUseCase
{
    Task<UseCaseResult> ExecuteAsync(UpdateModuleUseCaseModel model);
}