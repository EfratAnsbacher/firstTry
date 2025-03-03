using les3.Models;
using les3.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace les3.Services
{
    public class GiftService : IGiftService
    {
        private readonly IGiftRepository _giftRepository;

        public GiftService(IGiftRepository giftRepository)
        {
            _giftRepository = giftRepository;
        }
        public List<Gift> GetGifts()
        {
            var allGifts = _giftRepository.GetAll();
            return allGifts;
        }

        public void AddGift(Gift newGift)
        {
            _giftRepository.Add(newGift);
        }

        public Gift GetGiftById(int id)
        {
            return _giftRepository.GetById(id);
        }

        public void UpdateGift(Gift gift)
        {
            _giftRepository.Update(gift);
        }

        public void DeleteGift(int id)
        {
            _giftRepository.Delete(id);
        }

        public Gift GetGiftByGiftName(string giftName)
        {
            return _giftRepository.GetByGiftName(giftName);
        }

        public Gift GetGiftByDonorName(string donorName)
        {
            return _giftRepository.GetByDonorName(donorName);
        }

        public Gift GetGiftByNumOfBuyers(int numOfBuyers)
        {
            return _giftRepository.GetByNumOfBuyers(numOfBuyers);
        }

        //public List<Gift> GetTasksByUser(int userId)
        //{
        //    return _taskRepository.GetTasksByUser(userId);
        //}

        //public List<Tasks> GetTasksByProject(int projectId)
        //{
        //    return _taskRepository.GetTasksByProject(projectId);
        //}
    }
}
