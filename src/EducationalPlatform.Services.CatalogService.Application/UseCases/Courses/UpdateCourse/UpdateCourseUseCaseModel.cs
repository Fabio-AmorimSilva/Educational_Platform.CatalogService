namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.UpdateCourse;

public record UpdateCourseUseCaseModel
{
    public Guid Id { get; set; }
    public string Name { get; init; } = null!;
    public string Description { get; init; } = null!;
    public string Cover { get; init; } = null!;
}

public class UpdateCourseUseCaseModelValidator : AbstractValidator<UpdateCourseUseCaseModel>
{
    public UpdateCourseUseCaseModelValidator()
    {
        RuleFor(c => c.Id)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateCourseUseCaseModel.Id)));

        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateCourseUseCaseModel.Name)))
            .MaximumLength(Course.NameMaxLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(UpdateCourseUseCaseModel.Name), Course.NameMaxLength));

        RuleFor(c => c.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateCourseUseCaseModel.Description)))
            .MaximumLength(Course.DescriptionMaxLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(UpdateCourseUseCaseModel.Description), Course.DescriptionMaxLength));

        RuleFor(c => c.Cover)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(UpdateCourseUseCaseModel.Cover)));
    }
}