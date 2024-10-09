using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Categories.Commands.UpdateCategory
{
    public class UpdateCategoryCommandValidator : AbstractValidator<UpdateCategoryCommand>
    {
        public UpdateCategoryCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Name)
                .NotNull()
                .WithName(p => translator[nameof(p.Name)]);
        }
    }
}