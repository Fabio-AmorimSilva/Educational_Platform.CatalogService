namespace EducationalPlatform.Services.CatalogService.Domain.Entities;

public class Class : Entity
{
    public const int MaxNameLength = 100;
    public const int MaxDescriptionLength = 100;
    public const int MinVideoLinkLength = 0;
    
    public string Name { get; private set; } 
    public string Description { get; private set; } 
    public string VideoLink { get; private set; }
    public int Duration { get; private set; }

    public Class()
    {
    }
    
    public Class(
        string name,
        string description,
        string videoLink,
        int duration
    )
    {
        Guard.IsNotNullOrEmpty(name);
        Guard.IsLessThanOrEqualTo(name.Length, MaxNameLength, nameof(name));
        Guard.IsNotNullOrEmpty(description);
        Guard.IsLessThanOrEqualTo(description.Length, MaxDescriptionLength, nameof(description));
        Guard.IsNotNullOrEmpty(videoLink);
        Guard.IsGreaterThan(duration, MinVideoLinkLength, nameof(videoLink));
        
        Name = name;
        Description = description;
        VideoLink = videoLink;
        Duration = duration;
    }
    
    public void Update(
        string name,
        string description,
        string videoLink,
        int duration
    )
    {
        Guard.IsNotNullOrEmpty(name);
        Guard.IsLessThanOrEqualTo(name.Length, MaxNameLength, nameof(name));
        Guard.IsNotNullOrEmpty(description);
        Guard.IsLessThanOrEqualTo(description.Length, MaxDescriptionLength, nameof(description));
        Guard.IsNotNullOrEmpty(videoLink);
        Guard.IsLessThan(duration, 0);
        
        Name = name;
        Description = description;
        VideoLink = videoLink;
        Duration = duration;
    }
}