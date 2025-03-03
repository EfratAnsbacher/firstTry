using les3.Models;

namespace les3.Repositories
{
    public interface IGiftRepository
    {
        List<Gift> GetAll();
        Gift GetById(int id);
       string Add(Gift gift);
        void Update(Gift gift);
        void Delete(int id);
        Gift GetByGiftName(string giftName);
        Gift GetByDonorName(string donorName);
        Gift GetByNumOfBuyers(int numOfBuyers);
        //List<Tasks> GetTasksByUser(int userId);
        //List<Tasks> GetTasksByProject(int projectId);
    }
}
