using les3.Models;
using les3.Repositories;
using System.Threading.Tasks;

namespace les3.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            var allUsers = _userRepository.GetAll();
            return allUsers;
        }

        public void AddUser(User newUser)
        {
            _userRepository.Add(newUser);
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void UpdateUser(User user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }
    }
}
