using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.Director.GET.Entities;
using Domain.WhatchFrom.GET.Entities;

namespace Domain.Film.POST.Entities;
public class PostFilmRequest
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public GetWhatchFromResponse WhatchFromResponse { get; set; }
    public GetCategoryResponse GetCategoryResponse { get; set; }
    public GetDirectorResponse GetDirectorResponse { get; set; }
    public GetActorResponse GetActorResponse { get; set; }

}
