using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyChat.Core.Models.Identity;

namespace MyChat.DataAccess.Configurations;

internal class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        //builder.HasMany(a => a.Contacts)
        //    .WithOne(c => c.FirstUser)
        //    .HasForeignKey(c => c.FirstUserId);

        //builder.HasMany(a => a.Contacts)
        //    .WithOne(c => c.SecondUser)
        //    .HasForeignKey(c => c.SecondUserId);

        //builder.HasMany(a => a.AddToContactRequests)
        //    .WithOne(x => x.Sender)
        //    .HasForeignKey(x => x.SenderId);

        //builder.HasMany(a => a.AddToContactRequests)
        //    .WithOne(x => x.Receiver)
        //    .HasForeignKey(x => x.ReceiverId);

        builder.HasMany(a => a.ContactsAsFirstUser)
            .WithOne(c => c.FirstUser)
            .HasForeignKey(c => c.FirstUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.ContactsAsSecondUser)
            .WithOne(c => c.SecondUser)
            .HasForeignKey(c => c.SecondUserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.AddToContactRequestsAsSender)
            .WithOne(x => x.Sender)
            .HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(a => a.AddToContactRequestsAsReceiver)
            .WithOne(x => x.Receiver)
            .HasForeignKey(x => x.ReceiverId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}