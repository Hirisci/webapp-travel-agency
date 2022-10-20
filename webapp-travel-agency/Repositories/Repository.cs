using Microsoft.EntityFrameworkCore.ChangeTracking;
using webapp_travel_agency.Data;

namespace webapp_travel_agency.Repositories
{
    public class Repository<T>
    {
        private readonly AppDbContext _db;

        public Repository(AppDbContext db)
        {
            _db = db.Set<>();
        }
        
        public void Add(T obj)
        {

        }
    }
}
