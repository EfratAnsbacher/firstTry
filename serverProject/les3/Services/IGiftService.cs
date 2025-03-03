using les3.Models;
using System.Threading.Tasks;

namespace les3.Services
{
    public interface IGiftService
    {
        List<Gift> GetGifts();
        Gift GetGiftById(int id);
        void AddGift(Gift gift);
        void UpdateGift(Gift gift);
        void DeleteGift(int id);
        Gift GetGiftByGiftName(string giftName);
        Gift GetGiftByDonorName(string donorName);
        Gift GetGiftByNumOfBuyers(int numOfBuyers);

        //List<Gift> GetTasksByUser(int userId);
        //List<Gift> GetTasksByProject(int projectId);
    }
}
