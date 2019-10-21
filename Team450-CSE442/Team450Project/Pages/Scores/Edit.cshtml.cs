using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team450Project.Data;
using Team450Project.Models;

namespace Team450Project.Pages.Scores
{
    public class EditModel : PageModel
    {
        private readonly Team450Project.Data.Team450ProjectContext _context;

        public EditModel(Team450Project.Data.Team450ProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ScoreBoard ScoreBoard { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ScoreBoard = await _context.ScoreBoard.FirstOrDefaultAsync(m => m.ID == id);

            if (ScoreBoard == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ScoreBoard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ScoreBoardExists(ScoreBoard.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ScoreBoardExists(int id)
        {
            return _context.ScoreBoard.Any(e => e.ID == id);
        }
    }
}
