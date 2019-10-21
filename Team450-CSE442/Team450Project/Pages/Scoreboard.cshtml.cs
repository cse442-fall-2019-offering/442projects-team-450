using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Team450Project.Pages
{
    public class ScoreboardModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "View high scores here.";
        }
    }
}
