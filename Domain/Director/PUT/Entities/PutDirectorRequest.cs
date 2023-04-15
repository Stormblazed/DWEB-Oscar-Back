namespace Domain.Director.PUT.Entities;
public class PutDirectorRequest
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public int TotalIndicacoes { get; set; }
}
