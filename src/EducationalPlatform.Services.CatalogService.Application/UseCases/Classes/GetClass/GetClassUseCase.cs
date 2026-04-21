namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.GetClass;

public class GetClassUseCase(IClassRepository repository) : IGetClassUseCase
{
    public async Task<UseCaseResult<GetClassUseCaseModel>> ExecuteAsync(Guid classId)
    {
        var classEntity = await repository.GetClassById(classId);

        if (classEntity is null)
            return new NotFoundResponse<GetClassUseCaseModel>(ErrorMessages.NotFound<Class>());

        return new OkResponse<GetClassUseCaseModel>(
            new GetClassUseCaseModel
            {
                ClassId = classEntity.Id,
                Name = classEntity.Name,
                Description = classEntity.Description,
                VideoLink = classEntity.VideoLink,
                Duration = classEntity.Duration
            });
    }
}