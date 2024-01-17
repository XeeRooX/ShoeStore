using FluentValidation;
using ShoeStore.Data.EFCore;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Model;

namespace ShoeStore.Validators.ModelValidators
{
    public class GetModelValidator : AbstractValidator<GetModelInDto>
    {
        public GetModelValidator(IModelRepository modelRepository)
        {
            RuleFor(c => c.Id).Must(id => modelRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
        }
    }

    public class AddModelValidator : AbstractValidator<AddModelDto>
    {
        public AddModelValidator(IModelRepository modelRepository, IBrandRepository brandRepository)
        {
            RuleFor(c => c.BrandId).Must(id => brandRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c.Name).Must(n => modelRepository.IsUniqueName(n)).WithMessage("элемент с таким именем уже существует");
        }
    }

    public class EditModelValidator : AbstractValidator<EditModelDto>
    {
        public EditModelValidator(IModelRepository modelRepository, IBrandRepository brandRepository)
        {
            RuleFor(c => c.Id).Must(id => modelRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.BrandId).Must(id => brandRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            RuleFor(c => c.Name).Length(1, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
            RuleFor(c => c).Must(c => modelRepository.IsUniqueNameById(c.Name, c.Id)).WithMessage("элемент с таким именем уже существует");
        }
    }
}
