using les3.Models;

namespace les3.Services
{
    public interface IDonorService
    {
        List<Donor> GetDonors();
        Donor GetDonorById(int id);
        void AddDonor(Donor donor);
        void UpdateDonor(Donor donor);
        void DeleteDonor(int id);
        Donor GetDonorByName(string name);
        Donor GetDonorByEmail(string email);
        Donor GetDonorByGift(string title);
    }
}
