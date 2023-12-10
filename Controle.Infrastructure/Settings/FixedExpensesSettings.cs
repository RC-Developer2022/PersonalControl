using Controle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Infrastructure.Settings;

public class FixedExpensesSettings : IEntityTypeConfiguration<FixedExpenses>
{
    public void Configure(EntityTypeBuilder<FixedExpenses> builder)
    {
        builder.ToTable("FixedExpenses");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.NameExpenses).HasColumnName("NameExpenses");
        builder.Property(x => x.ValueExpenses).HasColumnName("ValueExpenses");
    }
}
