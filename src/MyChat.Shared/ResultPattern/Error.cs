namespace MyChat.Core.Shared;

public class Error
{
    public static readonly Error None = new(string.Empty, string.Empty);
    public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null.");
    public Error(string code, string message)
    {
        Code = code;
        Message = message;
    }

    public string Code { get; init; }
    public string Message { get; init; }

    public override string ToString() => Code;
}