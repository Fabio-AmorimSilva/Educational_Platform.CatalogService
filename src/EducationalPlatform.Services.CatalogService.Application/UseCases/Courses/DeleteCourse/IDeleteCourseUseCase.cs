namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.DeleteCourse;

public interface IDeleteCourseUseCase
{
    Task<UseCaseResult> Execute(Guid id);
}