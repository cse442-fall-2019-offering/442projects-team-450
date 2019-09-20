using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Team450Project.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public string Message1 { get; set; }

        public void OnGet()
        {
            Message = "Support";
            Message1 = "Questions";
        }
    }
}
