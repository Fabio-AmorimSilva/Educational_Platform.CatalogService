namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.UpdateClass;

public class UpdateClassUseCase(IClassRepository repository) : IUpdateClassUseCase
{
    public async Task<UseCaseResult<UseCaseResult>> ExecuteAsync(UpdateClassUseCaseModel model)
    {
        var classEntity = await repository.GetClassById(model.ClassId);

        if (classEntity is null)
            return new NotFoundResponse<UseCaseResult>(ErrorMessages.NotFound<Domain.Entities.Class>());
        
        classEntity.Update(
            name: model.Name,
            description: model.Description,
            videoLink: model.VideoLink,
            duration: model.Duration
        );

        await repository.UpdateClass(classEntity);
        
        return new NoContentResponse<UseCaseResult>();
    }
}