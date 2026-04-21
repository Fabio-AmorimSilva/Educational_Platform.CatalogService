namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.ListModules;

public record ListModulesUseCaseModel
{
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
}