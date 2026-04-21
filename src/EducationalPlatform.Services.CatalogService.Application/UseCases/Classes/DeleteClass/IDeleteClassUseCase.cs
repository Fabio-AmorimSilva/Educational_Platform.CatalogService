namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.DeleteClass;

public interface IDeleteClassUseCase
{
    Task<UseCaseResult> ExecuteAsync(Guid classId);
}