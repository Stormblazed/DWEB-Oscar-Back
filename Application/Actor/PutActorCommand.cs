using Domain.Actor.PUT;
using Domain.Actor.PUT.Entities;
using MediatR;

namespace Application.Actor;
public class PutActorCommand : IRequest<PutActorResponse>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}

public class PutActorCommandHandler : IRequestHandler<PutActorCommand, PutActorResponse>
{
    private readonly IPutActorService _service;

    public PutActorCommandHandler(IPutActorService service) 
    {
        _service = service;
    }

    public Task<PutActorResponse> Handle(PutActorCommand command, CancellationToken cancellationToken)
    {
        var request = new PutActorRequest
        {
            Codigo = command.Codigo,
            Nome = command.Nome,
            DataNascimento = command.DataNascimento,
            TotalIndicacoes = command.TotalIndicacoes,
        };

        return _service.PutActor(request);
    }
}