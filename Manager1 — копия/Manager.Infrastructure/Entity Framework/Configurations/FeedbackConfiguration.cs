using Manager.Domain.Entities;
using Manager.Domain.Enums;
using Manager.Domain.ValueObjects;
using Manager.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Manager.Infrastructure.Configurations;

public class FeedbackConfiguration : IEntityTypeConfiguration<Feedback>
{
    public void Configure(EntityTypeBuilder<Feedback> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.DealId)
               .IsRequired();

        builder.Property(f => f.Comment)
               .HasConversion(v => v.Value, v => new Comment(v))
               .HasMaxLength(500)
               .IsRequired();

        builder.Property(f => f.Rating)
               .HasConversion<int>()
               .IsRequired();

        builder.HasIndex(f => f.DealId); // если нужна фильтрация по сделке

        builder.HasOne(f => f.Deal)
       .WithOne(d => d.Feedback)
       .HasForeignKey<Feedback>(f => f.DealId)
       .IsRequired()
       .OnDelete(DeleteBehavior.Cascade);


    }
}

