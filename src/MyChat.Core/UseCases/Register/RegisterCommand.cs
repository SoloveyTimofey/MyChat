using Ardalis.Result;
using MediatR;

namespace MyChat.Core.UseCases.Register;

public sealed record RegisterCommand(
    string UserName,
    string Email,
    string Password
) : IRequest<Result>;