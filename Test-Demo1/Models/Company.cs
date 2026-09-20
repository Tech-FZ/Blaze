using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test_Demo1.Models
{
    public class Company : Entity
    {
        public string? Name {get; set;}

        public ObservableCollection<SocialMedia>? SocialMedias {get; set;}

        public ObservableCollection<Character>? Employees {get; set;}
    }
}