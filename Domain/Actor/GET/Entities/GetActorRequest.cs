namespace Domain.Actor.GET.Entities;
public class GetActorRequest
{
    public int Codigo { get; set; }
    public string? Name { get; set; }    
    public DateTime? DataNascimento { get; set; }
    public int? TotalIndicacoes { get; set; }
}
