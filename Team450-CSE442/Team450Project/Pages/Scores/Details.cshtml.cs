using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Team450Project.Data;
using Team450Project.Models;

namespace Team450Project.Pages.Scores
{
    public class DetailsModel : PageModel
    {
        private readonly Team450Project.Data.Team450ProjectContext _context;

        public DetailsModel(Team450Project.Data.Team450ProjectContext context)
        {
            _context = context;
        }

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
    }
}
