namespace Domain.Entitie;
public class Film
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int TotalIndicacoes { get; set; }
    public int ondeAssistir_id { get; set; }
    public int diretor_id { get; set; }

    public WhatchFrom OndeAssistir { get; set; }
    public Director Diretor { get; set; }
}
