namespace webapp_travel_agency.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; } = null!;
        public IEnumerable<Travelpackege>? Travelpackes { get; set; }
    }
}