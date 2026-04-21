namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.GetCourse;

public record GetCourseUseCaseModel
{
    public string Name { get; init; } =  null!;
    public string Description { get; init; } = null!;
    public string Cover { get; init; } = null!;
}