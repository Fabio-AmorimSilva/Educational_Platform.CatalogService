namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.DeleteClass;

public class DeleteClassClassUseCase(IClassRepository repository) : IDeleteClassUseCase
{
    public async Task<UseCaseResult> ExecuteAsync(Guid classId)
    {
        var classEntity = await repository.GetClassById(classId);

        if (classEntity is null)
            return new NotFoundResponse<UseCaseResult>(ErrorMessages.NotFound<Class>());

        await repository.DeleteClass(classId);

        return new NoContentResponse<UseCaseResult>();
    }
}