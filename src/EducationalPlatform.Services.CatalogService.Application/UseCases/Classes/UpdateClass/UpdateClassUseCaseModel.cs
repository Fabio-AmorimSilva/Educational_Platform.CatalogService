namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Classes.UpdateClass;

public record UpdateClassUseCaseModel
{
    public Guid ClassId { get; init; }   
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string VideoLink { get; init; } = null!;
    public int Duration { get; init; }
}

public class UpdateClassUseCaseModelValidator : AbstractValidator<UpdateClassUseCaseModel>
{
    public UpdateClassUseCaseModelValidator()
    {
        RuleFor(model => model.ClassId)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateClassUseCaseModel.ClassId)));
        
        RuleFor(model => model.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateClassUseCaseModel.Name)))
            .MaximumLength(Class.MaxNameLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(UpdateClassUseCaseModel.Name), Class.MaxNameLength));

        RuleFor(model => model.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateClassUseCaseModel.Description)))
            .MaximumLength(Class.MaxDescriptionLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(UpdateClassUseCaseModel.Description), Class.MaxDescriptionLength));

        RuleFor(model => model.VideoLink)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateClassUseCaseModel.VideoLink)));

        RuleFor(model => model.Duration)
            .GreaterThan(0)
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateClassUseCaseModel.Duration)));
    }
}