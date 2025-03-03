using MyChat.Core.Models.ChatCluster.ValueObjects;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.Models.ChatCluster.Entities;

public class Message
{
    #pragma warning disable
    private Message() { } // EF Core constructor
    #pragma warning enable

    public Message(MessageId id, ChatId chatId, string senderId, MessageValue messageValue, DateTime sentDateTime)
    {
        Id = id;
        ChatId = chatId;
        SenderId = senderId;
        MessageValue = messageValue;
        SentDateTime = sentDateTime;
    }
    public MessageId Id { get; }

    public ChatId ChatId { get; }
    public Chat Chat { get; } = null!;

    public string SenderId { get; }
    public ApplicationUser Sender { get; } = null!;

    public MessageValue MessageValue { get; set; }
    public DateTime SentDateTime { get; }
}