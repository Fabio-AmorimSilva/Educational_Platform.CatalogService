namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.CreateClass;

public class CreateClassUseCase(IClassRepository repository) : ICreateClassUseCase
{
    public async Task<UseCaseResult<Guid>> ExecuteAsync(CreateClassUseCaseModel model)
    {
        var Class = new Domain.Entities.Class(
            name: model.Name,
            description: model.Description,
            videoLink: model.VideoLink,
            duration: model.Duration
        );

        await repository.CreateClass(Class);

        return new CreatedResponse<Guid>(Class.Id);
    }
}