namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.GetCourse;

public interface IGetCourseUseCase
{
    Task<UseCaseResult<GetCourseUseCaseModel>> Execute(Guid id);
}