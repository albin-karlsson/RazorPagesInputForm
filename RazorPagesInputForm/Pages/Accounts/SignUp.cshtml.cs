using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesInputForm.Pages.Accounts
{
    [BindProperties]
    public class SignUpModel : PageModel
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool DailyNewsletter { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username != null && Password != null)
            {
                return RedirectToPage("/Accounts/Congrats", new { Username, DailyNewsletter });
            }
            else
            {
                return Page();
            }
        }
    }
}