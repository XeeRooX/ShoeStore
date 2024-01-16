using MediatR;
using ShoeStore.Dtos.Color;

namespace ShoeStore.Queries.Colors
{
    public record class GetColorQuery(GetColorInDto color) : IRequest<GetColorOutDto>;
}
