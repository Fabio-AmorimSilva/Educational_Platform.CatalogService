namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.GetClass;

public interface IGetClassUseCase
{
    Task<UseCaseResult<GetClassUseCaseModel>> ExecuteAsync(Guid classId);
}