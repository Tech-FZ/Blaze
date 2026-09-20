namespace Test_Demo1.Models
{
    public class CharacterDto : Entity
    {
        public string? Name {get; set;}

        public DateTime BirthDate {get; set;}

        public int SelectedGenderId {get; set;}

        public int SelectedCompanyId {get; set;}

        public bool IsStudent {get; set;}
    }
}