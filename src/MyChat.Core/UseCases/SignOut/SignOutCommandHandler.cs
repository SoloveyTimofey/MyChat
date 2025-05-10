using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.UseCases.SignOut;

internal sealed class SignOutCommandHandler(
    SignInManager<ApplicationUser> signInManager
) : IRequestHandler<SignOutCommand, Result>
{
    public async Task<Result> Handle(SignOutCommand request, CancellationToken cancellationToken)
    {
        await signInManager.SignOutAsync();

        return Result.Success();
    }
}