namespace EducationalPlatform.Services.CatalogService.Infrastructure.Repositories;

public static class Queries
{
    public const string InsertClass = "INSERT INTO Class (Id, Name, Description, VideoLink, Duration) VALUES (@Id, @Name, @Description, @VideoLink, @Duration)";
    public const string UpdateClass = "UPDATE Class SET Name = @Name, Description = @Description, VideoLink = @VideoLink, Duration = @Duration WHERE Id = @Id;";
    public const string DeleteClass = "DELETE FROM Class WHERE Id=@Id";
    public const string GetClass = "SELECT * FROM Class WHERE Id=@Id";
    public const string GetAllClasses = "SELECT * FROM Class";
    
    public const string InsertCourse = "INSERT INTO Courses (Id, Name, Description, Cover, CreatedAt) VALUES (@Id, @Name, @Description, @Cover, @CreatedAt)";
    public const string UpdateCourse = "UPDATE Courses SET Name = @Name, Description = @Description, Cover = @Cover WHERE Id = @Id";
    public const string DeleteCourse = "DELETE FROM Courses WHERE Id = @Id";
    public const string GetCourse = "SELECT * FROM Courses WHERE Id = @Id";
    public const string GetAllCourse = "SELECT * FROM Courses";
}