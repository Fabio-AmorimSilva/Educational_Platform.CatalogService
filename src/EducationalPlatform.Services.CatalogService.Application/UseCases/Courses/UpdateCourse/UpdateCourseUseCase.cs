namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.UpdateCourse;

public class UpdateCourseUseCase(ICourseRepository repository) : IUpdateCourseUseCase
{
    public async Task<UseCaseResult<Guid>> Execute(UpdateCourseUseCaseModel model, Guid id)
    {
        var course = await repository.GetCourseById(id);

        if (course is null)
            return new NotFoundResponse<Guid>(ErrorMessages.NotFound<Course>());
        
        course.Update(
            name: model.Name,
            description: model.Description,
            cover: model.Cover
        );
        
        await repository.UpdateCourse(course);

        return new NoContentResponse<Guid>();
    }
}