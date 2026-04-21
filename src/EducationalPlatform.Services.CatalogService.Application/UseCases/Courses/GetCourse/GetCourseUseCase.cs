namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.GetCourse;

public class GetCourseUseCase(ICourseRepository repository) : IGetCourseUseCase
{
    public async Task<UseCaseResult<GetCourseUseCaseModel>> Execute(Guid id)
    {
        var course = await repository.GetCourseById(id);

        if (course is null)
            return new NotFoundResponse<GetCourseUseCaseModel>(ErrorMessages.NotFound<Course>());
        
        return new OkResponse<GetCourseUseCaseModel>(new GetCourseUseCaseModel
        {
            Description = course.Description,
            Name = course.Name,
            Cover = course.Cover
        });
    }
}