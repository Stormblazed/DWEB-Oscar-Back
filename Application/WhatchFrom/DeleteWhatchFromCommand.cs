using Domain.WhatchFrom.DELETE;
using Domain.WhatchFrom.DELETE.Entities;
using MediatR;

namespace Application.WhatchFrom;
public class DeleteWhatchFromCommand : IRequest<DeleteWhatchFromResponse>
{
    public int Codigo { get; set; }
}

public class DeleteWhatchFromCommandHandle : IRequestHandler<DeleteWhatchFromCommand, DeleteWhatchFromResponse>
{
    private readonly IDeleteWhatchFromService _service;

    public DeleteWhatchFromCommandHandle(IDeleteWhatchFromService service)
    {
        _service = service;
    }

    public Task<DeleteWhatchFromResponse> Handle(DeleteWhatchFromCommand command, CancellationToken cancellationToken)
    {
        var request = new DeleteWhatchFromRequest() { Codigo = command.Codigo };
        return _service.DeleteWhatchFrom(request);
    }
}
