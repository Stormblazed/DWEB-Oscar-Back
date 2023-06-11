using Domain.Actor.GET;
using Domain.Actor.GET.Entities;
using MediatR;

namespace Application.Actor;
public class GetActorCommand : IRequest<List<GetActorResponse>>
{
    public string Name { get; set; }
    public DateTime datnascimento { get; set; }
    public int id { get;set; }
    public int totalint { get;set; }
}

public class GetActorCommandHandler : IRequestHandler<GetActorCommand, List<GetActorResponse>>
{
    private readonly IGetActorService _service;

    public GetActorCommandHandler(IGetActorService service)
    {
        _service = service;
    }

    public Task<List<GetActorResponse>> Handle(GetActorCommand command, CancellationToken cancellationToken)
    {
        var request = new GetActorRequest { Name = command.Name , Codigo = command.id , DataNascimento = command.datnascimento , TotalIndicacoes = command.totalint};

        return _service.GetActor(request);
    }
}