namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.GetClass;

public record GetClassUseCaseModel
{
    public Guid ClassId { get; init; }
    public string Name { get; init; } 
    public string Description { get; init; } 
    public string VideoLink { get; init; }
    public int Duration { get; init; }
}