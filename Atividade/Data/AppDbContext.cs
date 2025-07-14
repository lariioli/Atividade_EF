using Microsoft.EntityFrameworkCore;

namespace Atividade.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    public DbSet<Aluno> Alunos { get; set; } = null!;
}
public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string Sobrenome { get; set; } = null!;
    public string Telefone { get; set; }  = null!;
    public string Email { get; set; } = null!;
}