using Controle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Infrastructure.Settings;

public class InvestmentsSettings : IEntityTypeConfiguration<Investments>
{
    public void Configure(EntityTypeBuilder<Investments> builder)
    {
        builder.ToTable("Investments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.InvestName).HasColumnName("InvestName");
        builder.Property(x => x.InvestValue).HasColumnName("InvestValue");
        builder.Property(x => x.InstitutionName).HasColumnName("InstitutionName");
    }
}
