using MyChat.Core.Models.ChatCluster.ValueObjects;
using MyChat.Core.Models.ContactCluster.Entites;
using MyChat.Core.Models.ContactCluster.ValuesObjects;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.Models.ChatCluster.Entities;

public sealed class Chat
{
    public Chat(ChatId id, ContactId contactId)
    {
        Id = id;
        ContactId = contactId;
    }
    public ChatId Id { get; }

    public ContactId ContactId { get; }
    public Contact Contact { get; } = null!;

    public List<Message> Messages { get; } = new();
}