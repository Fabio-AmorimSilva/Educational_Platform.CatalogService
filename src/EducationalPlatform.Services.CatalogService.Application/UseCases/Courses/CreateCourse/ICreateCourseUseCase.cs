namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.CreateCourse;

public interface ICreateCourseUseCase
{
    Task<UseCaseResult<Guid>> Execute(CreateCourseUseCaseModel model);
}