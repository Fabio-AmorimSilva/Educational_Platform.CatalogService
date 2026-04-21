namespace EducationalPlatform.Services.CatalogService.Domain.Interfaces;

public interface ICourseRepository
{
    Task<int> CreateCourse(Course model);
    Task<int> UpdateCourse(Course model);
    Task DeleteCourse(Guid id);
    Task<Course?> GetCourseById(Guid id);
    Task<IEnumerable<Course>> GetAllCourses();
}