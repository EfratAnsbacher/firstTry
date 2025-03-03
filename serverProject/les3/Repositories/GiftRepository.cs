using les3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;

namespace les3.Repositories
{
    public class GiftRepository : IGiftRepository
    {

        private readonly AppDbContext _context;

        public GiftRepository(AppDbContext context)
        {
            _context = context;
        }
        public string Add(Gift gift)
        {

            //var userExists = _context.Donors..Find(Gift.UserId);
            //if (userExists == null)
            //    return "User does not exist";

            //Validate Project
            //var projectExists = _context.Projects.Find(task.ProjectId);
            //if (projectExists == null)
            //    return "Project does not exist";

            var donorExists = _context.Donors.Find(gift.DonorId);
            var categoryExists = _context.Categorys.Find(gift.CategoryId);
            if (donorExists == null)
            {
                return "donorId is not valied";
            }
            if (categoryExists == null)
            {
                return "CategoryId is not valied";
            }
            var giftExists = _context.Gifts.FirstOrDefaultAsync(d => d.Title == gift.Title);
            if (giftExists.Result == null)
            {
                _context.Gifts.Add(gift);
                donorExists.Gifts.Add(gift);
                _context.Donors.Update(donorExists);
                _context.SaveChanges();

                return "gift created successfuly";
            }
            else
            {
                return "gift is already exist";
            }
             
        }

        public void Delete(int id){
        
            Gift? gift = _context.Gifts.Find(id);

            if (gift != null)
            {
                _context.Gifts.Remove(gift);
                _context.SaveChanges();
            }
        }

        public List<Gift> GetAll()
        {
            return _context.Gifts.ToList();
        }

        public Gift GetById(int id)
        {
            Gift? gift = _context.Gifts.Find(id);
            return gift;
        }

        public void Update(Gift gift)
        {
            _context.Gifts.Update(gift);
            _context.SaveChanges();
        }

        public Gift GetByGiftName(string giftName)
        {
            Gift? gift = _context.Gifts.Find(giftName);
            return gift;
        }

        public Gift GetByDonorName(string donorName)
        {
            Gift? gift = _context.Gifts.Find(donorName);
            return gift;
        }

        public Gift GetByNumOfBuyers(int numOfBuyers)
        {
            Gift? gift = _context.Gifts.Find(numOfBuyers);
            return gift;
        }

        //public List<Tasks> GetTasksByUser(int userId)
        //{
        //    var tasks = _context.Tasks.Where(x => x.UserId == userId);
        //    if (tasks == null)
        //        return new List<Tasks>();
        //    return tasks.ToList();
        //}

        //public List<Tasks> GetTasksByProject(int projectId)
        //{
        //    var projects = _context.Tasks.Where(x => x.ProjectId == projectId);
        //    if (projects == null)
        //        return new List<Tasks>();
        //    return projects.ToList();
        //}

    }
}
