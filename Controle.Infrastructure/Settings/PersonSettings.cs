using Controle.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Controle.Infrastructure.Settings;

public class PersonSettings : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.ToTable("People");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasColumnName("Name");
        builder.Property(x => x.BirthDay).HasConversion<DateTime>().HasColumnName("BirthDay");
        builder.Property(x => x.Age).HasColumnName("Age");
        builder.Property(x => x.SalaryId).HasColumnName("Salary").Metadata.IsForeignKey();
    }
}
