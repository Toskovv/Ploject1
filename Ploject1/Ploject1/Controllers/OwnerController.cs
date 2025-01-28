using CarStore.BL.Services;
using CarStore.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Ploject1.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            return Ok(_ownerService.GetAllOwners());
        }

        [HttpPost]
        public IActionResult CreateOwner([FromBody] Owner owner)
        {
            _ownerService.CreateOwner(owner);
            return CreatedAtAction(nameof(CreateOwner), owner);
        }
    }
}