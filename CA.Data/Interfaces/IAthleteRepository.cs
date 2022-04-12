using CA.Domain;

namespace CA.Data.Interfaces
{
    public interface IAthleteRepository
    {
        void Add(Athlete athlete);        
        IEnumerable<Athlete> GetAll();
        Athlete GetById(Guid id);
        void Update(Guid id,Athlete athlete);
        void Delete(Guid id);
    }
}
