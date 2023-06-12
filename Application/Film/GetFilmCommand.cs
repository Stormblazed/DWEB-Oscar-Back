using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.Film.GET;
using Domain.Film.GET.Entities;
using Domain.WhatchFrom.GET.Entities;
using MediatR;

namespace Application.Film;
public class GetFilmCommand : IRequest<List<GetFilmResponse>>
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public int ondeAssistir_id { get; set; }
    public int diretor_id { get; set; }  

}

public class GetFilmCommandHandle : IRequestHandler<GetFilmCommand, List<GetFilmResponse>>
{
    private readonly IGetFilmService _service;

    public GetFilmCommandHandle(IGetFilmService service)
    {
        _service = service;
    }

    public Task<List<GetFilmResponse>> Handle(GetFilmCommand command, CancellationToken cancellationToken)
    {
        var response = new GetFilmRequest()
        {
            Codigo = command.Codigo,
            Nome = command.Nome,
            TotalIndicacoes = command.TotalIndicacoes,
            ondeAssistir_id = command.ondeAssistir_id,
            diretor_id = command.diretor_id
          
        };

        return _service.GetFilmResponse(response);  

    }
}
