namespace EducationalPlatform.Services.CatalogService.Api.Payloads;

public record UpdateClassUseCaseModelPayload
{
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string VideoLink { get; init; } = null!;
    public int Duration { get; init; }

    public UpdateClassUseCaseModel AsModel(Guid classId)
        => new()
        {
            ClassId = classId,
            Name = Name,
            Description = Description,
            VideoLink = VideoLink,
            Duration = Duration
        };
}