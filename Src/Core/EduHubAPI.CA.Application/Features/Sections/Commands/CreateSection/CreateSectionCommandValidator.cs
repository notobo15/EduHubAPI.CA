using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.CreateSection
{
    public class CreateSectionCommandValidator : AbstractValidator<CreateSectionCommand>
    {
        public CreateSectionCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Title)
                .NotNull()
                .WithName(p => translator[nameof(p.Title)]);
        }
    }
}