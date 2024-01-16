using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Validators.ColorValidators
{
    public class GetColorValidator : AbstractValidator<GetColorInDto>
    {
        public GetColorValidator(IColorRepository colorRepository)
        {
            RuleFor(c => c.Id).Must(id => colorRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddColorValidator : AbstractValidator<AddColorDto>
    {
        public AddColorValidator(IColorRepository colorRepository)
        {
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c.Name).Must(n => colorRepository.IsUniqueName(n)).WithMessage("элемент с таким именем уже существует");
        }
    }

    public class EditColorValidator : AbstractValidator<EditColorDto>
    {
        public EditColorValidator(IColorRepository colorRepository)
        {
            RuleFor(c => c.Id).Must(id => colorRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c).Must(c => colorRepository.IsUniqueNameById(c.Name, c.Id)).WithMessage("элемент с таким именем уже существует");
        }
    }
}
