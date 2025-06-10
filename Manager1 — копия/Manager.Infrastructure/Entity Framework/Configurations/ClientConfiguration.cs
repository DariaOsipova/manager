using Manager.Domain.Entities;
using Manager.ValueObjects.Validators;
using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
               .HasConversion(name => name.Value, value => new UserName(value))
               .IsRequired()
               .HasMaxLength(UserNameValidator.MAX_LENGTH);

        builder.Property(c => c.Contacts)
               .HasConversion(c => c.Value, v => new ContactInfo(v))
               .IsRequired();

        builder.Property(c => c.RegistrationDate).IsRequired();
        builder.Property(c => c.IsVip).IsRequired();

        builder.Ignore(c => c.Requests);
        builder.Ignore(c => c.Deals);
    }
}
