using Domain.Director.POST;
using Domain.Director.POST.Entities;
using MediatR;

namespace Application.Director;
public class PostDirectorCommand : IRequest<PostDirectorResponse>
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }    
}


public class PostDirectorCommandHandle : IRequestHandler<PostDirectorCommand,PostDirectorResponse>
{

    private readonly IPostDirectorService _service;

    public PostDirectorCommandHandle(IPostDirectorService service)
    {
        _service = service;
    }

    public async Task<PostDirectorResponse> Handle(PostDirectorCommand command, CancellationToken cancellationToken)
    {
        var request = new PostDirectorRequest() { Nome = command.Nome , DataNascimento = command.DataNascimento , TotalIndicacoes = command.TotalIndicacoes };

        return await _service.PostDirector(request);    

    }
}
