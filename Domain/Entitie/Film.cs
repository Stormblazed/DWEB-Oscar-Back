namespace Domain.Entitie;
public class Film
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public int OndeAssistirId { get; set; }
    public int DiretorId { get; set; }

    public WhatchFrom OndeAssistir { get; set; }
    public Director Diretor { get; set; }
}
