using MyChat.Core.Models.ContactCluster.ValuesObjects;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.Models.ContactCluster.Entites;

public class Contact(ContactId id, string firstUserId, string secondUserId)
{
    public ContactId Id { get; set; } = id;

    public string FirstUserId { get; } = firstUserId;
    public ApplicationUser FirstUser { get; } = null!;

    public string SecondUserId { get; } = secondUserId;
    public ApplicationUser SecondUser { get; } = null!;
}
