namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.UpdateClass;

public interface IUpdateClassUseCase
{
    Task<UseCaseResult<UseCaseResult>> ExecuteAsync(UpdateClassUseCaseModel model);
}