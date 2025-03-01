using MyChat.Core.Primitives;
using MyChat.Core.Errors;
using MyChat.Core.Shared;

namespace MyChat.Core.Models.ChatCluster.ValueObjects;

public class MessageValue : ValueObject
{
    public const int MAX_LENGTH = 300;
    private MessageValue(string message)
    {
        Value = message;
    }
    public string Value { get; }
    public static Result<MessageValue> Create(string message)
    {
        if (message.Length > MAX_LENGTH)
        {
            return Result.Failure<MessageValue>(CoreErrors.Chat.InvalidMessageLenght);
        }

        return Result.Success(
            new MessageValue(message)
        );
    }
    public override IEnumerable<object?> GetAtomicValues()
    {
        yield return Value;
    }
}