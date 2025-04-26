using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyChat.Core.UseCases.Login;
using MyChat.WebApp.Models.Login;

namespace MyChat.WebApp.Pages.Login;

public class IndexModel(
    ISender sender    
) : PageModel
{
    public void OnGet()
    {
    }

    [BindProperty]
    public LoginModel Input { get; set; } = null!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var result = await sender.Send(
            new LoginCommand(
                Input.UserName,
                Input.Password
            )
        );

        if (result.IsSuccess)
            return RedirectToPage("/Index");
        else
            foreach (var error in result.Errors)
                ModelState.AddModelError("Login", error);

        return Page();
    }
}