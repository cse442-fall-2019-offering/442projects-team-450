using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Team450Project.Pages
{
    public class HomeModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "View high scores here.";
        }
    }
}
