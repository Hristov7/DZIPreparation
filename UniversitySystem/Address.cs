namespace UniversitySystem
{
    public class Address
    {
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }

        public string City { get; set; }
        public string Street { get; set; }

        public void PrintAddress()
        {
            Console.WriteLine($"City: {this.City}, Street {this.Street}");
        }
    }
}
