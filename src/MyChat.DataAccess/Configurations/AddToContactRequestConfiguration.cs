using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyChat.Core.Models.ContactCluster.Entites;
using MyChat.Core.Models.ContactCluster.ValuesObjects;

namespace MyChat.DataAccess.Configurations;

internal sealed class AddToContactRequestConfiguration : IEntityTypeConfiguration<AddToContactRequest>
{
    public void Configure(EntityTypeBuilder<AddToContactRequest> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .HasConversion(x => x.Id, value => new AddToContactRequestId(value));

        //builder.HasOne(c => c.Sender)
        //    .WithMany(u => u.AddToContactRequests)
        //    .HasForeignKey(c => c.SenderId);

        //builder.HasOne(c => c.Receiver)
        //    .WithMany()
        //    .HasForeignKey(c => c.SecondUserId)
        //    .OnDelete(DeleteBehavior.Restrict);
    }
}