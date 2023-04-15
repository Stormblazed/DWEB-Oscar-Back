using Domain.Actor.DELETE;
using Domain.Actor.DELETE.Entities;
using MediatR;

namespace Application.Actor;
public class DeleteActorCommand : IRequest<DeleteActorResponse>
{
    public int Codigo { get; set; }
}

public class DeleteActorCommandHandler : IRequestHandler<DeleteActorCommand, DeleteActorResponse>
{
    private readonly IDeleteActorService _service;

    public DeleteActorCommandHandler(IDeleteActorService service)
    {
        _service = service;
    }

    public Task<DeleteActorResponse> Handle(DeleteActorCommand command, CancellationToken cancellationToken)
    {
        var request = new DeleteActorRequest
        {
            Codigo = command.Codigo,
        };

        return _service.DeleteActor(request);
    }
}
