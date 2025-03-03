using les3.Models;
using System.Threading.Tasks;

namespace les3.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
