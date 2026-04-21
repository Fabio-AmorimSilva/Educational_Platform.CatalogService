namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.GetModule;

public record GetModuleUseCaseModel
{
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
}