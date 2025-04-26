using Ardalis.Result;
using MediatR;

namespace MyChat.Core.UseCases.SignOut;

public sealed record SignOutCommand() : IRequest<Result>;