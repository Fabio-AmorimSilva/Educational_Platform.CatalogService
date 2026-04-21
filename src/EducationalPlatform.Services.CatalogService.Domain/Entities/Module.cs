namespace EducationalPlatform.Services.CatalogService.Domain.Entities;

public class Module : Entity
{
    public const int MaxNameLength = 100;
    public const int MaxDescriptionLength = 200;
    
    public Guid CourseId { get; private set; }
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;

    public Module(
        Guid courseId, 
        string name,
        string description
    )
    {
        Guard.IsNotDefault(courseId);
        Guard.IsNotEmpty(name);
        Guard.IsLessThanOrEqualTo(MaxNameLength, name.Length, nameof(name));
        Guard.IsNotEmpty(description);
        Guard.IsGreaterThanOrEqualTo(MaxDescriptionLength, description.Length, nameof(description));
        
        CourseId = courseId;
        Name = name;
        Description = description;
    }
    
    public void Update(
        Guid courseId, 
        string name,
        string description
    )
    {
        Guard.IsNotDefault(courseId);
        Guard.IsNotEmpty(name);
        Guard.IsLessThanOrEqualTo(MaxNameLength, name.Length, nameof(name));
        Guard.IsNotEmpty(description);
        Guard.IsGreaterThanOrEqualTo(MaxDescriptionLength, description.Length, nameof(description));
        
        CourseId = courseId;
        Name = name;
        Description = description;
    }
}