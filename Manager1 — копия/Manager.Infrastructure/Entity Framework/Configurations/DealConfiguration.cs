using Manager.Domain.Entities;
using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class DealConfiguration : IEntityTypeConfiguration<Deal>
{
    public void Configure(EntityTypeBuilder<Deal> builder)
    {
        builder.HasKey(d => d.Id);

        builder.Property(d => d.PropertyId).IsRequired();
        builder.Property(d => d.ClientId).IsRequired();
        builder.Property(d => d.ManagerId).IsRequired();

        builder.Property(d => d.Price)
               .HasConversion(v => v.Value, v => new Money(v))
               .IsRequired();

        builder.Property(d => d.Commission)
               .HasConversion(v => v.Value, v => new Money(v))
               .IsRequired();

        builder.Property(d => d.ContractNumber)
               .HasConversion(v => v.Value, v => new Number(v))
               .IsRequired();

        builder.Property(d => d.DealType).IsRequired();
        builder.Property(d => d.Status).IsRequired();
        builder.Property(d => d.PaymentStatus).IsRequired();
        builder.Property(d => d.StartDate).IsRequired();
        builder.Property(d => d.EndDate);
        builder.Property(d => d.Notes)
               .HasConversion(v => v != null ? v.Value : null, v => v != null ? new Message(v) : null);
        builder.HasOne<Client>()
       .WithMany()
       .HasForeignKey(d => d.ClientId)
       .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<ManagerEntity>()
               .WithMany()
               .HasForeignKey(d => d.ManagerId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Property>()
               .WithMany()
               .HasForeignKey(d => d.PropertyId)
               .OnDelete(DeleteBehavior.Restrict);

    }
}
