namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.CreateCourse;

public class CreateCourseUseCase(ICourseRepository repository) : ICreateCourseUseCase
{
    public async Task<UseCaseResult<Guid>> Execute(CreateCourseUseCaseModel model)
    {
        var course = new Course(
            name: model.Name,
            description: model.Description,
            cover: model.Cover
        );
        
        await repository.CreateCourse(course);
        
        return new CreatedResponse<Guid>(course.Id);
    }
}