using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesInputForm.Pages.Accounts
{
    public class CongratsModel : PageModel
    {
        public string? Username { get; set; }
        public bool DailyNewsletter { get; set; }

        public void OnGet(string username, bool dailyNewsletter)
        {
            Username = username;
            DailyNewsletter = dailyNewsletter;
        }
    }
}
