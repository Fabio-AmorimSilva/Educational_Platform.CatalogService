namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.UpdateCourse;

public interface IUpdateCourseUseCase
{
    Task<UseCaseResult<Guid>> Execute(UpdateCourseUseCaseModel model, Guid id);
}