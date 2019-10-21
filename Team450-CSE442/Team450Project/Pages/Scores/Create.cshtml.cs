using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Team450Project.Data;
using Team450Project.Models;

namespace Team450Project.Pages.Scores
{
    public class CreateModel : PageModel
    {
        private readonly Team450Project.Data.Team450ProjectContext _context;

        public CreateModel(Team450Project.Data.Team450ProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ScoreBoard ScoreBoard { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ScoreBoard.Add(ScoreBoard);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
