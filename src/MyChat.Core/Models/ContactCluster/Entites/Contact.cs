using MyChat.Core.Models.ContactCluster.ValuesObjects;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.Models.ContactCluster.Entites;

public class Contact
{
    #pragma warning disable
    private Contact() { } // EF Core constructor
    #pragma warning enable

    public Contact(ContactId id, string firstUserId, string secondUserId, DateTime createdDateTime)
    {
        Id = id;
        FirstUserId = firstUserId;
        SecondUserId = secondUserId;
        CreatedDateTime = createdDateTime;
    }

    public ContactId Id { get; }

    public string FirstUserId { get; }
    public ApplicationUser FirstUser { get; } = null!;

    public string SecondUserId { get; }
    public ApplicationUser SecondUser { get; } = null!;

    public DateTime CreatedDateTime { get; }
}
