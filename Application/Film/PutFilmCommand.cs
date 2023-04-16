using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.PUT;
using Domain.Film.PUT.Entitites;
using Domain.WhatchFrom.GET.Entities;
using MediatR;

namespace Application.Film;
public class PutFilmCommand : IRequest<PutFilmResponse>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public GetWhatchFromResponse WhatchFromResponse { get; set; }
    public GetCategoryResponse GetCategoryResponse { get; set; }
    public GetDirectorResponse GetDirectorResponse { get; set; }
    public GetActorResponse GetActorResponse { get; set; }
}

public class PutFilmCommandHandle : IRequestHandler<PutFilmCommand, PutFilmResponse>
{
    private readonly IPutFilmService _service;

    public PutFilmCommandHandle(IPutFilmService service)
    {
        _service = service;
    }

    public Task<PutFilmResponse> Handle(PutFilmCommand command, CancellationToken cancellationToken)
    {
        var request = new PutFilmRequest() 
        { 
            Codigo = command.Codigo,
            Nome = command.Nome, 
            GetActorResponse = command.GetActorResponse ,
            GetCategoryResponse = command.GetCategoryResponse,
            GetDirectorResponse = command.GetDirectorResponse ,
            TotalIndicacoes = command.TotalIndicacoes , 
            WhatchFromResponse = command.WhatchFromResponse 
        };

        return _service.PutFilmResponse(request);
    }
}
