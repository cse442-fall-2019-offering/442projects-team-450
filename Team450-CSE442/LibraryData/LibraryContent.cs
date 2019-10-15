using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContent : DbContext
    {
        public LibraryContent(DbContextOptions options) : base(options) { }
        public DbSet<Patron> Patrons { get; set; }

    }
}
