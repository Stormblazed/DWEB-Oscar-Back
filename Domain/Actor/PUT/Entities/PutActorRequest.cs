namespace Domain.Actor.PUT.Entities;
public class PutActorRequest
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}
