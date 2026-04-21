namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.ListCourses;

public interface IListCoursesUseCase
{
    Task<UseCaseResult<IEnumerable<ListCoursesUseCaseModel>>> Execute();
}