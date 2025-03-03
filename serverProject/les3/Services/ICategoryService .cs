using les3.Models;
using System.Threading.Tasks;

namespace les3.Services
{
    public interface ICategoryService
    {
        List<Category> GetCategorys();
        Category GetCategoryById(int id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
