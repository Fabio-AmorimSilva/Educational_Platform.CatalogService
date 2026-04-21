namespace EducationalPlatform.Services.CatalogService.Infrastructure.Repositories;

public class CourseRepository(IDbConnectionFactory factory) : ICourseRepository
{
    public async Task<int> CreateCourse(Course model)
    {
        using var connection = factory.CreateConnection();

        return await connection.ExecuteAsync(Queries.InsertCourse);
    }

    public async Task<int> UpdateCourse(Course model)
    {
        using var connection = factory.CreateConnection();

        return await connection.ExecuteAsync(Queries.UpdateCourse, model);
    }

    public async Task DeleteCourse(Guid id)
    {
        using var connection = factory.CreateConnection();
        
        await connection.ExecuteAsync(Queries.DeleteCourse, new { Id = id });
    }

    public async Task<Course?> GetCourseById(Guid id)
    {
        using var connection = factory.CreateConnection();

        return await connection.QueryFirstOrDefaultAsync<Course>(Queries.GetCourse, new { Id = id });
    }

    public async Task<IEnumerable<Course>> GetAllCourses()
    {
        using var connection = factory.CreateConnection();
        
        return await connection.QueryAsync<Course>(Queries.GetAllCourse);
    }
}