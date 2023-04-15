using Domain.Actor.GET;
using Domain.Actor.GET.Entities;
using MediatR;

namespace Application.Actor;
public class GetActorCommand : IRequest<GetActorResponse>
{
    public string Name { get; set; }
}

public class GetActorCommandHandler : IRequestHandler<GetActorCommand, GetActorResponse>
{
    private readonly IGetActorService _service;

    public GetActorCommandHandler(IGetActorService service)
    {
        _service = service;
    }

    public Task<GetActorResponse> Handle(GetActorCommand command, CancellationToken cancellationToken)
    {
        var request = new GetActorRequest { Name = command.Name };

        return _service.GetActor(request);
    }
}