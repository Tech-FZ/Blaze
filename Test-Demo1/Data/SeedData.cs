using Microsoft.EntityFrameworkCore;
using Test_Demo1.Models;

namespace Test_Demo1.Data
{
    public class SeedData()
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using var context = new BlazeDbContext(serviceProvider.GetRequiredService<DbContextOptions<BlazeDbContext>>());
            var genderList = new List<Gender>();
            var companyList = new List<Company>();

            if (context == null || context.Characters == null || context.Companies == null)
            {
                throw new NullReferenceException("Either the database context or one of its datasets are null.");
            }

            #region Gender Setup

            if (context.Genders.Any())
            {
                genderList = context.Genders.ToList();
            }

            else
            {
                genderList.AddRange(
                    new Gender
                    {
                        LongName = "Male",
                        ShortName = "m"
                    },

                    new Gender
                    {
                        LongName = "Female",
                        ShortName = "f"
                    }
                );

                context.Genders.AddRange(genderList);
            }

            #endregion

            #region Company Setup

            if (context.Companies.Any())
            {
                companyList = context.Companies.ToList();
            }

            else
            {
                companyList.Add(new Company
                {
                    Name = "NewSys GmbH"
                });
            }

            #endregion

            if (!context.Characters.Any())
            {
                context.Characters.AddRange(
                    new Character
                    {
                        BirthDate = new DateTime(2006, 8, 22),
                        IsStudent = true,
                        Name = "Nicolas",
                        SelectedGender = genderList[0],
                        SelectedCompany = companyList[0]
                    },

                    new Character
                    {
                        BirthDate = new DateTime(1983, 12, 22),
                        Name = "Sylvia",
                        SelectedGender = genderList[1],
                        SelectedCompany = companyList[0]
                    }
                );
            }

            context.SaveChanges();
        }
    }
}