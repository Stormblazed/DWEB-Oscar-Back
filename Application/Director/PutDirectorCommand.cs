using Domain.Director.PUT;
using Domain.Director.PUT.Entities;
using MediatR;

namespace Application.Director;
public class PutDirectorCommand : IRequest<PutDirectorResponse>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }

}

public class PutDirectorCommandHandle : IRequestHandler<PutDirectorCommand,PutDirectorResponse>
{
    public IPutDirectorService _service;

    public PutDirectorCommandHandle(IPutDirectorService service)
    {
        _service = service;
    }

    public Task<PutDirectorResponse> Handle(PutDirectorCommand command, CancellationToken cancellationToken)
    {
        var request = new PutDirectorRequest() { Codigo = command.Codigo , DataNascimento = command.DataNascimento, Nome = command.Nome , TotalIndicacoes  = command .TotalIndicacoes };
            

        return _service.PutDirector(request);

    }
}

