using Test_Demo1.Models;

namespace Test_Demo1.Mappers
{
    public class CharacterMapper : IMapper<Character, CharacterDto>
    {
        public CharacterDto FromAToB(Character a)
        {
            var characterDto = new CharacterDto
            {
                Id = a.Id,
                Name = a.Name,
                BirthDate = a.BirthDate,
                IsStudent = a.IsStudent
            };

            if (a.SelectedCompany != null)
            {
                characterDto.SelectedCompanyId = a.SelectedCompany.Id;
            }

            characterDto.SelectedCompanyId = a.SelectedCompanyId;

            if (a.SelectedGender != null)
            {
                characterDto.SelectedGenderId = a.SelectedGender.Id;
            }

            characterDto.SelectedGenderId = a.SelectedGenderId;

            return characterDto;
        }

        public Character FromBToA(CharacterDto b)
        {
            Character character = new Character
            {
                Id = b.Id,
                IsStudent = b.IsStudent,
                Name = b.Name,
                BirthDate = b.BirthDate,
                SelectedCompanyId = b.SelectedCompanyId,
                SelectedGenderId = b.SelectedGenderId
            };

            // TODO: Fetch company and gender from database?

            return character;
        }
    }
}