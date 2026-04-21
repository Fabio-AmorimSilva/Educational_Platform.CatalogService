namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.CreateModule;

public class CreateModuleUseCase(IModuleRepository repository) : ICreateModuleUseCase
{
    public async Task<UseCaseResult<Guid>> ExecuteAsync(CreateModuleUseCaseModel model)
    {
        var module = new Module(
            courseId: model.CourseId,
            name: model.Name,
            description: model.Description
        );
        
        await repository.CreateModuleAsync(module);
        
        return new CreatedResponse<Guid>(module.Id);
    }
}