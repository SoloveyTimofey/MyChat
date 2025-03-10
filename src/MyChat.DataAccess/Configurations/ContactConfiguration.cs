using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyChat.Core.Models.ContactCluster.Entites;
using MyChat.Core.Models.ContactCluster.ValuesObjects;

namespace MyChat.DataAccess.Configurations;

internal sealed class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .ValueGeneratedNever()
            .HasConversion(c => c.Id, value => new ContactId(value));

        //builder.HasOne(c => c.FirstUser)
        //    .WithMany(u => u.Contacts)
        //    .HasForeignKey(c => c.FirstUserId);

        //builder.HasOne(c => c.SecondUser)
        //    .WithMany()
        //    .HasForeignKey(c => c.SecondUserId);
    }
}