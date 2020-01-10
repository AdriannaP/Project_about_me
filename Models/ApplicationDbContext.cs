using Microsoft.EntityFrameworkCore;
using System;

namespace ProjectAboutMe.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Square> Squares { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

    }
}