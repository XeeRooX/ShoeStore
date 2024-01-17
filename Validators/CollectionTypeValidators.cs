using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.CollectionType;

namespace ShoeStore.Validators.CollectionTypeValidators
{
    public class CollectionTypeValidators
    {
        public class GetCollectionTypeValidator : AbstractValidator<GetCollectionTypeInDto>
        {
            public GetCollectionTypeValidator(ICollectionTypeRepository collectionTypeRepository)
            {
                RuleFor(c => c.Id).Must(id => collectionTypeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
            }
        }

        public class AddCollectionTypeValidator : AbstractValidator<AddCollectionTypeDto>
        {
            public AddCollectionTypeValidator(ICollectionTypeRepository collectionTypeRepository)
            {
                RuleFor(c => c.Name).Length(2, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
                RuleFor(c => c.ShortName).Length(1, 30).WithMessage("краткое имя должно иметь от {MinLength} до {MaxLength} символов");
                RuleFor(c => c).Must(n => collectionTypeRepository.IsUniqueName(n.Name, n.ShortName)).WithMessage("элемент с таким именем уже существует");
            }
        }

        public class EditCollectionTypeValidator : AbstractValidator<EditCollectionTypeDto>
        {
            public EditCollectionTypeValidator(ICollectionTypeRepository collectionTypeRepository)
            {
                RuleFor(c => c.Id).Must(id => collectionTypeRepository.IsExistsById(id)).WithMessage("элемента с таким id не существует");
                RuleFor(c => c.Name).Length(2, 100).WithMessage("имя должно иметь от {MinLength} до {MaxLength} символов");
                RuleFor(c => c.ShortName).Length(1, 30).WithMessage("краткое имя должно иметь от {MinLength} до {MaxLength} символов");
                RuleFor(c => c).Must(c => collectionTypeRepository.IsUniqueNameById(c.Name, c.ShortName, c.Id)).WithMessage("элемент с таким именем уже существует");
            }
        }
    }
}
