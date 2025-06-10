using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Manager.Domain.Entities;

namespace Manager.Infrastructure.Configurations;

public class ManagerConfiguration : IEntityTypeConfiguration<ManagerEntity>
{
    public void Configure(EntityTypeBuilder<ManagerEntity> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Name)
               .HasConversion(v => v.Value, v => new UserName(v))
               .IsRequired();

        builder.Property(m => m.Department)
               .HasConversion(v => v.Value, v => new Department(v))
               .IsRequired();
    }
}


