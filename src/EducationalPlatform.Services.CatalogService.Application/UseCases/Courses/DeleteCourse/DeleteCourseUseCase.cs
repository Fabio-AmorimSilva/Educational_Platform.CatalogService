namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.DeleteCourse;

public class DeleteCourseUseCase(ICourseRepository repository) : IDeleteCourseUseCase
{
    public async Task<UseCaseResult> Execute(Guid id)
    {
        var course = await repository.GetCourseById(id);

        if (course is null)
            return new NotFoundResponse<UseCaseResult>(ErrorMessages.NotFound<Course>());
        
        await repository.DeleteCourse(id);
        
        return new NoContentResponse<UseCaseResult>();
    }
}