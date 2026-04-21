namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.CreateModule;

public record CreateModuleUseCaseModel
{
    public Guid CourseId { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
}

public class CreateModuleUseCaseModelValidator : AbstractValidator<CreateModuleUseCaseModel>
{
    public CreateModuleUseCaseModelValidator()
    {
        RuleFor(m => m.CourseId)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateModuleUseCaseModel.CourseId)));
        
        RuleFor(m => m.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateModuleUseCaseModel.Name)))
            .MaximumLength(Module.MaxNameLength)
            .WithMessage(ErrorMessages.HasToBeGreaterThan(nameof(CreateModuleUseCaseModel.Name), Module.MaxNameLength));
        
        RuleFor(m => m.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateModuleUseCaseModel.Description)))
            .MaximumLength(Module.MaxDescriptionLength)
            .WithMessage(ErrorMessages.HasToBeGreaterThan(nameof(CreateModuleUseCaseModel.Description), Module.MaxDescriptionLength));
    }
}