using System.Collections.ObjectModel;

namespace Test_Demo1.Models
{
    public class Company : Entity
    {
        public required string Name {get; set;}

        public required Address SelectedAddress {get; set;}

        public required ObservableCollection<SocialMedia> SocialMedias {get; set;}

        public required ObservableCollection<Character> Executives {get; set;}

        public int EmployeeCount {get; set;}
    }
}