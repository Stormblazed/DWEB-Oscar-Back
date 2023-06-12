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
    public int ondeAssistir_id { get; set; }
    public int diretor_id { get; set; }
    public int categoryId { get; set; }
    public int actorId { get; set; }
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
            TotalIndicacoes = command.TotalIndicacoes,
            ondeAssistir_id = command.ondeAssistir_id,
            diretor_id = command.diretor_id,
            categoryId = command.categoryId,
            actorId = command.actorId
        };

        return _service.PutFilmResponse(request);
    }
}
