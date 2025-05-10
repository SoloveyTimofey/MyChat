using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.UseCases.Login;

internal sealed class LoginCommandHandler(
    SignInManager<ApplicationUser> signInManager
) : IRequestHandler<LoginCommand, Result>
{
    public async Task<Result> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var result = await signInManager.PasswordSignInAsync(
            request.UserName,
            request.Password,
            isPersistent: false,
            lockoutOnFailure: false
        );

        if (!result.Succeeded)
        {
            return Result.Error("Invalid email or password.");
        }

        return Result.Success();
    }
}