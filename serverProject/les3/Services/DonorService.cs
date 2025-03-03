using les3.Models;
using les3.Repositories;

namespace les3.Services
{
    public class DonorService:IDonorService
    {
        private readonly IDonorRepository _donorRepository;

        public DonorService(IDonorRepository donorRepository)
        {
            _donorRepository = donorRepository;
        }
        public List<Donor> GetDonors()
        {
            var allDonors =  _donorRepository.GetAll();
            return allDonors;
        }

        public void AddDonor(Donor newDonor)
        {
            _donorRepository.Add(newDonor);
        }

        public Donor GetDonorById(int id)
        {
            return _donorRepository.GetById(id);
        }

        public void UpdateDonor(Donor donor)
        {
            _donorRepository.Update(donor);
        }

        public void DeleteDonor(int id)
        {
            _donorRepository.Delete(id);
        }

        public Donor GetDonorByName(string name)
        {
            return _donorRepository.GetByName(name);
        }

        public Donor GetDonorByEmail(string email)
        {
            return _donorRepository.GetByEmail(email);
        }

        public Donor GetDonorByGift(string title)
        {
            return _donorRepository.GetByGift(title);
        }
    }
}
