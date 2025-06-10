using Manager.Domain.Entities;
using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title)
               .HasConversion(v => v.Value, v => new Title(v))
               .IsRequired();

        builder.Property(p => p.Description)
               .HasConversion(v => v.Value, v => new Title(v))
               .IsRequired();

        builder.Property(p => p.Address)
               .HasConversion(v => v.Value, v => new Address(v))
               .IsRequired();

        builder.Property(p => p.Area)
               .HasConversion(v => v.Value, v => new Area(v))
               .IsRequired();

        builder.Property(p => p.Price)
               .HasConversion(v => v.Value, v => new Money(v))
               .IsRequired();

        builder.Property(p => p.Rooms)
               .HasConversion(v => v.Value, v => new Quantity(v))
               .IsRequired();

        builder.Property(p => p.Floor)
               .HasConversion(v => v.Value, v => new Quantity(v))
               .IsRequired();

        builder.Property(p => p.TotalFloors)
               .HasConversion(v => v.Value, v => new Quantity(v))
               .IsRequired();

        builder.Property(p => p.PropertyType).IsRequired();
        builder.Property(p => p.Status).IsRequired();
        builder.Property(p => p.CreatedDate).IsRequired();

        builder.Property(p => p.OwnerId).IsRequired();
        builder.Property(p => p.PublicationDate);

        builder.Ignore(p => p.Photos);
    }
}
