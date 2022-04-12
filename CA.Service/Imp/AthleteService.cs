using CA.Data.Interfaces;
using CA.Domain;
using CA.Service.Interface;

namespace CA.Service.Imp
{
    public class AthleteService : IAthleteService
    {
        private readonly IAthleteRepository _repository;

        public AthleteService(IAthleteRepository repository)
        {
            _repository = repository;
        }

        public void Add(Athlete athlete)
        {
			_repository.Add(athlete);
        }

        public void Delete(Guid id)
        {
			_repository.Delete(id);
		}

        public Athlete Get(Guid id)
        {
			return _repository.Get(id);
		}

        public IEnumerable<Athlete> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Guid id, Athlete athlete)
        {
            _repository.Update(id, athlete);
        }

		public bool IsCpf(string cpf)
		{
			if (String.IsNullOrEmpty(cpf))
				return false;

			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;
			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");
			if (cpf.Length != 11)
				return false;
			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;
			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
		}
	}
}
