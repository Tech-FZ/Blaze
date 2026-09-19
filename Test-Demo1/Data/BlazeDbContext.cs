using Microsoft.EntityFrameworkCore;
using Test_Demo1.Models;

namespace Test_Demo1.Data
{
    public class BlazeDbContext : DbContext
    {
        public BlazeDbContext(DbContextOptions<BlazeDbContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters {get; set;} = default!;

        public DbSet<Company> Companies {get; set;} = default!;
    }
}