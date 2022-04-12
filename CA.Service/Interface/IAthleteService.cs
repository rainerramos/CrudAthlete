using CA.Domain;

namespace CA.Service.Interface
{
    public interface IAthleteService
    {
        void Add(Athlete athlete);
        IEnumerable<Athlete> GetAll();
        Athlete Get(Guid id);
        void Update(Guid id, Athlete athlete);
        void Delete(Guid id);
        bool IsCpf(string cpf)
    }
}
