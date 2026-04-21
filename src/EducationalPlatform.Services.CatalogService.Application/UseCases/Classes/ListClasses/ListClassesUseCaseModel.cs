namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.ListClasses;

public record ListClassesUseCaseModel
{
    public Guid ClassId { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string VideoLink { get; init; } = null!;
    public int Duration { get; init; }
}