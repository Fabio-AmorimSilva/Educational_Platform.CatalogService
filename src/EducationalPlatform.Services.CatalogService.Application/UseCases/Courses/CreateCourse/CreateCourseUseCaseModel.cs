namespace EducationalPlatform.Services.CatalogService.Application.UseCases.Courses.CreateCourse;

public record CreateCourseUseCaseModel
{
    public string Name { get; init; } =  null!;
    public string Description { get; init; } = null!;
    public string Cover { get; init; } = null!;
}

public class CreateCourseUseCaseModelValidator : AbstractValidator<CreateCourseUseCaseModel>
{
    public CreateCourseUseCaseModelValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateCourseUseCaseModel.Name)))
            .MaximumLength(Course.NameMaxLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(CreateCourseUseCaseModel.Name), Course.NameMaxLength));
        
        RuleFor(c => c.Description)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateCourseUseCaseModel.Description)))
            .MaximumLength(Course.DescriptionMaxLength)
            .WithMessage(ErrorMessages.HasMaxLength(nameof(CreateCourseUseCaseModel.Description), Course.DescriptionMaxLength));
        
        RuleFor(c => c.Cover)
            .NotEmpty()
            .WithMessage(ErrorMessages.CannotBeEmpty(nameof(CreateCourseUseCaseModel.Cover)));       
    }
}