using les3.Models;
using Microsoft.EntityFrameworkCore;

namespace les3.Repositories
{
    public class DonorRepository:IDonorRepository
    {

        private readonly AppDbContext _context;

        public DonorRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Donor donor)
        {
            var userExists = _context.Users.Find(donor.userId);
            var donorExist = _context.Donors.FirstOrDefaultAsync(d => d.userId == donor.userId);
            if (userExists != null && donorExist.Result == null)
            {
                donor.Gifts = null;
                _context.Donors.Add(donor);
                _context.SaveChanges();
            }
           

            
        }

        public void Delete(int id)
        {
            Donor? donor = _context.Donors.Find(id);

            if (donor != null)
            {
                _context.Donors.Remove(donor);
                _context.SaveChanges();
            }
        }

        public  List<Donor> GetAll()
        {
            return _context.Donors.ToList();
        }

        public Donor GetById(int id)
        {
            Donor? project = _context.Donors.Find(id);
            return project;
        }

        public void Update(Donor donor)
        {
            _context.Donors.Update(donor);
            _context.SaveChanges();
        }

        public Donor GetByName(string name)
        {
            Donor? donor = _context.Donors.Find(name);
            return donor;
        }

        public Donor GetByEmail(string email)
        {
            Donor? donor = _context.Donors.Find(email);
            return donor;
        }

        public Donor GetByGift(string gift)
        {
            Donor? donor = _context.Donors.Find(gift);
            return donor;
        }
    }
}
