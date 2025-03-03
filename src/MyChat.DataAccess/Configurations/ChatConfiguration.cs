using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyChat.Core.Models.ChatCluster.Entities;
using MyChat.Core.Models.ChatCluster.ValueObjects;

namespace MyChat.DataAccess.Configurations;

internal sealed class ChatConfiguration : IEntityTypeConfiguration<Chat>
{
    public void Configure(EntityTypeBuilder<Chat> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(c => c.Id, value => new ChatId(value));

        builder.HasMany(c => c.Messages)
            .WithOne()
            .HasForeignKey(m => m.ChatId);

        builder.HasOne(c => c.Contact)
            .WithMany()
            .HasForeignKey(c => c.ContactId);
    }
}