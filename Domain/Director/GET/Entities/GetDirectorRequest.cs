using Domain.Actor.GET.Entities;
using Domain.Category.GET.Entities;
using Domain.WhatchFrom.GET.Entities;

namespace Domain.Director.GET.Entities;
public class GetDirectorRequest
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
    public GetWhatchFromResponse WhatchFromResponse { get; set; }
    public GetCategoryResponse GetCategoryResponse { get; set; }
    public GetDirectorResponse GetDirectorResponse { get; set; }
    public GetActorResponse GetActorResponse { get; set; }
}
