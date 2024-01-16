using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Size;

namespace ShoeStore.Validators.SizeValidators
{
    public class GetSizeValidator : AbstractValidator<GetSizeInDto>
    {
        public GetSizeValidator(ISizeRepository sizeRepository)
        {
            RuleFor(c => c.Id).Must(id => sizeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddSizeValidator : AbstractValidator<AddSizeDto>
    {
        public AddSizeValidator(ISizeRepository sizeRepository)
        {
            RuleFor(c => c.Number).Must(n => n > 0 && n <= 100).WithMessage("значение должно быть от 1 до 100");
            RuleFor(c => c.Number).Must(n => sizeRepository.IsUniqueSize(n)).WithMessage("элемент с таким значением уже существует");
        }
    }

    public class EditSizeValidator : AbstractValidator<EditSizeDto>
    {
        public EditSizeValidator(ISizeRepository sizeRepository)
        {
            RuleFor(c => c.Id).Must(id => sizeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Number).Must(n => n > 0 && n <= 100).WithMessage("значение должно быть от 1 до 100");
            RuleFor(c => c).Must(c => sizeRepository.IsUniqueSizeById(c.Number, c.Id)).WithMessage("элемент с таким значением уже существует");
        }
    }
}
