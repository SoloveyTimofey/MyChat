using Ardalis.Result;
using MediatR;

namespace MyChat.Core.UseCases.Login;

public sealed record LoginCommand(
    string UserName,
    string Password
) : IRequest<Result>;