using MyChat.Core.Models.ChatCluster.ValueObjects;

namespace MyChat.Core.Errors;

public static class CoreErrors
{
    public static class AddToContactRequest
    {
        public static readonly string NotPending = "Cannot change request status because it's not pending.";
    }

    public static class Chat
    {
        public static readonly string InvalidMessageLenght = $"Invalid message lenght. Max length is {MessageValue.MAX_LENGTH}";
    }
}