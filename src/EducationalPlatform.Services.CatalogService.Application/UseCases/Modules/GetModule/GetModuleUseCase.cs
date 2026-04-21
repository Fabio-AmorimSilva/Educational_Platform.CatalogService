namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.GetModule;

public class GetModuleUseCase(IModuleRepository repository) : IGetModuleUseCase
{
    public async Task<UseCaseResult<GetModuleUseCaseModel>> Execute(Guid moduleId)
    {
        var module = await repository.GetModuleAsync(moduleId);

        if (module is null)
            return new NotFoundResponse<GetModuleUseCaseModel>(ErrorMessages.NotFound<Module>());

        return new OkResponse<GetModuleUseCaseModel>(new GetModuleUseCaseModel
        {
            Name = module.Name,
            Description = module.Description
        });
    }
}