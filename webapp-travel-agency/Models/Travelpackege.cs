using webapp_travel_agency.Data;

namespace webapp_travel_agency.Models
{
    public class Travelpackege
    {
        private readonly AppDbContext _db;

        public Travelpackege(AppDbContext db)
        {
            _db = db;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public float Price { get; set; }
        public bool IsNew { get; set; } = true;
        public int Discount { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }
}
