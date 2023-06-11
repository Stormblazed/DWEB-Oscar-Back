using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitie;
public class CategoryFilm
{
    public int CategoriaId { get; set; }
    public int FilmeId { get; set; }

    public Category Categoria { get; set; }
    public Film Filme { get; set; }
}