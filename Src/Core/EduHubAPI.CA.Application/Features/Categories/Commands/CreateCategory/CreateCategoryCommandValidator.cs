using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Name)
                .NotNull()
                .WithName(p => translator[nameof(p.Name)]);
        }
    }
}