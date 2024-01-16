using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Season;

namespace ShoeStore.Validators.SeasonValidators
{
    public class GetSeasonValidator : AbstractValidator<GetSeasonInDto>
    {
        public GetSeasonValidator(ISeasonRepository seasonRepository)
        {
            RuleFor(c => c.Id).Must(id => seasonRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddSeasonValidator : AbstractValidator<AddSeasonDto>
    {
        public AddSeasonValidator(ISeasonRepository seasonRepository)
        {
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c.Name).Must(n => seasonRepository.IsUniqueName(n)).WithMessage("элемент с таким именем уже существует");
        }
    }

    public class EditSeasonValidator : AbstractValidator<EditSeasonDto>
    {
        public EditSeasonValidator(ISeasonRepository seasonRepository)
        {
            RuleFor(c => c.Id).Must(id => seasonRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c).Must(c => seasonRepository.IsUniqueNameById(c.Name, c.Id)).WithMessage("элемент с таким именем уже существует");
        }
    }
}
