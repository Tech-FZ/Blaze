using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Test_Demo1.Models
{
    public class Company : Entity
    {
        public string? Name {get; set;}
    }
}