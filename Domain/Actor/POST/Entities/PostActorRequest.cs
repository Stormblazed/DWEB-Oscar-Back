namespace Domain.Actor.POST.Entities;
public class PostActorRequest
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}
