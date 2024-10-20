using EduHubAPI.CA.Application.Interfaces;
using FluentValidation;

namespace EduHubAPI.CA.Application.Features.Lessons.Commands.CreateLesson
{
    public class CreateLessonCommandValidator : AbstractValidator<CreateLessonCommand>
    {
        public CreateLessonCommandValidator(ITranslator translator)
        {
            RuleFor(p => p.Title)
                .NotNull()
                .WithName(p => translator[nameof(p.Title)]);
        }
    }
}