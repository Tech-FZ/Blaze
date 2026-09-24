namespace Test_Demo1.Models
{
    public class Character : Entity
    {
        public string? Name {get; set;}

        public DateTime BirthDate {get; set;}

        public Gender? SelectedGender {get; set;}

        public int SelectedGenderId {get; set;}

        public Company? SelectedCompany {get; set;}

        public int SelectedCompanyId {get; set;}

        public bool IsStudent {get; set;}
    }
}