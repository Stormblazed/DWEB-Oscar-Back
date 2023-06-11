using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitie;
public class FilmActor
{
    public int FilmeId { get; set; }
    public int AtorId { get; set; }

    public Film Filme { get; set; }
    public Actor Ator { get; set; }
}