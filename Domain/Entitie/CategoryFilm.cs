using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitie;
public class CategoryFilm
{
    public int id { get; set; }
    public int categoria_id { get; set; }
    public int filme_id { get; set; }

    public Category Categoria { get; set; }
    public Film Filme { get; set; }
}