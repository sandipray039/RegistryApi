using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistryApi.Db;

namespace RegistryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly RegistryDbContext db;

        public LocationController(RegistryDbContext db)
        {
            this.db = db;
        }
        [HttpGet("get-locations")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetLocations()
        {
            try
            {
                var locations = await db.Locations.ToListAsync();
                return Ok(locations);

            }
            catch(Exception ex)
            {
                return StatusCode(500, new { message = "An error occured while fetching locations", error = ex.Message });
            }
        }
    }
}
