using les3.Models;
using les3.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace les3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {

        private readonly IDonorService _donorService;

         
        public DonorController(IDonorService donorService)
        {
            _donorService = donorService;
        }

        [HttpGet]
        public  IActionResult GetAll()
        {
            var donors = _donorService.GetDonors();
            return Ok(donors);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var donor = _donorService.GetDonorById(id);
            if (donor == null)
            {
                return NotFound();
            }
            return Ok(donor);
        }

        [HttpPost]
        public IActionResult Create(Donor donor)
        {
            _donorService.AddDonor(donor);
            return CreatedAtAction(nameof(Get), new { id = donor.Id }, donor);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Donor donor)
        {
            if (id != donor.Id)
            {
                return BadRequest();
            }

            _donorService.UpdateDonor(donor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _donorService.DeleteDonor(id);
            return NoContent();
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name)
        {
            var donor = _donorService.GetDonorByName(name);
            if (donor == null)
            {
                return NotFound();
            }
            return Ok(donor);
        }

        [HttpGet("{email}")]
        public IActionResult GetByEmail(string email)
        {
            var donor = _donorService.GetDonorByEmail(email);
            if (donor == null)
            {
                return NotFound();
            }
            return Ok(donor);
        }

        [HttpGet("{gift}")]
        public IActionResult GetByGift(string title)
        {
            var donor = _donorService.GetDonorByGift(title);
            if (donor == null)
            {
                return NotFound();
            }
            return Ok(donor);
        }

    }
}
