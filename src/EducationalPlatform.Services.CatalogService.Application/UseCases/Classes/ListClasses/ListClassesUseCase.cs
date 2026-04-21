namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.ListClasses;

public class ListClassesUseCase(IClassRepository repository) : IListClassesUseCase
{
    public async Task<UseCaseResult<IEnumerable<ListClassesUseCaseModel>>> ExecuteAsync()
    {
        var classEntities = await repository.GetAllClasses();

        return new OkResponse<IEnumerable<ListClassesUseCaseModel>>(
            classEntities.Select(c => new ListClassesUseCaseModel
            {
                ClassId = c.Id,
                Description = c.Description,
                Duration = c.Duration,
                Name = c.Name,
                VideoLink = c.VideoLink
            }));
    }
}