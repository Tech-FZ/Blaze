using Microsoft.EntityFrameworkCore;

namespace Test_Demo1.Data
{
    public class SeedData()
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using var context = new BlazeDbContext(serviceProvider.GetRequiredService<DbContextOptions<BlazeDbContext>>());

            if (context == null || context.Characters == null || context.Companies == null)
            {
                throw new NullReferenceException("Either the database context or one of its datasets are null.");
            }

            if (!context.Characters.Any())
            {
                context.Characters.AddRange(
                    new Models.Character
                    {
                        BirthDate = new DateTime(2006, 8, 22),
                        IsStudent = true,
                        Name = "Nicolas"
                    },

                    new Models.Character
                    {
                        BirthDate = new DateTime(1983, 12, 22),
                        Name = "Sylvia"
                    }
                );
            }

            context.SaveChanges();
        }
    }
}