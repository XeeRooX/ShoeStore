using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Validators.ShoesTypeValidators
{
    public class GetShoesTypeValidator : AbstractValidator<GetShoesTypeInDto>
    {
        public GetShoesTypeValidator(IShoeTypeRepository shoesTypeRepository)
        {
            RuleFor(c => c.Id).Must(id => shoesTypeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddShoesTypeValidator : AbstractValidator<AddShoesTypeDto>
    {
        public AddShoesTypeValidator(IShoeTypeRepository shoesTypeRepository)
        {
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c.Name).Must(n => shoesTypeRepository.IsUniqueName(n)).WithMessage("элемент с таким именем уже существует");
        }
    }

    public class EditShoesTypeValidator : AbstractValidator<EditShoesTypeDto>
    {
        public EditShoesTypeValidator(IShoeTypeRepository shoesTypeRepository)
        {
            RuleFor(c => c.Id).Must(id => shoesTypeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c).Must(c => shoesTypeRepository.IsUniqueNameById(c.Name, c.Id)).WithMessage("элемент с таким именем уже существует");
        }
    }
}
