using les3.Models;
using les3.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace les3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiftController : ControllerBase
    {

        private readonly IGiftService _giftService;


        public GiftController(IGiftService giftService)
        {
            _giftService = giftService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var gifts = _giftService.GetGifts();
            return Ok(gifts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var gift = _giftService.GetGiftById(id);
            if (gift == null)
            {
                return NotFound();
            }
            return Ok(gift);
        }

        [HttpPost]
        public IActionResult Create(Gift gift)
        {
            _giftService.AddGift(gift);
            return CreatedAtAction(nameof(Get), new { id = gift.Id }, gift);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Gift gift)
        {
            if (id != gift.Id)
            {
                return BadRequest();
            }

            _giftService.UpdateGift(gift);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _giftService.DeleteGift(id);
            return NoContent();
        }

        [HttpGet("{gift}")]
        public IActionResult GetByGiftName(string title)
        {
            var gift = _giftService.GetGiftByGiftName(title);
            if (gift == null)
            {
                return NotFound();
            }
            return Ok(gift);
        }

        [HttpGet("{donor}")]
        public IActionResult GetByDonorName(string donorName)
        {
            var gift = _giftService.GetGiftByDonorName(donorName);
            if (gift == null)
            {
                return NotFound();
            }
            return Ok(gift);
        }

        [HttpGet("{numOfBuyers}")]
        public IActionResult GetByNumOfBuyers(int numOfBuyers)
        {
            var gift = _giftService.GetGiftByNumOfBuyers(numOfBuyers);
            if (gift == null)
            {
                return NotFound();
            }
            return Ok(gift);
        }

        //// GET tasks by userId
        //[HttpGet("/tasksByUserId/{userId}")]
        //public IActionResult GetTasksByUser(int userId)
        //{
        //    var tasks = _taskService.GetTasksByUser(userId);
        //    if (tasks == null)
        //        return NotFound("User not found");

        //    return Ok(tasks);
        //}

        //// GET tasks by projectId
        //[HttpGet("/tasksByProjectId/{projectId}")]
        //public IActionResult GetTasksByProject(int projectId)
        //{
        //    var projects = _taskService.GetTasksByProject(projectId);
        //    if (projects == null)
        //        return NotFound("Project not found");

        //    return Ok(projects);
        //}


    }
}
