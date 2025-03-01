using MyChat.Core.Shared;
using MyChat.Core.Models.ChatCluster.ValueObjects;

namespace MyChat.Core.Errors;

public static class CoreErrors
{
    public static class AddToContactRequest
    {
        public static readonly Error NotPending = new Error(
            "AddToContactRequest.NotPending",
            "Cannot change request status because it's not pending.");
    }

    public static class Chat
    {
        public static readonly Error InvalidMessageLenght = new Error(
            "Chat.InvalidMessageLenght",
            $"Invalid message lenght. Max legth is {MessageValue.MAX_LENGTH}");
    }
}