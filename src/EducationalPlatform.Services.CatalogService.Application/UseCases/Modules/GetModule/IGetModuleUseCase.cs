namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.GetModule;

public interface IGetModuleUseCase
{
    Task<UseCaseResult<GetModuleUseCaseModel>> Execute(Guid moduleId);
}