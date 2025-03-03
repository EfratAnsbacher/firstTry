using les3.Models;

namespace les3.Repositories
{
    public interface IDonorRepository
    {
        List<Donor> GetAll();
        Donor GetById(int id);
        void Add(Donor donor);
        void Update(Donor donor);
        void Delete(int id);
        Donor GetByName(string name);
        Donor GetByEmail(string email);
        Donor GetByGift(string title);

    }
}