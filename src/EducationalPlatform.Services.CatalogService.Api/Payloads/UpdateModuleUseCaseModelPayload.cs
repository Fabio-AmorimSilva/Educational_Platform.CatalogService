namespace EducationalPlatform.Services.CatalogService.Api.Payloads;

public record UpdateModuleUseCaseModelPayload
{
    public Guid CourseId { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;

    public UpdateModuleUseCaseModel AsModel(Guid modelId)
        => new()
        {
            Id = modelId,
            CourseId = CourseId,
            Name = Name,
            Description = Description
        };
}