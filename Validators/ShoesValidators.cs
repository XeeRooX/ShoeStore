using FluentValidation;
using ShoeStore.Data.Repositories;
using ShoeStore.Dtos.Shoe;

namespace ShoeStore.Validators.ShoesValidators
{
    public class GetShoesValidator : AbstractValidator<GetShoesDto>
    {
        public GetShoesValidator(IShoeRepository shoeRepository)
        {
            RuleFor(s => s.Id).Must(id => shoeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует") ;
        }
    }

    public class AddShoesValidator : AbstractValidator<AddShoesDto>
    {
        public AddShoesValidator(ISizeRepository sizeRepository, IShoeTypeRepository shoeTypeRepository, 
            IModelRepository modelRepository, ICollectionTypeRepository collectionTypeRepository, 
            IColorRepository colorRepository, ISeasonRepository seasonRepository)
        {
            RuleFor(s => s.Price).GreaterThan(0).WithMessage("значение должно быть больше чем 0");
            RuleFor(s => s.SizeId).Must(id => sizeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ShoeTypeId).Must(id => shoeTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ModelId).Must(id => modelRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.CollectionTypeId).Must(id => collectionTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ColorId).Must(id => colorRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.SeasonId).Must(id => seasonRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
        }
    }

    public class EditShoesValidator : AbstractValidator<EditShoesDto>
    {
        public EditShoesValidator(ISizeRepository sizeRepository, IShoeTypeRepository shoeTypeRepository,
            IModelRepository modelRepository, ICollectionTypeRepository collectionTypeRepository,
            IColorRepository colorRepository, ISeasonRepository seasonRepository, IShoeRepository shoeRepository)
        {
            RuleFor(s => s.Price).GreaterThan(0).WithMessage("значение должно быть больше чем 0");
            RuleFor(s => s.Id).Must(id => shoeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.SizeId).Must(id => sizeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ShoeTypeId).Must(id => shoeTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ModelId).Must(id => modelRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.CollectionTypeId).Must(id => collectionTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.ColorId).Must(id => colorRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
            RuleFor(s => s.SeasonId).Must(id => seasonRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует");
        }
    }

    public class FilterShoesValidator : AbstractValidator<FilterShoesDto>
    {
        public FilterShoesValidator(ISizeRepository sizeRepository, IShoeTypeRepository shoeTypeRepository,
            ICollectionTypeRepository collectionTypeRepository, IBrandRepository brandRepository,
            IColorRepository colorRepository, ISeasonRepository seasonRepository, IShoeRepository shoeRepository)
        {
            RuleFor(s => s.PriceFrom).Must(pf => pf >= 0).WithMessage("значение должно быть больше, либо равно 0");
            RuleFor(s => s.PriceTo).Must(pf => pf <= 0).WithMessage("значение должно быть меньше, либо равно 0");
            RuleFor(s => s.Page).GreaterThan(0).WithMessage("значение должно быть больше чем 0");
            RuleFor(s => s.Count).GreaterThan(0).WithMessage("значение должно быть больше чем 0");

            When(s => s.SizeId != 0, 
                () => RuleFor(s => s.SizeId).Must(id => sizeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
            When(s => s.ShoeTypeId != 0,
                () => RuleFor(s => s.ShoeTypeId).Must(id => shoeTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
            When(s => s.BrandId != 0,
                () => RuleFor(s => s.BrandId).Must(id => brandRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
            When(s => s.CollectionTypeId != 0,
                () => RuleFor(s => s.CollectionTypeId).Must(id => collectionTypeRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
            When(s => s.ColorId != 0,
                () => RuleFor(s => s.ColorId).Must(id => colorRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
            When(s => s.SeasonId != 0,
                () => RuleFor(s => s.SeasonId).Must(id => seasonRepository.IsExistsById(id)).WithMessage("элемента с таким Id не существует"));
        }
    }
}
