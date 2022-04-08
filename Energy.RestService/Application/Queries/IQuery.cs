using MediatR;

namespace Energy.RestService.Application.Queries
{
    public interface IQuery<TResponse> : IRequest<TResponse> { }
}
