using Domain.Actor.POST;
using Domain.Actor.POST.Entities;
using MediatR;

namespace Application.Actor;
public class PostActorCommand : IRequest<PostActorResponse>
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}

public class PostActorCommandHandler : IRequestHandler<PostActorCommand, PostActorResponse>
{
    private readonly IPostActorService _service;

    public PostActorCommandHandler(IPostActorService service)
    {
        _service = service;
    }

    public Task<PostActorResponse> Handle(PostActorCommand command, CancellationToken cancellationToken)
    {
        var request = new PostActorRequest { 
            Nome = command.Nome,
            DataNascimento = command.DataNascimento,
            TotalIndicacoes = command.TotalIndicacoes
        };

        return _service.PostActor(request);
    }
}