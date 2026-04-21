namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.CreateModule;

public interface ICreateModuleUseCase
{
    Task<UseCaseResult<Guid>> ExecuteAsync(CreateModuleUseCaseModel model);
}