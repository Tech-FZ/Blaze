using Microsoft.EntityFrameworkCore;
using Test_Demo1.Models;

namespace Test_Demo1.Data
{
    public class BlazeDbContext : DbContext
    {
        public BlazeDbContext(DbContextOptions<BlazeDbContext> options) : base(options)
        {
            
        }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<Character>
        // }

        public DbSet<Character> Characters {get; set;} = default!;

        public DbSet<Company> Companies {get; set;} = default!;

        public DbSet<Gender> Genders {get; set;} = default!;

        public DbSet<SocialMedia> SocialMedias {get; set;} = default!;
    }
}