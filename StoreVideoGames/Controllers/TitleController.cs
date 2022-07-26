using EFDataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreVideoGames.DTOs.TitleDTOs;
using StoreVideoGames.Manager;
using StoreVideoGames.Manager.TitleM;

namespace StoreVideoGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleController : ControllerBase
    {
        private readonly ITitleManager _titleManager;

        public TitleController(ITitleManager titleManager)
        {
            _titleManager = titleManager;
        }



        [HttpGet]
        public async Task<ActionResult> GetTitles()
        {
            var titles = await _titleManager.GetAsync();
            return Ok(titles);
        }

        [HttpPost]

        public async Task<IActionResult> CreateTitle(CreateTitleDTO createTitleDTO)
        {
            ManagerResult<Title> managerResult = await _titleManager.AddAsync(createTitleDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }

        [HttpPut("{id}")]
        //[Authorize(Roles = UserRols.Admin)]
        public async Task<IActionResult> UpdateTitle(int id, CreateTitleDTO createTitleDTO)
        {
            ManagerResult<Title> managerResult = await _titleManager.UpdateAsync(id, createTitleDTO);

            if (!managerResult.Success)
            {
                return BadRequest(managerResult);
            }

            return Ok(managerResult);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            //var brand = await _context.BrandVehicle.Where(t => t.Id == id).FirstOrDefaultAsync();

            //if (brand == null) return NotFound(new { Ok = false, Message = "Brand not found" });

            //_context.BrandVehicle.Remove(brand);
            //await _context.SaveChangesAsync();
            return Ok(new { success = true, message = "Delete successfully" });

        }
    }
}
