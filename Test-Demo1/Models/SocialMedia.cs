namespace Test_Demo1.Models
{
    public class SocialMedia : Entity
    {
        public string? Platform {get; set;}

        public string? Link {get; set;}

        public Company? SelectedCompany {get; set;}

        public Character? SelectedCharacter {get; set;}
    }
}