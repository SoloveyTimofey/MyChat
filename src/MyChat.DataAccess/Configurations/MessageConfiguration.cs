using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyChat.Core.Models.ChatCluster.Entities;
using MyChat.Core.Models.ChatCluster.ValueObjects;

namespace MyChat.DataAccess.Configurations;

internal sealed class MessageConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(m => m.Id)
            .ValueGeneratedNever()
            .HasConversion(m => m.Id, value => new MessageId(value));

        builder.Property(m => m.MessageValue)
            .HasConversion(m => m.Value, value => MessageValue.Create(value).Value!)
            .HasMaxLength(MessageValue.MAX_LENGTH);
    }
}