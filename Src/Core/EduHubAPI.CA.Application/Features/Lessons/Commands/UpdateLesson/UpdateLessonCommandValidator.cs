using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.UpdateLesson
{
    public class UpdateLessonCommandValidator : AbstractValidator<UpdateLessonCommand>
    {
        public UpdateLessonCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Title)
                .NotNull()
                .WithName(p => translator[nameof(p.Title)]);
        }
    }
}