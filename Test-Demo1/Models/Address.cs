namespace Test_Demo1.Models
{
    public class Address : Entity
    {
        public required string Street {get; set;}

        public required string HouseNumber {get; set;}

        public required string Postcode {get; set;}

        public required string City {get; set;}

        public required string Country {get; set;}
    }
}