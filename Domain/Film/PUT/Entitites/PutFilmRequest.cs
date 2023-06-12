using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.WhatchFrom.GET.Entities;

namespace Domain.Film.PUT.Entitites;
public class PutFilmRequest
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public int ondeAssistir_id { get; set; }
    public int diretor_id { get; set; }
    public int categoryId { get; set; }
    public int actorId { get; set; }

}
