using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyChat.Core.UseCases.Register;
using MyChat.WebApp.Models.Register;

namespace MyChat.WebApp.Pages.Register;

public class IndexModel(
    ISender sender   
) : PageModel
{
    public void OnGet()
    {
    }

    [BindProperty]
    public RegisterModel Input { get; set; } = null!;

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var result = await sender.Send(
            new RegisterCommand(
                Input.UserName,
                Input.EmailAddress,
                Input.Password
            )
        );

        if (result.IsSuccess)
            return RedirectToPage("/Index");
        else
            ModelState.AddModelError(string.Empty, result.Errors.First());
        

        return Page();
    }

}