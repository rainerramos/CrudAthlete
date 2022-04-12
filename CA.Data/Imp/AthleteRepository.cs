using CA.Data.Interfaces;
using CA.Domain;

namespace CA.Data.Imp
{
    public class AthleteRepository : IAthleteRepository
    {
        private readonly MainContext _db;

        public AthleteRepository(MainContext db)
        {
            _db = db;
        }

        public void Add(Athlete athlete)
        {
            _db.Athlete.Add(athlete);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Athlete athlete = Get(id);
            if (athlete != null)
            {
                _db.Athlete.Remove(athlete);
                _db.SaveChanges();
            }
        }

        public Athlete Get(Guid id)
        {
            return _db.Athlete.First(x => x.Id == id);
        }

        public IEnumerable<Athlete> GetAll()
        {
            return _db.Athlete;
        }

        public void Update(Guid id, Athlete athleteDTO)
        {
            Athlete athlete = Get(id);

            if (athlete != null)
            {
                athleteDTO.SetId(athlete.Id);
                _db.Athlete.Update(athlete);
                _db.SaveChanges();
            }
        }
    }
}
