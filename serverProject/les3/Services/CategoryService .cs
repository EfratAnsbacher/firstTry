using les3.Models;
using les3.Repositories;
using System.Threading.Tasks;

namespace les3.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<Category> GetCategorys()
        {
            var allCategorys = _categoryRepository.GetAll();
            return allCategorys;
        }

        public void AddCategory(Category newCategory)
        {
            _categoryRepository.Add(newCategory);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}
