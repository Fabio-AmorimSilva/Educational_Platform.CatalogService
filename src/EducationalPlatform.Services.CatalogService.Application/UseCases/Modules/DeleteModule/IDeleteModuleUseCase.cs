namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.DeleteModule;

public interface IDeleteModuleUseCase
{
    Task<UseCaseResult> ExecuteAsync(Guid id);
}