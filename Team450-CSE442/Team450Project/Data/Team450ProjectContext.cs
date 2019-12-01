using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team450Project.Models;

namespace Team450Project.Data
{
    public class Team450ProjectContext : DbContext
    {
        public Team450ProjectContext (DbContextOptions<Team450ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Team450Project.Models.ScoreBoard> ScoreBoard { get; set; }
        public DbSet<Team450Project.Models.ScoreBoard1> ScoreBoard1 { get; set; }
        public DbSet<Team450Project.Models.ScoreBoard2> ScoreBoard2 { get; set; }
    }

}
