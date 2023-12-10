using Controle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Controle.Infrastructure.Context;

public class ControleContext : DbContext
{
    public ControleContext(DbContextOptions<ControleContext> options): base(options){}
    public DbSet<Person> People { get; set; }
    public DbSet<Salary> Salaries { get; set; }
    public DbSet<Investments> Investments { get; set; }
    public DbSet<FixedExpenses> FixedExpenses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ControleContext).Assembly);
    }

}
