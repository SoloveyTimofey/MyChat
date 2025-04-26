using Ardalis.Result;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MyChat.Core.Models.Identity;

namespace MyChat.Core.UseCases.Register;

internal sealed class RegisterCommandHandler(
    UserManager<ApplicationUser> userManager
) : IRequestHandler<RegisterCommand, Result>
{
    public async Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = new ApplicationUser
        {
            UserName = request.UserName,
            Email = request.Email,
        };

        var result = await userManager.CreateAsync(user, request.Password);

        if (result.Succeeded)
        {
            return Result.Success();
        }
        return Result.Error("Invalid data.");
    }
}