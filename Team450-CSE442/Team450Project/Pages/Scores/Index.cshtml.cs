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
    public class IndexModel : PageModel
    {
        private readonly Team450Project.Data.Team450ProjectContext _context;

        public IndexModel(Team450Project.Data.Team450ProjectContext context)
        {
            _context = context;
        }

        public IList<ScoreBoard> ScoreBoard { get;set; }
        public IList<ScoreBoard1> ScoreBoard1 { get; set; }

        public async Task OnGetAsync()
        {
            ScoreBoard = await _context.ScoreBoard.ToListAsync();
            ScoreBoard1 = await _context.ScoreBoard1.ToListAsync();
        }
      
    }
}
