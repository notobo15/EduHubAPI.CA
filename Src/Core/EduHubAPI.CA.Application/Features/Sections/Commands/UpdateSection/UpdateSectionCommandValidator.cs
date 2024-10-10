using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Sections.Commands.UpdateSection
{
    public class UpdateSectionCommandValidator : AbstractValidator<UpdateSectionCommand>
    {
        public UpdateSectionCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Title)
                .NotNull()
                .WithName(p => translator[nameof(p.Title)]);
        }
    }
}