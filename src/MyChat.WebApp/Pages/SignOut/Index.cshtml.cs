using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyChat.Core.UseCases.SignOut;

namespace MyChat.WebApp.Pages.SignOut;

public class IndexModel(
    ISender sender
) : PageModel
{
    public async Task<IActionResult> OnPostAsync()
    {
        await sender.Send(
            new SignOutCommand()
        );

        return RedirectToPage("/Login/Index");
    }
}