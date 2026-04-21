namespace EducationalPlatform.Services.CatalogService.Api.Payloads;

public record UpdateCourseUseCaseModelPayload
{
    public string Name { get; init; } =  null!;
    public string Description { get; init; } = null!;
    public string Cover { get; init; } = null!;
    
    public UpdateCourseUseCaseModel AsModel(Guid id)
        => new()
        {
            Id = id,
            Name = Name,
            Description = Description,
            Cover = Cover
        };
}