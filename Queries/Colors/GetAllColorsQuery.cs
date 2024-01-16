using MediatR;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Queries.Colors
{
    public record class GetAllColorsQuery() : IRequest<IEnumerable<GetColorOutDto>>;
}
