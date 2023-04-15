namespace Domain.Actor.GET.Entities;
public class GetActorResponse
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}