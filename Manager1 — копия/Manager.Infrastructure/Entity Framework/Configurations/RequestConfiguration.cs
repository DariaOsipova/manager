using Manager.Domain.Entities;
using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class RequestConfiguration : IEntityTypeConfiguration<Request>
{
    public void Configure(EntityTypeBuilder<Request> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.ClientId).IsRequired();
        builder.Property(r => r.PropertyId).IsRequired();

        builder.Property(r => r.Message)
               .HasConversion(v => v.Value, v => new Message(v))
               .IsRequired();

        builder.Property(r => r.Status).IsRequired();
        builder.Property(r => r.CreatedAt).IsRequired();

        builder.Property(r => r.ResponseDate);
        builder.Property(r => r.ManagerNotes)
               .HasConversion(v => v != null ? v.Value : null, v => v != null ? new Message(v) : null);
        builder.HasOne<Client>()
       .WithMany()
       .HasForeignKey(r => r.ClientId)
       .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne<Property>()
               .WithMany()
               .HasForeignKey(r => r.PropertyId)
               .OnDelete(DeleteBehavior.Cascade);

    }
}
