using Domain.WhatchFrom.PUT;
using Domain.WhatchFrom.PUT.Entities;
using MediatR;

namespace Application.WhatchFrom;
public class PutWhatchFromCommand : IRequest<PutWhatchFromResponse>
{
    public int codigo { get; set; }
    public string nome { get; set; }
    public string url { get; set; }
    public string plataforma { get; set; }
}

public class PutWhatchFromCommandHandle : IRequestHandler<PutWhatchFromCommand, PutWhatchFromResponse>
{
    private readonly IPutWhatchFromService _service;

    public PutWhatchFromCommandHandle(IPutWhatchFromService service)
    {
        _service = service;
    }

    public Task<PutWhatchFromResponse> Handle(PutWhatchFromCommand command, CancellationToken cancellationToken)
    {
        var request = new PutWhatchFromRequest() { codigo = command.codigo, nome = command.nome, url = command.url , Plataforma  = command.plataforma };

        return _service.PutWhatchFrom(request);
    }
}
