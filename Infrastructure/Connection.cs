using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure;
public class Connection : DbContext
{
    public DbSet<Domain.Entitie.Actor> Atores { get; set; }
    public DbSet<Domain.Entitie.Director> Diretores { get; set; }
    public DbSet<Domain.Entitie.WhatchFrom> OndeAssistir { get; set; }
    public DbSet<Domain.Entitie.Film> Filmes { get; set; }
    public DbSet<Domain.Entitie.Category> Categorias { get; set; }
    public DbSet<Domain.Entitie.CategoryFilm> CategoriasFilmes { get; set; }
    public DbSet<Domain.Entitie.FilmActor> FilmesAtores { get; set; }

    private readonly IConfiguration configuration;
    public Connection(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {        
        optionsBuilder.UseMySql(configuration.GetConnectionString("MySql"), new MySqlServerVersion(new Version(8, 0, 11)));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Domain.Entitie.Actor>(entity =>
        {
            entity.ToTable("ator");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(45);

            entity.Property(e => e.DataNascimento)
                .HasColumnName("dataNasc")
                .IsRequired()
                .HasColumnType("DATE");

            entity.Property(e => e.TotalIndicacoes)
                .HasColumnName("totindi")
                .IsRequired();
        });

        modelBuilder.Entity<Domain.Entitie.Director>(entity =>
        {
            entity.ToTable("diretor");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(45);

            entity.Property(e => e.DataNascimento)
                .HasColumnName("dataNasc")
                .IsRequired()
                .HasColumnType("DATE");

            entity.Property(e => e.TotalIndicacoes)
                .HasColumnName("totindi")
                .IsRequired();
        });

        modelBuilder.Entity<Domain.Entitie.WhatchFrom>(entity =>
        {
            entity.ToTable("ondeAssistir");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(45);

            entity.Property(e => e.URL)
                .IsRequired()
                .HasMaxLength(45);

            entity.Property(e => e.Plataforma)
                .IsRequired()
            .HasMaxLength(45);
        });

        modelBuilder.Entity<Domain.Entitie.Film>(entity =>
        {
            entity.ToTable("filme");

            entity.HasKey(e => new { e.Id });

            entity.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(45);

            entity.Property(e => e.TotalIndicacoes)
                .IsRequired();

            entity.HasOne(e => e.OndeAssistir)
                .WithMany()
                .HasForeignKey(e => e.OndeAssistirId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_filme_ondeAssistir");

            entity.HasOne(e => e.Diretor)
                .WithMany()
                .HasForeignKey(e => e.DiretorId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_filme_diretor1");
        });

        modelBuilder.Entity<Domain.Entitie.Category>(entity =>
        {
            entity.ToTable("categoria");

            entity.HasKey(e => e.Id);

            entity.Property(e => e.Descricao)
                .IsRequired()
                .HasMaxLength(45);
        });

        modelBuilder.Entity<Domain.Entitie.CategoryFilm>(entity =>
        {
            entity.ToTable("categoria_has_filme");

            entity.HasKey(e => new { e.CategoriaId, e.FilmeId });

            entity.HasOne(e => e.Categoria)
                .WithMany()
                .HasForeignKey(e => e.CategoriaId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_categoria_has_filme_categoria1");

            entity.HasOne(e => e.Filme)
                .WithMany()
                .HasForeignKey(e => new { e.FilmeId }) // Utilize as colunas corretas da chave estrangeira
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_categoria_has_filme_filme1");
        });

        //modelBuilder.Entity<Domain.Entitie.CategoryFilm>(entity =>
        //{
        //    entity.ToTable("categoria_has_filme");

        //    entity.HasKey(e => new { e.CategoriaId, e.FilmeId });

        //    entity.HasOne(e => e.Categoria)
        //        .WithMany()
        //        .HasForeignKey(e => e.CategoriaId)
        //        .OnDelete(DeleteBehavior.NoAction)
        //        .HasConstraintName("fk_categoria_has_filme_categoria1");

        //    entity.HasOne(e => e.Filme)
        //        .WithMany()
        //        .HasForeignKey(e => e.FilmeId)
        //        .OnDelete(DeleteBehavior.NoAction)
        //        .HasConstraintName("fk_categoria_has_filme_filme1");
        //});

        modelBuilder.Entity<Domain.Entitie.FilmActor>(entity =>
        {
            entity.ToTable("filme_has_ator");

            entity.HasKey(e => new { e.FilmeId, e.AtorId });

            entity.HasOne(e => e.Filme)
                .WithMany()
                .HasForeignKey(e => e.FilmeId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_filme_has_ator_filme1");

            entity.HasOne(e => e.Ator)
                .WithMany()
                .HasForeignKey(e => e.AtorId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("fk_filme_has_ator_ator1");
        });
    }
}
