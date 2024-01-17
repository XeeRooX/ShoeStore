using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Brand;

namespace ShoeStore.Validators.BrandValidators
{
    public class GetBrandValidator : AbstractValidator<GetBrandInDto>
    {
        public GetBrandValidator(IBrandRepository brandRepository)
        {
            RuleFor(c => c.Id).Must(id => brandRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddBrandValidator : AbstractValidator<AddBrandDto>
    {
        public AddBrandValidator(IBrandRepository brandRepository)
        {
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c.Name).Must(n => brandRepository.IsUniqueName(n)).WithMessage("элемент с таким именем уже существует");
        }
    }

    public class EditBrandValidator : AbstractValidator<EditBrandDto>
    {
        public EditBrandValidator(IBrandRepository brandRepository)
        {
            RuleFor(c => c.Id).Must(id => brandRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c).Must(c => brandRepository.IsUniqueNameById(c.Name, c.Id)).WithMessage("элемент с таким именем уже существует");
        }
    }
}
