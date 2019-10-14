using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Team450Project.Pages
{
    public class AboutModel : PageModel
    {
        public string EvanMessage { get; set; }

        public string KailashMessage { get; set; }

        public string EdwardMessage { get; set; }

        public string DeanMessage { get; set; }


        public string BrianMessage { get; set; }

        public void OnGet()
        {
            EvanMessage = "Evan Brown";

            KailashMessage = "Kailash Ghimirey";

            EdwardMessage = "Edward Kim";

            DeanMessage = "Dean Kuhne";

            BrianMessage = "Brian McCann";
        }
    }
}
