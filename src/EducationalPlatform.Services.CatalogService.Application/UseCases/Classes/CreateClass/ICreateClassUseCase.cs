namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.CreateClass;

public interface ICreateClassUseCase
{
    Task<UseCaseResult<Guid>> ExecuteAsync(CreateClassUseCaseModel model);
}