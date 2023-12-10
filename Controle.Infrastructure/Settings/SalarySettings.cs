using Controle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Infrastructure.Settings;

public class SalarySettings : IEntityTypeConfiguration<Salary>
{
    public void Configure(EntityTypeBuilder<Salary> builder)
    {
        builder.ToTable("Salaries");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.ValueSalary).HasColumnName("ValueSalary");
        builder.Property(x => x.SavePorcentage).HasColumnName("SavePorcentage");
    }
}
