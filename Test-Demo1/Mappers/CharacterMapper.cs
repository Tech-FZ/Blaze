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

            if (a.SelectedGender != null)
            {
                characterDto.SelectedGenderId = a.SelectedGender.Id;
            }

            return characterDto;
        }

        public Character FromBToA(CharacterDto b)
        {
            throw new NotImplementedException();
        }
    }
}