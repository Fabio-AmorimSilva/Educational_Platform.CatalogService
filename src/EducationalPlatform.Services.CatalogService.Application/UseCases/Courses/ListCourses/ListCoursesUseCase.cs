namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.ListCourses;

public class ListCoursesUseCase(ICourseRepository repository) : IListCoursesUseCase
{
    public async Task<UseCaseResult<IEnumerable<ListCoursesUseCaseModel>>> Execute()
    {
        var courses = await repository.GetAllCourses();

        return new OkResponse<IEnumerable<ListCoursesUseCaseModel>>(
            data: courses.Select(c => new ListCoursesUseCaseModel
            {
                Description = c.Description,
                Name = c.Name,
                Cover = c.Cover
            }
        ));
    }
}