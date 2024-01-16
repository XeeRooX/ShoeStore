using MediatR;
using ShoeStore.Dtos.ShoesType;

namespace ShoeStore.Queries.ShoesType
{
    public record class GetShoesTypeQuery(GetShoesTypeInDto ShoeType) : IRequest<GetShoesTypeOutDto>;
}
