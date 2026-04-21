namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.CreateClass;

public record CreateClassUseCaseModel
{
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string VideoLink { get; init; } = null!;
    public int Duration { get; init; }
}

public class CreateClassUseCaseModelValidator : AbstractValidator<CreateClassUseCaseModel>
{
    public CreateClassUseCaseModelValidator()
    {
        RuleFor(model => model.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateClassUseCaseModel.Name)))
            .MaximumLength(Class.MaxNameLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(CreateClassUseCaseModel.Name), Class.MaxNameLength));

        RuleFor(model => model.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateClassUseCaseModel.Description)))
            .MaximumLength(Class.MaxDescriptionLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(CreateClassUseCaseModel.Description), Class.MaxDescriptionLength));

        RuleFor(model => model.VideoLink)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateClassUseCaseModel.VideoLink)));

        RuleFor(model => model.Duration)
            .GreaterThan(0)
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateClassUseCaseModel.Duration)));
    }
}