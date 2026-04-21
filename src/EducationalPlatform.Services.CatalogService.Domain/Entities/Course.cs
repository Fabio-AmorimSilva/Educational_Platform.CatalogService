namespace EducationalPlatform.Services.CatalogService.Domain.Entities;

public class Course : Entity
{
    public const int NameMaxLength = 100;
    public const int DescriptionMaxLength = 200;
    
    public string Name { get; private set; } =  null!;
    public string Description { get; private set; } = null!;
    public string Cover { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; }

    public Course(
        string name,
        string description,
        string cover 
    )
    {
        Guard.IsNotEmpty(name);
        Guard.IsLessThanOrEqualTo(name.Length, NameMaxLength, nameof(name));
        Guard.IsNotEmpty(description);
        Guard.IsLessThanOrEqualTo(description.Length, DescriptionMaxLength, nameof(description));
        Guard.IsNotEmpty(cover);
        
        Name = name;
        Description = description;
        Cover = cover;
        CreatedAt = DateTime.UtcNow;
    }
    
    public void Update(
        string name,
        string description,
        string cover 
    )
    {
        Guard.IsNotEmpty(name);
        Guard.IsLessThanOrEqualTo(name.Length, NameMaxLength, nameof(name));
        Guard.IsNotEmpty(description);
        Guard.IsLessThanOrEqualTo(description.Length, DescriptionMaxLength, nameof(description));
        Guard.IsNotEmpty(cover);
        
        Name = name;
        Description = description;
        Cover = cover;
    }
}