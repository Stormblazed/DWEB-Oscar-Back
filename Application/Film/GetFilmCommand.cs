using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.GET;
using Domain.Film.GET.Entities;
using Domain.WhatchFrom.GET.Entities;
using MediatR;

namespace Application.Film;
public class GetFilmCommand : IRequest<GetFilmResponse>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public GetWhatchFromResponse WhatchFromResponse { get; set; }
    public GetCategoryResponse GetCategoryResponse { get; set; }
    public GetDirectorResponse GetDirectorResponse { get; set; }
    public GetActorResponse GetActorResponse { get; set; }

}

public class GetFilmCommandHandle : IRequestHandler<GetFilmCommand, GetFilmResponse>
{
    private readonly IGetFilmService _service;

    public GetFilmCommandHandle(IGetFilmService service)
    {
        _service = service;
    }

    public Task<GetFilmResponse> Handle(GetFilmCommand command, CancellationToken cancellationToken)
    {
        var response = new GetFilmRequest()
        {
            Codigo = command.Codigo,
            Nome = command.Nome,
            TotalIndicacoes = command.TotalIndicacoes,
            GetActorResponse = command.GetActorResponse,
            GetDirectorResponse = command.GetDirectorResponse,
            GetCategoryResponse = command.GetCategoryResponse,
            WhatchFromResponse = command.WhatchFromResponse
        };

        return _service.GetFilmResponse(response);  

    }
}
