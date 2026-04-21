namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Modules.UpdateModule;

public record UpdateModuleUseCaseModel
{
    public Guid Id { get; init; }
    public Guid CourseId { get; init; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
}

public class UpdateModuleUseCaseModelValidator : AbstractValidator<UpdateModuleUseCaseModel>
{
    public UpdateModuleUseCaseModelValidator()
    {
        RuleFor(m => m.Id)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateModuleUseCaseModel.Id)));

        RuleFor(m => m.CourseId)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateModuleUseCaseModel.CourseId)));

        RuleFor(m => m.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateModuleUseCaseModel.Name)))
            .MaximumLength(Module.MaxNameLength)
            .WithMessage(ErrorMessages.HasToBeGreaterThan(nameof(UpdateModuleUseCaseModel.Name), Module.MaxNameLength));

        RuleFor(m => m.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateModuleUseCaseModel.Description)))
            .MaximumLength(Module.MaxDescriptionLength)
            .WithMessage(ErrorMessages.HasToBeGreaterThan(nameof(UpdateModuleUseCaseModel.Description), Module.MaxDescriptionLength));
    }
}