using les3.Models;

namespace les3.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Category category)
        {
            _context.Categorys.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category? category = _context.Categorys.Find(id);

            if (category != null)
            {
                _context.Categorys.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAll()
        {
            return _context.Categorys.ToList();
        }

        public Category GetById(int id)
        {
            Category? category = _context.Categorys.Find(id);
            return category;
        }

        public void Update(Category category)
        {
            _context.Categorys.Update(category);
            _context.SaveChanges();
        }
    }
}
